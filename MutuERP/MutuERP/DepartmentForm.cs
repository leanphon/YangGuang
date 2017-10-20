using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;
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
    public partial class DepartmentForm : BaseForm
    {
        private DataTable tabData;
        private string name;
        private string code;
        private int id = -1;

        public DepartmentForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {
            tabData = new DataTable();
        }

        public override void RefreshForm()
        {
            base.RefreshForm();

            LoadData();
        }

        private void LoadData()
        {
            treeList.Nodes.Clear();
            comboBoxEditParent.Properties.Items.Clear();
            DepartmentDAO d = new DepartmentDAO();
            DataSet set = d.GetAllDepartment();
            tabData = set.Tables[0];
            treeList.DataSource = tabData;
            foreach (DataRow r in tabData.Rows)
            {
                comboBoxEditParent.Properties.Items.Add(r["Name"]);
            }
            treeList.ExpandAll();
        }

        private bool CheckData()
        {
            name = textEditName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("部门名称为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (name.Length > 30)
            {
                MessageBox.Show("部门名称超出30个字符", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            code = textEditCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("部门代码为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (name.Length > 30)
            {
                MessageBox.Show("部门代码超出30个字符", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void treeList_NodeClick(object sender, EventArgs e)
        {
            TreeListNode n = treeList.FocusedNode;
            if (n == null)
            {
                return;
            }
            try
            {
                id = Convert.ToInt32(n["Id"].ToString());
            }
            catch
            {
                return;
            }

            textEditName.Text = n["Name"].ToString();
            textEditCode.Text = n["Code"].ToString();

            int parentId = (int)n["ParentID"];
            DataRow[] matchs = tabData.Select("Id<>0 and Id=" + parentId);
            if (matchs.Length == 0)
            {
                comboBoxEditParent.SelectedItem = null;
                comboBoxEditParent.Text = "";
                return;
            }
            comboBoxEditParent.SelectedItem = matchs[0]["Name"];
            comboBoxEditParent.Text = matchs[0]["Name"].ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DataRow[] matches = tabData.Select("Name='" + name +"'");
            if (matches.Length > 0)
            {
                MessageBox.Show("该部门已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }
            int parentId = 0;
            if (comboBoxEditParent.SelectedItem != null)
            {
                matches = tabData.Select("Name='" + comboBoxEditParent.Text + "'");
                if (matches.Length == 0)
                {
                    return;
                }

                parentId = (int)matches[0]["Id"];
            }

            DepartmentBean b = new DepartmentBean();
            b.Name = name;
            b.ParentId = parentId;
            b.Code = code;

            DepartmentDAO dao = new DepartmentDAO();
            dao.AddDepartment(b);

            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            if (id == -1)
            {
                MessageBox.Show("请选择", "信息提示", MessageBoxButtons.OK);
                return;
            }

            DataRow[] matches = tabData.Select("Name='" + name + "' and Id<>" + id);
            if (matches.Length > 0)
            {
                MessageBox.Show("该部门已经存在", "信息提示", MessageBoxButtons.OK);
                return;
            }
            
            int parentId = 0;
            if (comboBoxEditParent.SelectedItem != null)
            {
                matches = tabData.Select("Name='" + comboBoxEditParent.Text + "'");
                if (matches.Length == 0)
                {
                    return;
                }

                parentId = (int)matches[0]["Id"];
            }

            DepartmentBean b = new DepartmentBean();
            b.Id = id;
            b.Name = name;
            b.ParentId = parentId;
            b.Code = code;
            
            DepartmentDAO dao = new DepartmentDAO();
            dao.UpdateDepartment(b);

            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DepartmentBean b = new DepartmentBean();
            b.Id = (int)treeList.FocusedNode["Id"];

            DepartmentDAO dao = new DepartmentDAO();
            dao.DeleteDepartment(b);

            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEditName.Text = "";
            textEditCode.Text = "";
        }


    }
}
