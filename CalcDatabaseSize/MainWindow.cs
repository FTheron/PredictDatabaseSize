using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CalcDatabaseSize
{
    public partial class MainForm : Form
    {
        public SqlConnection SqlConn;
        public String File;

        public MainForm()
        {
            InitializeComponent();

            tbServerName.Text = Properties.Settings.Default.ServerName;
        }

        private void tbServerName_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnect_Click(sender, e);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["ServerName"] = tbServerName.Text;
            Properties.Settings.Default.Save();
            try
            {
                // Connect to the Database
                using (SqlConn = new SqlConnection("Data Source=" + tbServerName.Text + ";Integrated Security=SSPI;"))
                {
                    SqlConn.Open();
                    DataTable tblDatabases = SqlConn.GetSchema("Databases");
                    SqlConn.Close();

                    List<String> databases = new List<String>();
                    foreach (DataRow row in tblDatabases.Rows)
                    {
                        String strDatabaseName = row["database_name"].ToString();

                        databases.Add(strDatabaseName);
                    }
                    cbDatabases.DataSource = databases;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Connect to the database and get all the tables
                using (SqlConn = new SqlConnection("Data Source=" + tbServerName.Text + ";Initial Catalog=" + cbDatabases.Text + ";Integrated Security=SSPI;"))
                {
                    SqlConn.Open();

                    List<String> tables = new List<String>();
                    DataTable schema = SqlConn.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        tables.Add(row[2].ToString());
                    }
                    cbTables.DataSource = tables;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection("Data Source=" + tbServerName.Text + ";Initial Catalog=" + cbDatabases.Text + ";Integrated Security=SSPI;");

                using (SqlCommand command = SqlConn.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM " + cbTables.Text;
                    SqlConn.Open();

                    StringBuilder sb = new StringBuilder();
                    Int64 totalBytes = 0;

                    using (var reader = command.ExecuteReader(CommandBehavior.SchemaOnly))
                    {
                        reader.Read();
                        DataTable schema = reader.GetSchemaTable();

                        List<TableRow> tableRows = new List<TableRow>();
                        int nameMaxLength = 0;
                        int sizeLength = 0;
                        if (schema != null)
                            foreach (DataRow row in schema.Rows)
                            {
                                Int64 size = Int64.Parse(row["ColumnSize"].ToString());
                                string type = row["DataTypeName"].ToString();
                                Int64 bytes;

                                switch (type)
                                {
                                    case "char":
                                        bytes = 2 * size;
                                        break;
                                    case "varchar":
                                        bytes = 2 * size;
                                        break;
                                    default:
                                        bytes = size;
                                        break;
                                }
                                TableRow tableRow = new TableRow
                                {
                                    Name = row["ColumnName"].ToString(),
                                    Size = bytes,
                                    DataType = type
                                };

                                if (nameMaxLength < tableRow.Name.Length)
                                {
                                    nameMaxLength = tableRow.Name.Length;
                                }
                                if (sizeLength < tableRow.Size.ToString().Length)
                                {
                                    sizeLength = tableRow.Size.ToString().Length;
                                }
                                tableRows.Add(tableRow);
                            }

                        // Add one to the max length, for the correct format.
                        nameMaxLength++;
                        sizeLength++;
                        string format = "{0,-" + nameMaxLength + "}{1,-" + sizeLength + "}{2,-10}";
                        sb.AppendFormat(format, "Name", "Bytes", "Type").AppendLine().AppendLine();

                        foreach (TableRow row in tableRows)
                        {
                            sb.AppendFormat(format, row.Name, row.Size, row.DataType).AppendLine();
                            totalBytes += row.Size;
                        }
                    }

                    int rows;
                    Int32.TryParse(tbRows.Text, out rows);

                    sb.AppendLine();
                    sb.AppendFormat("{0,-25}{1,-5}", "Bytes per Row", totalBytes).AppendLine();
                    sb.AppendFormat("{0,-25}{1,-5}", "Rows", rows).AppendLine();
                    sb.AppendFormat("{0,-25}{1,-5}", "Compression", nudCompression.Value + "%").AppendLine();
                    sb.AppendFormat("{0,-25}{1,-5}", "Index Ratio", nudIndexRatio.Value + "%").AppendLine();
                    sb.AppendLine();

                    decimal totalSize = totalBytes * rows;
                    totalSize *= (100 + nudIndexRatio.Value) / 100;
                    totalSize *= (100 - nudCompression.Value) / 100;

                    sb.AppendLine(cbDatabases.Text + "-" + cbTables.Text + " Total Size:  ");
                    decimal totalMb = totalSize / 1048576;
                    decimal totalGb = totalSize / 1073741824;
                    sb.AppendLine(totalSize + " bytes");

                    lblTotalSize.Text = totalMb.ToString("0.##") + " MB";
                    sb.AppendLine(lblTotalSize.Text);
                    sb.AppendLine(totalGb.ToString("0.##") + " GB");

                    File = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveReport = new SaveFileDialog
                {
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    DefaultExt = "txt",
                    FileName = cbDatabases.Text + "_" + cbTables.Text
                };

                if (saveReport.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveReport.FileName, File);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
