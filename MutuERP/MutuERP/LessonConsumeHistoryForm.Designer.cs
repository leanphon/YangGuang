namespace MutuERP
{
    partial class LessonConsumeHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonConsumeHistoryForm));
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageHeader = new UICustomer.PageHeader();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelQuery = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCustomer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTeacher = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditLesson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditBegin = new DevExpress.XtraEditors.DateEdit();
            this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLesson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 153);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(944, 392);
            this.gridCtrl.TabIndex = 11;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn13,
            this.column1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.GroupPanelText = "拖动列到该面板可进行分组显示";
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "客户姓名";
            this.gridColumn9.FieldName = "CustomerName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "客户电话";
            this.gridColumn13.FieldName = "Phone";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // column1
            // 
            this.column1.Caption = "宝贝姓名";
            this.column1.FieldName = "BabyName";
            this.column1.Name = "column1";
            this.column1.OptionsColumn.AllowFocus = false;
            this.column1.Visible = true;
            this.column1.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "课程名称";
            this.gridColumn1.FieldName = "LessonName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "授课时间";
            this.gridColumn2.FieldName = "ConsumeTime";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "授课老师";
            this.gridColumn3.FieldName = "TeacherName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pageHeader);
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 54);
            this.panel1.TabIndex = 0;
            // 
            // pageHeader
            // 
            this.pageHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pageHeader.Location = new System.Drawing.Point(496, 11);
            this.pageHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.PageCurrent = 0;
            this.pageHeader.PageTotal = 0;
            this.pageHeader.Size = new System.Drawing.Size(448, 38);
            this.pageHeader.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelQuery, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 606);
            this.tableLayoutPanel1.TabIndex = 12;
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
            this.tableLayoutPanelQuery.Controls.Add(this.textEditCustomer, 1, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.textEditTeacher, 3, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.textEditLesson, 5, 0);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.labelControl5, 2, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.dateEditBegin, 1, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.dateEditEnd, 3, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.simpleButtonQuery, 5, 1);
            this.tableLayoutPanelQuery.Controls.Add(this.simpleButtonClear, 4, 1);
            this.tableLayoutPanelQuery.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanelQuery.Name = "tableLayoutPanelQuery";
            this.tableLayoutPanelQuery.RowCount = 2;
            this.tableLayoutPanelQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelQuery.Size = new System.Drawing.Size(895, 81);
            this.tableLayoutPanelQuery.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(14, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "客户姓名";
            // 
            // textEditCustomer
            // 
            this.textEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditCustomer.Location = new System.Drawing.Point(80, 6);
            this.textEditCustomer.Name = "textEditCustomer";
            this.textEditCustomer.Size = new System.Drawing.Size(122, 24);
            this.textEditCustomer.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(231, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "授课老师";
            // 
            // textEditTeacher
            // 
            this.textEditTeacher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditTeacher.Location = new System.Drawing.Point(297, 6);
            this.textEditTeacher.Name = "textEditTeacher";
            this.textEditTeacher.Size = new System.Drawing.Size(122, 24);
            this.textEditTeacher.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(449, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "课程名称";
            // 
            // textEditLesson
            // 
            this.textEditLesson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditLesson.Location = new System.Drawing.Point(515, 6);
            this.textEditLesson.Name = "textEditLesson";
            this.textEditLesson.Size = new System.Drawing.Size(122, 24);
            this.textEditLesson.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(14, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "起始日期";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(231, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "截止日期";
            // 
            // dateEditBegin
            // 
            this.dateEditBegin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateEditBegin.EditValue = null;
            this.dateEditBegin.Location = new System.Drawing.Point(80, 47);
            this.dateEditBegin.Name = "dateEditBegin";
            this.dateEditBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEditBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEditBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditBegin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBegin.Size = new System.Drawing.Size(122, 24);
            this.dateEditBegin.TabIndex = 2;
            // 
            // dateEditEnd
            // 
            this.dateEditEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateEditEnd.EditValue = null;
            this.dateEditEnd.Location = new System.Drawing.Point(297, 47);
            this.dateEditEnd.Name = "dateEditEnd";
            this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEditEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEditEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditEnd.Size = new System.Drawing.Size(122, 24);
            this.dateEditEnd.TabIndex = 2;
            // 
            // simpleButtonQuery
            // 
            this.simpleButtonQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonQuery.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonQuery.Image")));
            this.simpleButtonQuery.Location = new System.Drawing.Point(515, 42);
            this.simpleButtonQuery.Name = "simpleButtonQuery";
            this.simpleButtonQuery.Size = new System.Drawing.Size(95, 34);
            this.simpleButtonQuery.TabIndex = 3;
            this.simpleButtonQuery.Text = "查询";
            this.simpleButtonQuery.Click += new System.EventHandler(this.simpleButtonQuery_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonClear.Location = new System.Drawing.Point(446, 42);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(48, 34);
            this.simpleButtonClear.TabIndex = 4;
            this.simpleButtonClear.Text = "清空";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // LessonConsumeHistoryForm
            // 
            this.AcceptButton = this.simpleButtonQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LessonConsumeHistoryForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelQuery.ResumeLayout(false);
            this.tableLayoutPanelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLesson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private UICustomer.PageHeader pageHeader;
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn column1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditTeacher;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditLesson;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEditBegin;
        private DevExpress.XtraEditors.DateEdit dateEditEnd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
    }
}