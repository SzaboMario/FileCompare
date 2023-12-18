using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;

using System.Windows.Forms;

namespace FileCompareMaster
{
    public partial class MainView : Form
    {
        List<string> difLines = new List<string>();    
        List<string[]> lineList1 = new List<string[]>();
        List<string[]> lineList2 = new List<string[]>();

        public MainView()
        {
            InitializeComponent();
            sourceTable.Columns.Add("lineNum", "Line number");
            sourceTable.Columns.Add("id", "ID");
            sourceTable.Columns.Add("data", "Data");

            comparableTable.Columns.Add("lineNum", "Line number");
            comparableTable.Columns.Add("id", "ID");
            comparableTable.Columns.Add("data", "Data");

            notFindData.Columns.Add("lineNum", "orig. line number");
            notFindData.Columns.Add("id", "Orig. ID");
            notFindData.Columns.Add("data", "Orig. data");
            notFindData.Columns.Add("","");
            notFindData.Columns.Add("lineNum", "Comp. line number");
            notFindData.Columns.Add("id", "Comp. ID");
            notFindData.Columns.Add("data", "Comp. data");

        }

        private void ComparableOpen1_Click(object sender, EventArgs e)
        {          
            Compare.Enabled = true ;
            sourceTable.Rows.Clear();
            OpenFileDialog dlg= new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int pos = -1, lineCount = 0;
                    string line = "";
                    var sr = new StreamReader(dlg.FileName);
                    this.ComparableFile1.Text=dlg.FileName;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        pos = line.IndexOf('=');

                        if (line.Length>2&&line.ElementAt(0)!='\\' && line.ElementAt(1) != '\\' && pos !=-1)//ha nincs benne komment és van benne egyenlőség
                        {
                            string[] lineArray = new string[3];
                            lineCount++;
                            lineArray[0] = lineCount.ToString();
                            lineArray[1] = line.Substring(0, pos);
                            lineArray[2] = line.Substring(pos+1);
                            lineList1.Add(lineArray);
                            sourceTable.Rows.Add(lineArray[0], lineArray[1], lineArray[2]);
                        }
                    }
                    sr.Close();                                    
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }               
            }
        }

        private void ComparableOpen2_Click(object sender, EventArgs e)
        {
            comparableTable.Rows.Clear();
            Compare.Enabled = true;
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int pos = -1, lineCount=0 ;
                    string line = "";
                    var sr = new StreamReader(dlg.FileName);
                    this.ComparableFile2.Text = dlg.FileName;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        pos = line.IndexOf('=');

                        if (line.Length > 2 && line.ElementAt(0) != '\\' && line.ElementAt(1) != '\\' && pos != -1)//ha nincs benne komment és van benne egyenlőség
                        {
                            string[] lineArray = new string[3];
                            lineCount++;
                            lineArray[0] = lineCount.ToString();
                            lineArray[1] = line.Substring(0, pos);
                            lineArray[2] = line.Substring(pos + 1);
                            lineList2.Add(lineArray);
                            comparableTable.Rows.Add(lineArray[0], lineArray[1], lineArray[2]);
                        }
                    }
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }


        }

        private void Compare_Click(object sender, EventArgs e)
        {
           
            notFindData.Rows.Clear();
            bool find = false;
            for (int i = 0; i < lineList1.Count; i++)//végigmegy az orig listen
            {
                for (int j = 0; j < lineList2.Count; j++)//végigmegy az összahasonlítandó fájlon
                {
                    if (lineList1[i][1]==lineList2[j][1]&& lineList1[i][2] == lineList2[j][2])     //ha az adott orig elem ID vagy Data egyezik, akkor továbbugrik.
                    {
                        find = true;
                        break;
                    }
                    else//ha nem egyenlő, akkor find false.....
                    {
                        find = false;
                    }
                }
                if (!find)
                {
                    notFindData.Rows.Add(lineList1[i][0], lineList1[i][1], lineList1[i][2], "", lineList2[i][0], lineList2[i][1], lineList2[i][2]);
                }
            }
        }

        private void notFindData1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            DataGridViewRow row = e.Row;
            sourceTable.ClearSelection();
            comparableTable.ClearSelection();
            int z = 0;
            
               
            
                z = Convert.ToInt32(row.Cells[0].Value);




            sourceTable.CurrentCell = sourceTable.Rows[z - 1].Cells[0];
            comparableTable.CurrentCell = comparableTable.Rows[z - 1].Cells[0];
            sourceTable.Rows[z-1].Selected = true;
            comparableTable.Rows[z - 1].Selected = true;
        }
    }
}
