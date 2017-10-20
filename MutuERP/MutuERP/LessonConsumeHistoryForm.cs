using DevExpress.XtraGrid.Columns;
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
    public partial class LessonConsumeHistoryForm : BaseForm
    {
        enum OperType
        {
            ModifyStatus = 1,
            ModifyPassword,
            ModifyCustomer,
            ReturnMoney,
            SwitchAddress,
            ShowLog,
        };

        public LessonConsumeHistoryForm()
        {
            InitializeComponent();


            LoadData();
        }
        

        

        private void LoadData()
        {
            QueryConditionComsume c = new QueryConditionComsume();
            string customer = textEditCustomer.Text.Trim();
            if (!string.IsNullOrEmpty(customer))
            {
                c.CustomerName = customer;
            }
            string lesson = textEditLesson.Text.Trim();
            if (!string.IsNullOrEmpty(lesson))
            {
                c.LessonName = lesson;
            }
            string teacher = textEditTeacher.Text.Trim();
            if (!string.IsNullOrEmpty(teacher))
            {
                c.TeacherName = teacher;
            }
            string begin = dateEditBegin.Text.Trim();
            if (!string.IsNullOrEmpty(begin))
            {
                c.DateBegin = begin;
            }
            string end = dateEditEnd.Text.Trim();
            if (!string.IsNullOrEmpty(end))
            {
                c.DateEnd = end;
            }

            ItemConsumeDAO d = new ItemConsumeDAO();
            DataSet set = d.GetAllItemConsume(c);
            gridCtrl.DataSource = set.Tables[0];

        }



        private void simpleButtonQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanelQuery.Controls)
            {
                if (c.GetType() == typeof(Button)
                    || c.GetType() == typeof(Label)
                    || c.GetType().IsSubclassOf(typeof(Button))
                    || c.GetType().IsSubclassOf(typeof(Label))
                    )
                {
                    continue;
                }
                c.Text = "";
            }
        }
    }
}
