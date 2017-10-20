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
    public partial class LessonInputForm : BaseForm
    {
        DataTable tabLesson;
        private int id = -1;
        private string name;
        private float price;
        private float timeLength;
        private string description;

        public LessonInputForm()
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
            LessonDAO d = new LessonDAO();
            DataSet set = d.GetAllLesson();
            tabLesson = set.Tables[0];
            gridCtrl.DataSource = tabLesson;
        }

        private bool CheckData()
        {
            name = textEditName.Text.Trim();
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
            if (string.IsNullOrEmpty(textEditPrice.Text.Trim()))
            {
                MessageBox.Show("名字为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                price = (float)Convert.ToDouble(textEditPrice.Text.Trim());
            }
            catch
            {
                MessageBox.Show("价格输入有误", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(textEditTimeLength.Text.Trim()))
            {
                MessageBox.Show("课程时长为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                timeLength = (float)Convert.ToDouble(textEditTimeLength.Text.Trim());
            }
            catch
            {
                MessageBox.Show("课程时长输入有误", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(textEditDescription.Text.Trim()))
            {
                description = textEditDescription.Text.Trim();
            }
            

            return true;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            if (tabLesson != null)
            {
                DataRow[] matchs = tabLesson.Select("Name='" + name + "'");
                if (matchs.Length > 0)
                {
                    MessageBox.Show("课程名称已经存在", "信息提示", MessageBoxButtons.OK);
                    return;
                }
            }
            LessonBean b = new LessonBean();
            b.Name = name;
            b.Price = price;
            b.TimeLength = timeLength;
            b.Description = description;


            LessonDAO d = new LessonDAO();
            d.AddLesson(b);
            
        }

        private void simpleButtonModify_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            if (id == -1)
            {
                MessageBox.Show("未选择课程", "信息提示", MessageBoxButtons.OK);
                return;
            }            

            if (tabLesson != null)
            {
                DataRow[] matchs = tabLesson.Select("Id!=" + id + " AND Name='" + name + "'");
                if (matchs.Length > 0)
                {
                    MessageBox.Show("课程名称已经存在", "信息提示", MessageBoxButtons.OK);
                    return;
                }
            }
            LessonBean b = new LessonBean();
            b.Name = name;
            b.Price = price;
            b.TimeLength = timeLength;
            b.Description = description;

            LessonDAO d = new LessonDAO();
            d.UpdateLesson(b);

            LoadData();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("未选择课程", "信息提示", MessageBoxButtons.OK);
                return;
            }

            LessonBean b = new LessonBean();
            b.Id = id;
            LessonDAO d = new LessonDAO();
            d.DeleteLesson(b);

            LoadData();
        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            ClearEdit(tableLayoutPanelLesson);
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            DataRow r = (DataRow)gridView.GetFocusedRow();
            if (r == null)
            {
                return;
            }

            id = Convert.ToInt32(r["Id"].ToString());
            textEditName.Text = r["Name"].ToString();
            textEditPrice.Text = r["Price"].ToString();
            textEditTimeLength.Text = r["TimeLength"].ToString();
            textEditDescription.Text = r["Description"].ToString();
        }
    }
}
