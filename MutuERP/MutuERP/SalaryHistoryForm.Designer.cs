namespace MutuERP
{
    partial class SalaryHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryHistoryForm));
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tableLayoutPanelQuery = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditStaffNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pageHeader = new UICustomer.PageHeader();
            this.columnSelecetor = new UICustomer.ColumnSelecetor();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            this.tableLayoutPanelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStaffNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDepartment.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateEdit
            // 
            this.dateEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateEdit.EditValue = new System.DateTime(2017, 8, 17, 16, 47, 7, 871);
            this.dateEdit.Location = new System.Drawing.Point(80, 45);
            this.dateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Mask.BeepOnError = true;
            this.dateEdit.Properties.DisplayFormat.FormatString = "yyyy-MM";
            this.dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit.Properties.Mask.EditMask = "yyyy-MM";
            this.dateEdit.Size = new System.Drawing.Size(122, 24);
            this.dateEdit.TabIndex = 2;
            // 
            // gridCtrl
            // 
            this.gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 148);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave});
            this.gridCtrl.Size = new System.Drawing.Size(1015, 535);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn12});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.GroupPanelText = "拖动列到该面板可进行分组显示";
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "工号";
            this.gridColumn3.FieldName = "StaffNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "PersonName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "月份";
            this.gridColumn1.FieldName = "BelongMonth";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "岗位工资";
            this.gridColumn5.FieldName = "PostSalary";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "绩效工资";
            this.gridColumn7.FieldName = "PerformanceSalary";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "效益工资";
            this.gridColumn9.FieldName = "BenefitSalary";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "全勤奖";
            this.gridColumn13.FieldName = "AttendanceSalary";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 7;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "工龄工资";
            this.gridColumn14.FieldName = "SenioritySalary";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "工资总和";
            this.gridColumn12.FieldName = "SalaryTotal";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "补发";
            this.gridColumn15.FieldName = "ReissueSalary";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "部门";
            this.gridColumn4.FieldName = "Department";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "保存", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tableLayoutPanelQuery
            // 
            this.tableLayoutPanelQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelQuery.ColumnCount = 8;
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.textEditName, 1, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.textEditStaffNumber, 3, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.simpleButtonQuery, 5, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.simpleButtonClear, 4, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.comboBoxEditDepartment, 5, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.dateEdit, 1, 1);
            this.tableLayoutPanelQuery.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelQuery.Name = "tableLayoutPanelQuery";
            this.tableLayoutPanelQuery.RowCount = 2;
            this.tableLayoutPanelQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelQuery.Size = new System.Drawing.Size(773, 79);
            this.tableLayoutPanelQuery.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(44, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "姓名";
            // 
            // textEditName
            // 
            this.textEditName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditName.Location = new System.Drawing.Point(80, 5);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(122, 24);
            this.textEditName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(261, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "工号";
            // 
            // textEditStaffNumber
            // 
            this.textEditStaffNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditStaffNumber.Location = new System.Drawing.Point(297, 5);
            this.textEditStaffNumber.Name = "textEditStaffNumber";
            this.textEditStaffNumber.Size = new System.Drawing.Size(122, 24);
            this.textEditStaffNumber.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(479, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "部门";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(44, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "月份";
            // 
            // simpleButtonQuery
            // 
            this.simpleButtonQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonQuery.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonQuery.Image")));
            this.simpleButtonQuery.Location = new System.Drawing.Point(515, 40);
            this.simpleButtonQuery.Name = "simpleButtonQuery";
            this.simpleButtonQuery.Size = new System.Drawing.Size(95, 34);
            this.simpleButtonQuery.TabIndex = 3;
            this.simpleButtonQuery.Text = "查询";
            this.simpleButtonQuery.Click += new System.EventHandler(this.simpleButtonQuery_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonClear.Location = new System.Drawing.Point(446, 40);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(48, 34);
            this.simpleButtonClear.TabIndex = 4;
            this.simpleButtonClear.Text = "清空";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // comboBoxEditDepartment
            // 
            this.comboBoxEditDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEditDepartment.Location = new System.Drawing.Point(515, 5);
            this.comboBoxEditDepartment.Name = "comboBoxEditDepartment";
            this.comboBoxEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDepartment.Size = new System.Drawing.Size(100, 24);
            this.comboBoxEditDepartment.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelQuery, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 687);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pageHeader, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.columnSelecetor, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(999, 51);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // pageHeader
            // 
            this.pageHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pageHeader.Location = new System.Drawing.Point(542, 4);
            this.pageHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.PageCurrent = 0;
            this.pageHeader.PageTotal = 0;
            this.pageHeader.Size = new System.Drawing.Size(454, 43);
            this.pageHeader.TabIndex = 0;
            // 
            // columnSelecetor
            // 
            this.columnSelecetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.columnSelecetor.Location = new System.Drawing.Point(3, 7);
            this.columnSelecetor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.columnSelecetor.Name = "columnSelecetor";
            this.columnSelecetor.Size = new System.Drawing.Size(232, 36);
            this.columnSelecetor.TabIndex = 1;
            // 
            // SalaryHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalaryHistoryForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            this.tableLayoutPanelQuery.ResumeLayout(false);
            this.tableLayoutPanelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStaffNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDepartment.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditStaffNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UICustomer.PageHeader pageHeader;
        private UICustomer.ColumnSelecetor columnSelecetor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}