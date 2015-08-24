using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDatabaseSize
{
    public partial class TableControle : UserControl
    {
        public TableControle()
        {
            InitializeComponent();
        }

        private void tbRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public string TableName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public int Rows
        {
            get
            {
                return int.Parse(tbRows.Text);
            }
        }
    }
}
