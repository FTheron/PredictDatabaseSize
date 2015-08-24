namespace CalcDatabaseSize
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCompression = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.nudCompression = new System.Windows.Forms.NumericUpDown();
            this.nudIndexRatio = new System.Windows.Forms.NumericUpDown();
            this.lblTSize = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.ckbAllTables = new System.Windows.Forms.CheckBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlSingleTable = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMultiTable = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndexRatio)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlSingleTable.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(275, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 25);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(76, 30);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(193, 24);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(275, 35);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 25);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(5, 45);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(42, 17);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Location = new System.Drawing.Point(5, 11);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(106, 17);
            this.lblCompression.TabIndex = 7;
            this.lblCompression.Text = "Compression %";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(5, 39);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(78, 17);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "Index Ratio";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(5, 33);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 17);
            this.lblDatabase.TabIndex = 11;
            this.lblDatabase.Text = "Database";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(5, 13);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 17);
            this.lblTable.TabIndex = 12;
            this.lblTable.Text = "Table";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(76, 10);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(193, 24);
            this.cbTables.TabIndex = 3;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(96, 65);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(0, 17);
            this.lblTotalSize.TabIndex = 14;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(275, 61);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(86, 25);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(5, 3);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(264, 22);
            this.tbServerName.TabIndex = 1;
            this.tbServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbServerName_Event);
            // 
            // nudCompression
            // 
            this.nudCompression.Location = new System.Drawing.Point(214, 9);
            this.nudCompression.Name = "nudCompression";
            this.nudCompression.Size = new System.Drawing.Size(55, 22);
            this.nudCompression.TabIndex = 5;
            // 
            // nudIndexRatio
            // 
            this.nudIndexRatio.Location = new System.Drawing.Point(214, 37);
            this.nudIndexRatio.Name = "nudIndexRatio";
            this.nudIndexRatio.Size = new System.Drawing.Size(55, 22);
            this.nudIndexRatio.TabIndex = 6;
            // 
            // lblTSize
            // 
            this.lblTSize.AutoSize = true;
            this.lblTSize.Location = new System.Drawing.Point(5, 65);
            this.lblTSize.Name = "lblTSize";
            this.lblTSize.Size = new System.Drawing.Size(75, 17);
            this.lblTSize.TabIndex = 18;
            this.lblTSize.Text = "Total Size:";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(169, 42);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(100, 22);
            this.tbRows.TabIndex = 4;
            // 
            // ckbAllTables
            // 
            this.ckbAllTables.AutoSize = true;
            this.ckbAllTables.Location = new System.Drawing.Point(275, 33);
            this.ckbAllTables.Name = "ckbAllTables";
            this.ckbAllTables.Size = new System.Drawing.Size(92, 21);
            this.ckbAllTables.TabIndex = 22;
            this.ckbAllTables.Text = "All Tables";
            this.ckbAllTables.UseVisualStyleBackColor = true;
            this.ckbAllTables.CheckedChanged += new System.EventHandler(this.ckbAllTables_CheckedChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnReport);
            this.pnlBottom.Controls.Add(this.btnCalculate);
            this.pnlBottom.Controls.Add(this.lblCompression);
            this.pnlBottom.Controls.Add(this.lblTSize);
            this.pnlBottom.Controls.Add(this.lblIndex);
            this.pnlBottom.Controls.Add(this.nudIndexRatio);
            this.pnlBottom.Controls.Add(this.lblTotalSize);
            this.pnlBottom.Controls.Add(this.nudCompression);
            this.pnlBottom.Location = new System.Drawing.Point(10, 150);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(400, 100);
            this.pnlBottom.TabIndex = 23;
            // 
            // pnlSingleTable
            // 
            this.pnlSingleTable.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSingleTable.Controls.Add(this.cbTables);
            this.pnlSingleTable.Controls.Add(this.lblRows);
            this.pnlSingleTable.Controls.Add(this.lblTable);
            this.pnlSingleTable.Controls.Add(this.tbRows);
            this.pnlSingleTable.Location = new System.Drawing.Point(10, 75);
            this.pnlSingleTable.Name = "pnlSingleTable";
            this.pnlSingleTable.Size = new System.Drawing.Size(400, 70);
            this.pnlSingleTable.TabIndex = 25;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tbServerName);
            this.pnlTop.Controls.Add(this.btnConnect);
            this.pnlTop.Controls.Add(this.cbDatabases);
            this.pnlTop.Controls.Add(this.ckbAllTables);
            this.pnlTop.Controls.Add(this.lblDatabase);
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(400, 60);
            this.pnlTop.TabIndex = 26;
            // 
            // pnlMultiTable
            // 
            this.pnlMultiTable.AutoScroll = true;
            this.pnlMultiTable.AutoSize = true;
            this.pnlMultiTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMultiTable.Location = new System.Drawing.Point(10, 75);
            this.pnlMultiTable.MaximumSize = new System.Drawing.Size(450, 600);
            this.pnlMultiTable.MinimumSize = new System.Drawing.Size(410, 0);
            this.pnlMultiTable.Name = "pnlMultiTable";
            this.pnlMultiTable.Size = new System.Drawing.Size(410, 0);
            this.pnlMultiTable.TabIndex = 27;
            this.pnlMultiTable.Visible = false;
            this.pnlMultiTable.MouseEnter += new System.EventHandler(this.pnlMultiTable_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 255);
            this.Controls.Add(this.pnlMultiTable);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSingleTable);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MainForm";
            this.Text = "Calculate Database Size";
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndexRatio)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlSingleTable.ResumeLayout(false);
            this.pnlSingleTable.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCompression;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.NumericUpDown nudCompression;
        private System.Windows.Forms.NumericUpDown nudIndexRatio;
        private System.Windows.Forms.Label lblTSize;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.CheckBox ckbAllTables;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSingleTable;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMultiTable;
    }
}

