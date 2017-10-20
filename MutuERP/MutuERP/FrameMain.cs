using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using System.Reflection;

namespace MutuERP
{
    public partial class FrameMain : BaseForm
    {
        private List<Form> forms = new List<Form>();

        public FrameMain()
        {
            InitializeComponent();
            LoadFrame_MainPage();
        }

        
        private void menu_Click(object sender, EventArgs e)
        {
            MenuElement menu = sender as MenuElement;
            if (menu == null)
                return;

            CreatePage(menu);
        }

        private void CreatePage(MenuElement menu)
        {
            panelContent.Controls.Clear();

            foreach (Form varFrom in forms)
            {
                if (varFrom.Name == menu.FormName)
                {
                    panelContent.Controls.Add(varFrom);
                    linkLabelMid.Text = menu.Name;
                    varFrom.Show();
                    return;
                }
                    
            }

            Form f = CreateForm(menu);
            if (f == null)
                return;
            linkLabelMid.Text = menu.Name;

            f.TopLevel = false;
            panelContent.Controls.Add(f);
            forms.Add(f);
            f.Show();
        }
        private Form CreateForm(MenuElement menu)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            dynamic obj = assembly.CreateInstance("MutuERP." + menu.FormName);
            Form f = obj as Form;
            if (f == null)
            {
                if (menu.Elements.Count > 0)
                {
                    MenuElement sub = (MenuElement)menu.Elements[0];
                    CreateForm(sub);
                }
            }
            return f;
        }

        public void LoadFrame_MainPage()
        {
            LoadMenu_MainPage();
            MenuElement e = new MenuElement("菜单", "MainMenuForm");
            CreatePage(e);
            linkLabelMid.Text = "";
        }
        private void LoadMenu_MainPage()
        {
            ctrlMenu.Elements.Clear();

            AccordionControlElement rootMenu = new AccordionControlElement();
            rootMenu.Expanded = true;
            rootMenu.Text = "主界面";
            ctrlMenu.Elements.Add(rootMenu);
        }

        #region 报名界面加载
        public void LoadFrame_Enroll()
        {
            LoadMenu_Enroll();
            CreatePage((MenuElement)ctrlMenu.Elements[0]);
        }

        private void LoadMenu_Enroll()
        {
            ctrlMenu.Elements.Clear();

            int i = 0;
            // 
            // rootMenu
            // 
            MenuElement rootMenu = new MenuElement("");
            rootMenu.Expanded = true;
            rootMenu.Text = "功能菜单";
            ctrlMenu.Elements.Add(rootMenu);

            MenuElement group;
            MenuElement menu;

            // 
            // 课程管理
            // 
            //group = new MenuElement("课程管理");
            //group.Expanded = true;
            //rootMenu.Elements.Add(group);
            menu = new MenuElement("新客户报名", "CustomerForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            rootMenu.Elements.Add(menu);
            menu = new MenuElement("老客户报名", "EnrollForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            rootMenu.Elements.Add(menu);
        }

        #endregion

        #region 课程管理
        public void LoadFrame_Lesson()
        {
            LoadMenu_Lesson();
            CreatePage((MenuElement)ctrlMenu.Elements[0]);
        }
        private void LoadMenu_Lesson()
        {
            ctrlMenu.Elements.Clear();

            int i = 0;
            // 
            // rootMenu
            // 
            MenuElement rootMenu = new MenuElement("");
            rootMenu.Expanded = true;
            rootMenu.Text = "授课管理";
            ctrlMenu.Elements.Add(rootMenu);

            MenuElement group;
            MenuElement menu;

            // 
            // 课程管理
            // 
            //group = new MenuElement("课程管理");
            //group.Expanded = true;
            //rootMenu.Elements.Add(group);
            menu = new MenuElement("上课消费", "EnrollListForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            rootMenu.Elements.Add(menu);
        }

        #endregion

        #region 数据管理及分析

        public void LoadFrame_Policy()
        {
            LoadMenu_Policy();
            CreatePage((MenuElement)ctrlMenu.Elements[0]);
        }
        private void LoadMenu_Policy()
        {
            ctrlMenu.Elements.Clear();

            int i = 0;
            // 
            // rootMenu
            // 
            MenuElement rootMenu = new MenuElement("");
            rootMenu.Expanded = true;
            rootMenu.Text = "菜单";
            ctrlMenu.Elements.Add(rootMenu);

            MenuElement group;
            MenuElement menu;

            // 
            // 课程管理
            // 
            //group = new MenuElement("课程管理");
            //group.Expanded = true;
            //rootMenu.Elements.Add(group);
            menu = new MenuElement("客户管理", "EnrollListForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            rootMenu.Elements.Add(menu);

            menu = new MenuElement("数据分析", "EnrollListForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            rootMenu.Elements.Add(menu);
        }

        #endregion

        #region 设置界面加载
        public void LoadFrame_Setup()
        {
            LoadMenu_Setup();
            CreatePage((MenuElement)ctrlMenu.Elements[0]);
        }
        
        private void LoadMenu_Setup()
        {
            ctrlMenu.Elements.Clear();

            int i = 0;
            // 
            // rootMenu
            // 
            MenuElement rootMenu = new MenuElement("");
            rootMenu.Expanded = true;
            rootMenu.Text = "设置";
            ctrlMenu.Elements.Add(rootMenu);

            MenuElement group;
            MenuElement node;
            MenuElement menu;

            // 
            // 课程管理
            // 
            group = new MenuElement("课程管理");
            group.Expanded = true;
            rootMenu.Elements.Add(group);
            menu = new MenuElement("课程录入", "LessonInputForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);
            menu = new MenuElement("套餐设定", "LessonInputForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);


            // 
            // 会员
            // 
            group = new MenuElement("会员管理");
            group.Expanded = true;
            rootMenu.Elements.Add(group);


            // 
            // 人事管理
            // 
            group = new MenuElement("人事管理");
            group.Expanded = true;
            rootMenu.Elements.Add(group);

            menu = new MenuElement("工资录入", "SalaryInputForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);

            menu = new MenuElement("工资表", "SalaryHistoryForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);

            menu = new MenuElement("工资设定", "SalaryStructureForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);


            // 
            // 基础维护
            // 
            group = new MenuElement("基础信息");
            //group.Expanded = true;
            rootMenu.Elements.Add(group);

            node = new MenuElement("层级设定");
            group.Elements.Add(node);

            menu = new MenuElement("岗位层级", "PostForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            node.Elements.Add(menu);
            menu = new MenuElement("绩效层级", "PerformanceForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            node.Elements.Add(menu);
            menu = new MenuElement("效益层级", "BenefitForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            node.Elements.Add(menu);

            //
            menu = new MenuElement("员工信息", "StaffForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);

            menu = new MenuElement("部门信息", "DepartmentForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);

            /*
            menu = new MenuElement("分类", "CategoryManageForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);

            menu = new MenuElement("新增分类");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);
            group.Elements.Add(menu);
            */
            menu = new MenuElement("关于", "AboutForm");
            menu.Style = ElementStyle.Item;
            menu.Id = i++;
            menu.Click += new System.EventHandler(this.menu_Click);

            rootMenu.Elements.Add(menu);
        }

        #endregion

        private void linkLabelTop_Click(object sender, EventArgs e)
        {
            LoadFrame_MainPage();
        }

        private void linkLabelMid_Click(object sender, EventArgs e)
        {

        }
    }
}