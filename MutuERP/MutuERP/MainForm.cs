using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.XtraTabbedMdi;
using System.Reflection;

namespace MutuERP
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();

            //UserLookAndFeel.Default.StyleChanged += new EventHandler(OnLookAndFeelStyleChanged);
            //UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            //Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", typeof(MainForm).Assembly);
        }
        void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItemSkin, true);
        }

        public void OpenLink(string formName, string formText)
        {
            foreach (XtraMdiTabPage p in tabMdiManager.Pages)
            {
                if (p.Text == formText)
                {
                    tabMdiManager.SelectedPage = p;
                    return;
                }
            }

            BaseForm f = CreateForm(formName);
            if (f == null)
            {
                return;
            }

            f.Text = formText;
            f.MdiParent = this;
            f.Show();
            tabMdiManager.SelectedPage = tabMdiManager.Pages[f];

        }

        private BaseForm CreateForm(string formName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            dynamic obj = assembly.CreateInstance("MutuERP." + formName);
            BaseForm f = obj as BaseForm;
            return f;
        }

        #region 客户管理
        private void barButtonRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("CustomerRegisterForm", e.Item.Caption);
        }

        private void barButtonEnroll_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonEnrollForm", "课程报名");
        }

        private void barButtonConsume_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonConsumeForm", "课程消费");
        }

        #endregion

        private void barButtonItemCustomerList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("CustomerListForm", "客户列表");
        }

        private void barButtonItemTeacherList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("TeacherListForm", "老师列表");
        }

        private void barButtonItemDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("DepartmentForm", "部门列表");
        }

        private void barButtonItemStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("StaffForm", "员工列表");
        }

        private void barButtonItemPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("PostForm", "岗位层级");
        }

        private void barButtonItemPerformance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("PerformanceForm", "绩效层级");
        }

        private void barButtonItemBenefit_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("BenefitForm", "效益层级");
        }

        private void barButtonItemSalaryInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("SalaryStructureForm", "薪资设定");
        }

        private void barButtonItemSalaryInput_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("SalaryInputForm", "工资录入");
        }

        private void barButtonItemSalaryQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("SalaryHistoryForm", "工资查询");
        }

        private void barButtonItemLessonInput_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonInputForm", "课程录入");
        }

        private void barButtonItemLessonSuit_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonSuitForm", "套餐设定");
        }

        private void barButtonItemLessonConsumeHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonConsumeHistoryForm", "授课查询");
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabMdiManager.SelectedPage != null)
            {
                BaseForm f = tabMdiManager.SelectedPage.MdiChild as BaseForm;
                if(f != null)
                {
                    f.RefreshForm();
                }
            }
        }

        private void barButtonItemEnrollSet_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenLink("LessonEnrollListForm", "报名维护");
        }
    }
}