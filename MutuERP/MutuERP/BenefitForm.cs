using Communal;
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
    public partial class BenefitForm : BaseForm
    {
        private int id = -1;
        private string level;
        private int salary;
        private DataTable tabData;
        
        public BenefitForm()
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
            BenefitDAO d = new BenefitDAO();
            DataSet set = d.GetAllBenefit();
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
                if(r != null)
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

            BenefitBean b = new BenefitBean();
            b.Level = level;
            b.BaseSalary = salary;

            BenefitDAO d = new BenefitDAO();
            if (ReturnStatus.OK == d.AddBenefit(b))
            {
                MessageBox.Show("添加成功", "信息提示", MessageBoxButtons.OK);
            }

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

            BenefitBean b = new BenefitBean();
            b.Id = id;
            b.Level = level;
            b.BaseSalary = salary;

            BenefitDAO d = new BenefitDAO();
            d.UpdateBenefit(b);

            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                return;
            }
            BenefitBean b = new BenefitBean();
            b.Id = id;

            BenefitDAO d = new BenefitDAO();
            d.DeleteBenefit(b);

            LoadData();

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEditLevel.Text = "";
            textEditSalary.Text = "";
        }
    }
}
