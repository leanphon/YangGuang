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
    public partial class StaffForm : BaseForm
    {
        private DataTable tablePost;
        private DataTable tabDepartment;

        private string name;
        private string staffNumber;
        private string sex;
        private string phone;
        private string idCard;
        private string bankCard;
        private string birthday;
        private string status;
        private string dateStatus;
        private int departmentId;

        public StaffForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {
            //tablePost = new DataTable();
            //tablePost.Columns.Add("Name");
            //tablePost.Columns.Add("StaffNumber");
            //tablePost.Columns.Add("Sex");
            //tablePost.Columns.Add("Birthday");
            //tablePost.Columns.Add("Phone");
            //tablePost.Columns.Add("IdCard");
            //tablePost.Columns.Add("BankCard");

            comboBoxSex.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
        }

        private void LoadData()
        {
            LoadDepartment();
            LoadStaff();
        }

        private void LoadDepartment()
        {
            DepartmentDAO d = new DepartmentDAO();
            DataSet s = d.GetAllDepartment();
            tabDepartment = s.Tables[0];

            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.ValueMember = "Id";
            if (comboBoxDep.Items.Count > 0)
            {
                comboBoxDep.SelectedIndex = 0;
            }
            comboBoxDep.DataSource = tabDepartment;
        }
        private void LoadStaff()
        {
            StaffDAO d = new StaffDAO();
            DataSet set = d.GetAllStaff();
            tablePost = set.Tables[0];
            gridCtrlPost.DataSource = tablePost;
            //DataRow newRow;
            //foreach (DataRow r in set.Tables[0].Rows)
            //{
            //    newRow = tablePost.NewRow();
            //    newRow["Name"] = r["Name"];
            //    newRow["StaffNumber"] = r["StaffNumber"];
            //    newRow["Sex"] = r["Sex"];
            //    newRow["Birthday"] = r["Birthday"];
            //    newRow["Phone"] = r["Phone"];
            //    newRow["IdCard"] = r["IdCard"];
            //    newRow["BankCard"] = r["BankCard"];
            //    tablePost.Rows.Add(newRow);
            //}

            //gridCtrlPost.DataSource = tablePost;
        }
        private bool CheckData()
        {
            name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名字为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (name.Length > 30)
            {
                MessageBox.Show("名字过长，不得大于30个字符", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            staffNumber = textBoxStaffNumber.Text.Trim();
            if (string.IsNullOrEmpty(staffNumber))
                return false;
            sex = comboBoxSex.SelectedText;
            phone = textBoxPhone.Text.Trim();
            idCard = textBoxIdCard.Text.Trim();
            bankCard = textBoxBankCard.Text.Trim();
            birthday = dateEditBirthday.Text;
            status = comboBoxStatus.Text.Trim() ;
            if (status != "试用" && status != "转正" && status != "离职")
            {
                return false;
            }
            dateStatus = dateEditStatus.Text;
            if (string.IsNullOrEmpty(dateStatus ))
            {
                return false;
            }
            if (comboBoxDep.SelectedItem == null)
            {
                return false;
            }
            departmentId = (int)comboBoxDep.SelectedValue;

            return true;
        }

        private void AssignData(StaffBean b)
        {
            b.StaffNumber = staffNumber;
            b.Name = name;
            b.Sex = sex;
            b.Phone = phone;
            b.Birthday = birthday;
            b.IdCard = idCard;
            b.BankCard = bankCard;
            b.Status = status;
            if (status == "试用")
            {
                b.DateEntry = dateStatus;
            }
            else if (status == "转正")
            {
                b.DateFormal = dateStatus;
            }
            else if (status == "离职")
            {
                b.DateLeave = dateStatus;
            }
            b.Department.Id = departmentId;
        }
        private void gridViewPost_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataRowView r = (DataRowView)gridViewPost.GetRow(gridViewPost.FocusedRowHandle);
                textBoxName.Text = r["Name"].ToString();
                textBoxStaffNumber.Text = r["StaffNumber"].ToString();
                comboBoxSex.SelectedItem = r["Sex"].ToString();
                textBoxPhone.Text = r["Phone"].ToString();
                textBoxIdCard.Text = r["IdCard"].ToString();
                textBoxBankCard.Text = r["BankCard"].ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DataRow[] matches = tablePost.Select("Name='" + name +"'");
            if (matches.Length > 0)
                return;

            StaffBean b = new StaffBean();
            AssignData(b);
            b.Status = status;
            if (status != "试用")
            {
                b.DateEntry = dateStatus;
            }

            StaffDAO dao = new StaffDAO();
            dao.AddStaff(b);

            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DataRow[] matches = tablePost.Select("PostName='" + name + "'");
            if (matches.Length != 1)
                return;
            matches[0]["PostCode"] = staffNumber;

            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            DataRow[] matches = tablePost.Select("PostName='" + name + "' and PostCode='" + staffNumber + "'");
            if (matches.Length != 1)
                return;
            tablePost.Rows.Remove(matches[0]);

            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearEdit(panelInput);
        }

        private void comboBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxStatus.Text)
            {
                case "试用":
                    labelDateStatus.Text = "入职时间";
                    break;
                case "转正":
                    labelDateStatus.Text = "转正时间";
                    break;
                case "离职":
                    labelDateStatus.Text = "离职时间";
                    break;
            }
        }
    }
}
