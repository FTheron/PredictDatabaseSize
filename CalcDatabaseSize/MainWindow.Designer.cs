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
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndexRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(284, 12);
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
            this.cbDatabases.Location = new System.Drawing.Point(88, 40);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(190, 24);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(284, 155);
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
            this.lblRows.Location = new System.Drawing.Point(9, 105);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(42, 17);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Location = new System.Drawing.Point(9, 131);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(106, 17);
            this.lblCompression.TabIndex = 7;
            this.lblCompression.Text = "Compression %";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(9, 159);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(78, 17);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "Index Ratio";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(9, 43);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 17);
            this.lblDatabase.TabIndex = 11;
            this.lblDatabase.Text = "Database";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(9, 73);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 17);
            this.lblTable.TabIndex = 12;
            this.lblTable.Text = "Table";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(88, 70);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(190, 24);
            this.cbTables.TabIndex = 3;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(100, 194);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(0, 17);
            this.lblTotalSize.TabIndex = 14;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(284, 186);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(86, 25);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(12, 13);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(266, 22);
            this.tbServerName.TabIndex = 1;
            this.tbServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbServerName_Event);
            // 
            // nudCompression
            // 
            this.nudCompression.Location = new System.Drawing.Point(226, 129);
            this.nudCompression.Name = "nudCompression";
            this.nudCompression.Size = new System.Drawing.Size(52, 22);
            this.nudCompression.TabIndex = 5;
            // 
            // nudIndexRatio
            // 
            this.nudIndexRatio.Location = new System.Drawing.Point(226, 157);
            this.nudIndexRatio.Name = "nudIndexRatio";
            this.nudIndexRatio.Size = new System.Drawing.Size(52, 22);
            this.nudIndexRatio.TabIndex = 6;
            // 
            // lblTSize
            // 
            this.lblTSize.AutoSize = true;
            this.lblTSize.Location = new System.Drawing.Point(9, 194);
            this.lblTSize.Name = "lblTSize";
            this.lblTSize.Size = new System.Drawing.Size(75, 17);
            this.lblTSize.TabIndex = 18;
            this.lblTSize.Text = "Total Size:";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(178, 102);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(100, 22);
            this.tbRows.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 218);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.lblTSize);
            this.Controls.Add(this.nudIndexRatio);
            this.Controls.Add(this.nudCompression);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblCompression);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "Calculate Database Size";
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndexRatio)).EndInit();
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
    }
}

