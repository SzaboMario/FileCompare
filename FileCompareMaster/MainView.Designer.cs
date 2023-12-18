
namespace FileCompareMaster
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComparableOpen1 = new System.Windows.Forms.Button();
            this.ComparableFile1 = new System.Windows.Forms.TextBox();
            this.Compare = new System.Windows.Forms.Button();
            this.ComparableFile2 = new System.Windows.Forms.TextBox();
            this.ComparableOpen2 = new System.Windows.Forms.Button();
            this.sourceTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comparableTable = new System.Windows.Forms.DataGridView();
            this.notFindData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparableTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFindData)).BeginInit();
            this.SuspendLayout();
            // 
            // ComparableOpen1
            // 
            this.ComparableOpen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComparableOpen1.Location = new System.Drawing.Point(470, 75);
            this.ComparableOpen1.Name = "ComparableOpen1";
            this.ComparableOpen1.Size = new System.Drawing.Size(140, 42);
            this.ComparableOpen1.TabIndex = 0;
            this.ComparableOpen1.Text = "Open source file";
            this.ComparableOpen1.UseVisualStyleBackColor = true;
            this.ComparableOpen1.Click += new System.EventHandler(this.ComparableOpen1_Click);
            // 
            // ComparableFile1
            // 
            this.ComparableFile1.Location = new System.Drawing.Point(12, 97);
            this.ComparableFile1.Name = "ComparableFile1";
            this.ComparableFile1.Size = new System.Drawing.Size(400, 20);
            this.ComparableFile1.TabIndex = 1;
            // 
            // Compare
            // 
            this.Compare.BackColor = System.Drawing.Color.Lime;
            this.Compare.Enabled = false;
            this.Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Compare.Location = new System.Drawing.Point(512, 12);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(205, 51);
            this.Compare.TabIndex = 4;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = false;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // ComparableFile2
            // 
            this.ComparableFile2.Location = new System.Drawing.Point(652, 97);
            this.ComparableFile2.Name = "ComparableFile2";
            this.ComparableFile2.Size = new System.Drawing.Size(400, 20);
            this.ComparableFile2.TabIndex = 8;
            // 
            // ComparableOpen2
            // 
            this.ComparableOpen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComparableOpen2.Location = new System.Drawing.Point(1112, 74);
            this.ComparableOpen2.Name = "ComparableOpen2";
            this.ComparableOpen2.Size = new System.Drawing.Size(140, 43);
            this.ComparableOpen2.TabIndex = 7;
            this.ComparableOpen2.Text = "Open file to compare";
            this.ComparableOpen2.UseVisualStyleBackColor = true;
            this.ComparableOpen2.Click += new System.EventHandler(this.ComparableOpen2_Click);
            // 
            // sourceTable
            // 
            this.sourceTable.AllowUserToResizeColumns = false;
            this.sourceTable.AllowUserToResizeRows = false;
            this.sourceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sourceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceTable.Location = new System.Drawing.Point(10, 121);
            this.sourceTable.Name = "sourceTable";
            this.sourceTable.RowHeadersWidth = 51;
            this.sourceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sourceTable.Size = new System.Drawing.Size(600, 406);
            this.sourceTable.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Source file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(648, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Comparable file:";
            // 
            // comparableTable
            // 
            this.comparableTable.AllowUserToResizeColumns = false;
            this.comparableTable.AllowUserToResizeRows = false;
            this.comparableTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.comparableTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comparableTable.Location = new System.Drawing.Point(652, 123);
            this.comparableTable.Name = "comparableTable";
            this.comparableTable.RowHeadersWidth = 51;
            this.comparableTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comparableTable.Size = new System.Drawing.Size(600, 406);
            this.comparableTable.TabIndex = 17;
            // 
            // notFindData
            // 
            this.notFindData.AllowUserToResizeColumns = false;
            this.notFindData.AllowUserToResizeRows = false;
            this.notFindData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.notFindData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notFindData.Location = new System.Drawing.Point(10, 557);
            this.notFindData.Name = "notFindData";
            this.notFindData.RowHeadersWidth = 51;
            this.notFindData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notFindData.Size = new System.Drawing.Size(1242, 112);
            this.notFindData.TabIndex = 18;
            this.notFindData.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.notFindData1_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Not find in comparable file:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notFindData);
            this.Controls.Add(this.comparableTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceTable);
            this.Controls.Add(this.ComparableFile2);
            this.Controls.Add(this.ComparableOpen2);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.ComparableFile1);
            this.Controls.Add(this.ComparableOpen1);
            this.Name = "MainView";
            this.Text = "FileCompareMaster";
            ((System.ComponentModel.ISupportInitialize)(this.sourceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparableTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFindData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComparableOpen1;
        private System.Windows.Forms.TextBox ComparableFile1;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.TextBox ComparableFile2;
        private System.Windows.Forms.Button ComparableOpen2;
        private System.Windows.Forms.DataGridView sourceTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView comparableTable;
        private System.Windows.Forms.DataGridView notFindData;
        private System.Windows.Forms.Label label1;
    }
}

