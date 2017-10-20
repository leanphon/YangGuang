using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICustomer
{
    public partial class ColumnSelecetor : UserControl
    {
        private DataTable tabColumn = new DataTable();
        private DataTable tabColumnSelected = new DataTable();

        public delegate void DelegateUpdateColumnDisplay(object sender, EventArgs e);
        public DelegateUpdateColumnDisplay UpdateColumnDisplay;

        public ColumnSelecetor()
        {
            InitializeComponent();

            tabColumn.Columns.Add("Caption");
            //tabColumn.Columns.Add("Check", typeof(int));

            tabColumnSelected.Columns.Add("Caption");
            //tabColumnSelected.Columns.Add("Check", Type.GetType("int"));

        }

        public void AddColumn(string caption, bool check)
        {
            DataRow r = tabColumn.NewRow();
            r["Caption"] = caption;
            //r["Check"] = check;
            tabColumn.Rows.Add(r);

            comboxColumn.Properties.Items.Add(caption, check);
        }

        public bool IsCheck(string caption)
        {
            DataRow[] matchs = tabColumnSelected.Select("Caption='" + caption + "'");

            return matchs.Length == 1;
        }

        private void comboxColumn_Properties_EditValueChanged(object sender, EventArgs e)
        {
            tabColumnSelected.Rows.Clear();
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem i in comboxColumn.Properties.Items)
            {
                if (i.CheckState == CheckState.Checked)
                {
                    DataRow r = tabColumnSelected.NewRow();
                    r["Caption"] = i.Value.ToString();
                    //r["Check"] = 1;
                    tabColumnSelected.Rows.Add(r);

                }
            }
            if (UpdateColumnDisplay != null)
            {
                UpdateColumnDisplay(sender, e);
            }
        }
    }
}
