using DevExpress.XtraGrid.Columns;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public partial class TeacherListForm : BaseForm
    {
        private DataTable tabStaff;
        private DataTable tabTeacher;

        public TeacherListForm()
        {
            InitializeComponent();

            Init();

            LoadStaff();
            LoadTeacher();
        }

        private void Init()
        {
            tabTeacher = new DataTable();
            tabTeacher.Columns.Add("Id");
            tabTeacher.Columns.Add("StaffNumber");
            tabTeacher.Columns.Add("Name");
            tabTeacher.Columns.Add("Status");


            gridViewTeacher.ActiveFilterString = "Status <> 'Deleting'";
        }
        private void LoadStaff()
        {
            StaffDAO cd = new StaffDAO();
            DataSet set = cd.GetAllStaffGroupByDepartment();
            tabStaff = set.Tables[0];
            gridCtrlStaff.DataSource = tabStaff;
        }

        private void LoadTeacher()
        {
            TeacherDAO cd = new TeacherDAO();
            DataSet set = cd.GetAllTeacher();
            foreach (DataRow r in set.Tables[0].Rows)
            {
                DataRow newRow = tabTeacher.NewRow();
                newRow["Id"] = r["Id"];
                newRow["StaffNumber"] = r["StaffNumber"];
                newRow["Name"] = r["Name"];
                newRow["Status"] = "Added";
                tabTeacher.Rows.Add(newRow);
            }

            gridCtrlTeacher.DataSource = tabTeacher;
        }
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            DataRow r = gridViewStaff.GetFocusedDataRow();
            DataRow[] matchs = tabTeacher.Select("StaffNumber='" + r["StaffNumber"].ToString() + "'");
            if (matchs.Length > 0)
            {
                string status = matchs[0]["Status"].ToString();
                if(status == "Deleting")
                {
                    matchs[0]["Status"] = "Added";
                }
                return;
            }

            DataRow newRow = tabTeacher.NewRow();
            newRow["Id"] = r["StaffId"];
            newRow["StaffNumber"] = r["StaffNumber"];
            newRow["Name"] = r["StaffName"];
            newRow["Status"] = "Adding";
            tabTeacher.Rows.Add(newRow);

        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            
            DataRow r = gridViewTeacher.GetFocusedDataRow();
            if (r == null)
            {
                return;
            }

            string status = r["Status"].ToString();
            if (status == "Adding")
            {
                tabTeacher.Rows.Remove(r);
            }
            else if (status == "Added")
            {
                r["Status"] = "Deleting";
            }
        }

        private void simpleButtonAddAll_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in tabStaff.Rows)
            {
                DataRow[] matchs = tabTeacher.Select("StaffNumber='" + r["StaffNumber"].ToString() + "'");
                if (matchs.Length > 0)
                {
                    string status = matchs[0]["Status"].ToString();
                    if (status == "Deleting")
                    {
                        matchs[0]["Status"] = "Added";
                    }
                    continue;
                }

                DataRow rowNew = tabTeacher.NewRow();
                rowNew["Id"] = r["StaffId"];
                rowNew["StaffNumber"] = r["StaffNumber"];
                rowNew["Name"] = r["StaffName"];
                rowNew["Status"] = "Adding";
                tabTeacher.Rows.Add(rowNew);
            }
            
        }

        private void simpleButtonRemoveAll_Click(object sender, EventArgs e)
        {
            for (int i=tabTeacher.Rows.Count-1; i>=0; i--)
            {
                DataRow r = tabTeacher.Rows[i];
                string status = r["Status"].ToString();
                if (status == "Adding")
                {
                    tabTeacher.Rows.Remove(r);
                }
                else if (status == "Added")
                {
                    r["Status"] = "Deleting";
                }
            }
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            TeacherDAO d = new TeacherDAO();
            TeacherBean b = new TeacherBean();

            foreach (DataRow r in tabTeacher.Rows)
            {
                b.StaffNumber = r["StaffNumber"].ToString();
                b.Id = Convert.ToInt32(r["Id"].ToString());
                string status = r["Status"].ToString();
                if (status == "Adding")
                {
                    d.AddTeacher(b);
                }
                else if (status == "Deleting")
                {
                    d.DeleteTeacher(b);
                }
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            for (int i = tabTeacher.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = tabTeacher.Rows[i];
                string status = r["Status"].ToString();
                if (status == "Adding")
                {
                    tabTeacher.Rows.Remove(r);
                }
                else if (status == "Deleting")
                {
                    r["Status"] = "Added";
                }
            }
        }

        private void gridCtrlStaff_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonAdd_Click(sender, e);
        }

        private void gridCtrlTeacher_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonRemove_Click(sender, e);
        }
    }
}
