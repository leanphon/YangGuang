using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalyser
{
    public partial class CategoryManageForm : Form
    {
        private DataTable dtCategory;

        public CategoryManageForm()
        {
            dtCategory = new DataTable();

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string queryString = "select Id,Name,ParentId,Level from Category";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "server=localhost;database=MutuERP;uid=sa;pwd=123456";
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                adapter.Fill(dtCategory);

                treeListCategory.DataSource = dtCategory;

                comboBoxParent.DisplayMember = "Name";
                comboBoxParent.ValueMember = "Id";
                comboBoxParent.DataSource = dtCategory;

                treeListCategory.ExpandAll();

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void treeListCategory_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            DataRowView drv = (DataRowView)treeListCategory.GetDataRecordByNode(treeListCategory.FocusedNode);
            //comboBoxParent.SelectedText = drv.Row["Name"].ToString();
            //comboBoxParent.SelectedValue = drv.Row["Id"];

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = 1010;
            string name = textBoxCategoryName.Text;
            if (comboBoxParent.SelectedValue == null)
            {
                string sql = string.Format("insert into Category(Id,Name) valus({0},'{1})'",id, name);
            }
            else
            {
                int parentId = (int)comboBoxParent.SelectedValue;
                string sql = string.Format("insert into Category(Id,Name,ParentId) valus({0},'{1}',{2})",
                    id, name, parentId);
            }
        }
    }
}