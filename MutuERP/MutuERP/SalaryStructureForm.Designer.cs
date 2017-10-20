namespace MutuERP
{
    partial class SalaryStructureForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPost = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPerformance = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBenefit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBoxPost = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBoxPerformance = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBoxBenefit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBenefit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxBenefit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrl);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 570);
            this.panel2.TabIndex = 1;
            // 
            // gridCtrl
            // 
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 4);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxPost,
            this.repositoryItemButtonEditSave,
            this.repositoryItemComboBoxPerformance,
            this.repositoryItemComboBoxBenefit,
            this.repositoryItemLookUpEditPost,
            this.repositoryItemLookUpEditPerformance,
            this.repositoryItemLookUpEditBenefit});
            this.gridCtrl.Size = new System.Drawing.Size(1099, 563);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewStaff_CellValueChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "工号";
            this.gridColumn3.FieldName = "StaffNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "PersonName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "岗位层级";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEditPost;
            this.gridColumn1.FieldName = "PostLevel";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditPost
            // 
            this.repositoryItemLookUpEditPost.AutoHeight = false;
            this.repositoryItemLookUpEditPost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPost.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Level", "岗位层级"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "岗位名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BaseSalary", "岗位工资")});
            this.repositoryItemLookUpEditPost.DisplayMember = "Level";
            this.repositoryItemLookUpEditPost.Name = "repositoryItemLookUpEditPost";
            this.repositoryItemLookUpEditPost.NullText = "请选择";
            this.repositoryItemLookUpEditPost.ValueMember = "Level";
            this.repositoryItemLookUpEditPost.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditPost_EditValueChanged);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "岗位名称";
            this.gridColumn4.FieldName = "PostName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "岗位工资";
            this.gridColumn5.FieldName = "PostBaseSalary";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "绩效层级";
            this.gridColumn6.ColumnEdit = this.repositoryItemLookUpEditPerformance;
            this.gridColumn6.FieldName = "PerformanceLevel";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditPerformance
            // 
            this.repositoryItemLookUpEditPerformance.AutoHeight = false;
            this.repositoryItemLookUpEditPerformance.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPerformance.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Level", "绩效层级"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BaseSalary", "绩效工资")});
            this.repositoryItemLookUpEditPerformance.DisplayMember = "Level";
            this.repositoryItemLookUpEditPerformance.Name = "repositoryItemLookUpEditPerformance";
            this.repositoryItemLookUpEditPerformance.NullText = "请选择";
            this.repositoryItemLookUpEditPerformance.ValueMember = "Level";
            this.repositoryItemLookUpEditPerformance.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditPerformance_EditValueChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "绩效工资";
            this.gridColumn7.FieldName = "PerformanceBaseSalary";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "效益层级";
            this.gridColumn8.ColumnEdit = this.repositoryItemLookUpEditBenefit;
            this.gridColumn8.FieldName = "BenefitLevel";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEditBenefit
            // 
            this.repositoryItemLookUpEditBenefit.AutoHeight = false;
            this.repositoryItemLookUpEditBenefit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBenefit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Level", "效益层级"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BaseSalary", "效益工资")});
            this.repositoryItemLookUpEditBenefit.DisplayMember = "Level";
            this.repositoryItemLookUpEditBenefit.Name = "repositoryItemLookUpEditBenefit";
            this.repositoryItemLookUpEditBenefit.NullText = "请选择";
            this.repositoryItemLookUpEditBenefit.ValueMember = "Level";
            this.repositoryItemLookUpEditBenefit.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditBenefit_EditValueChanged);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "效益工资";
            this.gridColumn9.FieldName = "BenefitBaseSalary";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "保存";
            this.gridColumn10.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "保存", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.Click += new System.EventHandler(this.repositoryItemButtonEditSave_Click);
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "全勤奖";
            this.gridColumn11.FieldName = "AttendanceSalary";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "工龄工资";
            this.gridColumn12.FieldName = "SenioritySalary";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            // 
            // repositoryItemComboBoxPost
            // 
            this.repositoryItemComboBoxPost.AutoHeight = false;
            this.repositoryItemComboBoxPost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxPost.Name = "repositoryItemComboBoxPost";
            // 
            // repositoryItemComboBoxPerformance
            // 
            this.repositoryItemComboBoxPerformance.AutoHeight = false;
            this.repositoryItemComboBoxPerformance.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxPerformance.Name = "repositoryItemComboBoxPerformance";
            // 
            // repositoryItemComboBoxBenefit
            // 
            this.repositoryItemComboBoxBenefit.AutoHeight = false;
            this.repositoryItemComboBoxBenefit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxBenefit.Name = "repositoryItemComboBoxBenefit";
            // 
            // SalaryStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 595);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalaryStructureForm";
            this.Text = "PostForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBenefit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxBenefit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxPost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxPerformance;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxBenefit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPost;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPerformance;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBenefit;
    }
}