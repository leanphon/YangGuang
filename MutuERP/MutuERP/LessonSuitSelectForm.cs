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
    public partial class LessonSuitSelectForm : BaseForm
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

        public LessonSuitSelectForm()
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

        }

        private void LoadData()
        {
            LoadStaff();
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
    }
}
