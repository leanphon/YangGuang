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
    public partial class PostForm : BaseForm
    {
        private DataTable tablePost;
        private string name;
        private string level;
        private int salary;
        private int id =  -1;
        public PostForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {
            LoadData();
        }

        private void LoadData()
        {
            PostDAO d = new PostDAO();
            DataSet set = d.GetAllPost();
            tablePost = set.Tables[0];
            gridCtrl.DataSource = tablePost;
        }
        private bool CheckData()
        {
            name = textEditName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("岗位名称为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            level = textEditLevel.Text.Trim();
            if (string.IsNullOrEmpty(level))
            {
                MessageBox.Show("岗位层级为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(textEditSalary.Text.Trim()))
            {
                MessageBox.Show("岗位工资为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                salary = Convert.ToInt32(textEditSalary.Text.Trim());
            }
            catch
            {
                MessageBox.Show("岗位工资输入有误", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void gridViewPost_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataRow r = (DataRow)gridView.GetFocusedDataRow();
                if (r == null)
                {
                    return;
                }
                id = Convert.ToInt32(r["Id"].ToString());
                textEditName.Text = r["Name"].ToString();
                textEditLevel.Text = r["Level"].ToString();
                textEditSalary.Text = r["BaseSalary"].ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DataRow[] matches = tablePost.Select("Name='"+name +"'");
            if (matches.Length > 0) // 岗位名称已经存在
            {
                MessageBox.Show("岗位名称已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }
            string stat = "Level='" + level + "'";
            matches = tablePost.Select(stat);
            if (matches.Length > 0) // 岗位层级编码已经存在
            {
                MessageBox.Show("岗位层级已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }

            PostBean b = new PostBean();
            b.Level = level;
            b.Name = name;
            b.BaseSalary = salary;

            PostDAO dao = new PostDAO();
            dao.AddPost(b);
            
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
                MessageBox.Show("请选择", "信息提示", MessageBoxButtons.OK);
                return;
            }
                
            string stat = "Name='" + name + "'" + " and Level='" + level + "' and " + "BaseSalary=" + salary;
            DataRow[] matches = tablePost.Select(stat);
            if (matches.Length == 1) // 未发生变化不修改
            {
                //MessageBox.Show("未修改", "信息提示", MessageBoxButtons.OK);
                return;
            }

            stat = "Id<>" + id + " AND Name='" + name + "'";
            matches = tablePost.Select(stat);
            if (matches.Length > 0) // 岗位名称已经存在
            {
                MessageBox.Show("岗位名称已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }

            stat = "Id<>" + id + " AND Level='" + level + "'";
            matches = tablePost.Select(stat);
            if (matches.Length > 0) // 岗位层级编码已经存在
            {
                MessageBox.Show("岗位层级已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }

            PostBean b = new PostBean();
            b.Id = id;
            b.Level = level;
            b.Name = name;
            b.BaseSalary = salary;
            
            PostDAO dao = new PostDAO();
            dao.UpdatePost(b);

            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("请选择", "信息提示", MessageBoxButtons.OK);
                return;
            }

            PostBean b = new PostBean();
            b.Id = id;

            PostDAO dao = new PostDAO();
            dao.DeletePost(b);

            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEditName.Text = "";
            textEditLevel.Text = "";
            textEditSalary.Text = "";
        }
    }
}
