using DevExpress.XtraGrid.Views.Grid;
using MutuDAL;
using MutuModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public partial class PerformanceForm : BaseForm
    {
        private DataTable tabData;
        private string level;
        private int salary;
        private int id = -1;
        
        public PerformanceForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {
        }

        private void LoadData()
        {
            PerformanceDAO d = new PerformanceDAO();
            DataSet set = d.GetAllPerformance();
            tabData = set.Tables[0];
            gridCtrl.DataSource = tabData;
        }

        private bool CheckData()
        {
            level = textEditLevel.Text.Trim();
            if (string.IsNullOrEmpty(level))
            {
                MessageBox.Show("效益层级为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(textEditSalary.Text.Trim()))
            {
                MessageBox.Show("效益工资为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                salary = Convert.ToInt32(textEditSalary.Text.Trim());
            }
            catch
            {
                MessageBox.Show("效益工资输入有误", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


        private void gridViewPost_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataRow r = (DataRow)gridView.GetFocusedDataRow();
                if (r != null)
                {
                    try
                    {
                        id = Convert.ToInt32(r["Id"].ToString());
                    }
                    catch
                    {
                        return;
                    }

                    textEditLevel.Text = r["Level"].ToString();
                    textEditSalary.Text = r["BaseSalary"].ToString();
                }

            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            if (tabData != null)
            {
                DataRow[] matchs = tabData.Select("Level='" + level + "'");
                if (matchs.Length > 0)
                {
                    MessageBox.Show("效益层级已经存在", "信息提示", MessageBoxButtons.OK);
                    return;
                }
            }

            PerformanceBean b = new PerformanceBean();
            b.Level = level;
            b.BaseSalary = salary;

            PerformanceDAO d = new PerformanceDAO();
            d.AddPerformance(b);

            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            if (id == -1)
            {
                MessageBox.Show("未选择", "信息提示", MessageBoxButtons.OK);
                return;
            }

            if (tabData != null)
            {
                DataRow[] matchs = tabData.Select("Id<>" + id + " AND Level='" + level + "'");
                if (matchs.Length > 0)
                {
                    MessageBox.Show("效益层级已经存在", "信息提示", MessageBoxButtons.OK);
                    return;
                }
            }

            PerformanceBean b = new PerformanceBean();
            b.Id = id;
            b.Level = level;
            b.BaseSalary = salary;

            PerformanceDAO d = new PerformanceDAO();
            d.UpdatePerformance(b);

            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                return;
            }
            PerformanceBean b = new PerformanceBean();
            b.Id = id;

            PerformanceDAO d = new PerformanceDAO();
            d.DeletePerformance(b);

            LoadData();

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEditLevel.Text = "";
            textEditSalary.Text = "";
        }
    }
}
