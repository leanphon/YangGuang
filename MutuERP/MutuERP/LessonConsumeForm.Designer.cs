namespace MutuERP
{
    partial class LessonConsumeForm
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
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cloumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTeacher = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCustomer = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdCard = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanelLesson = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTeacher)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 354);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditTeacher});
            this.gridCtrl.Size = new System.Drawing.Size(971, 368);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cloumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // cloumn1
            // 
            this.cloumn1.Caption = "课程名称";
            this.cloumn1.FieldName = "LessonName";
            this.cloumn1.Name = "cloumn1";
            this.cloumn1.OptionsColumn.AllowEdit = false;
            this.cloumn1.Visible = true;
            this.cloumn1.VisibleIndex = 0;
            this.cloumn1.Width = 214;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "已上课时";
            this.gridColumn3.FieldName = "LessonConsumed";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "课时总数";
            this.gridColumn2.FieldName = "ItemTotal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 93;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "本次消费";
            this.gridColumn5.FieldName = "CurrentConsume";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "结余";
            this.gridColumn6.FieldName = "Remain";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 85;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "授课老师";
            this.gridColumn7.ColumnEdit = this.repositoryItemLookUpEditTeacher;
            this.gridColumn7.FieldName = "TeacherName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 94;
            // 
            // repositoryItemLookUpEditTeacher
            // 
            this.repositoryItemLookUpEditTeacher.AutoHeight = false;
            this.repositoryItemLookUpEditTeacher.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTeacher.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StaffNumber", "工号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "姓名")});
            this.repositoryItemLookUpEditTeacher.DisplayMember = "Name";
            this.repositoryItemLookUpEditTeacher.Name = "repositoryItemLookUpEditTeacher";
            this.repositoryItemLookUpEditTeacher.NullText = "请选择";
            this.repositoryItemLookUpEditTeacher.ValueMember = "Name";
            this.repositoryItemLookUpEditTeacher.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditTeacher_EditValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 782);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.simpleButtonSubmit, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.simpleButtonCancel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(372, 731);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // simpleButtonSubmit
            // 
            this.simpleButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonSubmit.Location = new System.Drawing.Point(21, 4);
            this.simpleButtonSubmit.Name = "simpleButtonSubmit";
            this.simpleButtonSubmit.Size = new System.Drawing.Size(74, 37);
            this.simpleButtonSubmit.TabIndex = 0;
            this.simpleButtonSubmit.Text = "提交";
            this.simpleButtonSubmit.Click += new System.EventHandler(this.simpleButtonSubmit_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonCancel.Location = new System.Drawing.Point(137, 4);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(74, 37);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "取消";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(3, 343);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 2);
            this.panel2.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(971, 333);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textEditPhone, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lookUpEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl5, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.textEditCustomer, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textEditIdCard, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(886, 91);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(268, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "客户电话";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(26, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "客户姓名";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(26, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "客户搜索";
            // 
            // textEditPhone
            // 
            this.textEditPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditPhone.Enabled = false;
            this.textEditPhone.Location = new System.Drawing.Point(334, 56);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Mask.EditMask = "\\d+";
            this.textEditPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditPhone.Size = new System.Drawing.Size(132, 24);
            this.textEditPhone.TabIndex = 21;
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEdit.Location = new System.Drawing.Point(92, 10);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "客户姓名"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "电话"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCard", "身份证")});
            this.lookUpEdit.Properties.DisplayMember = "Name";
            this.lookUpEdit.Properties.NullText = "请选择";
            this.lookUpEdit.Properties.PopupWidth = 400;
            this.lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit.Properties.ValueMember = "Id";
            this.lookUpEdit.Properties.EditValueChanged += new System.EventHandler(this.lookUpEdit_Properties_EditValueChanged);
            this.lookUpEdit.Size = new System.Drawing.Size(132, 24);
            this.lookUpEdit.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(514, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "身份证";
            // 
            // textEditCustomer
            // 
            this.textEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditCustomer.Enabled = false;
            this.textEditCustomer.Location = new System.Drawing.Point(92, 56);
            this.textEditCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditCustomer.Name = "textEditCustomer";
            this.textEditCustomer.Size = new System.Drawing.Size(132, 24);
            this.textEditCustomer.TabIndex = 21;
            // 
            // textEditIdCard
            // 
            this.textEditIdCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditIdCard.Enabled = false;
            this.textEditIdCard.Location = new System.Drawing.Point(565, 56);
            this.textEditIdCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditIdCard.Name = "textEditIdCard";
            this.textEditIdCard.Size = new System.Drawing.Size(158, 24);
            this.textEditIdCard.TabIndex = 21;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanelLesson);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(965, 230);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "课程选择";
            // 
            // flowLayoutPanelLesson
            // 
            this.flowLayoutPanelLesson.AutoScroll = true;
            this.flowLayoutPanelLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLesson.Location = new System.Drawing.Point(2, 27);
            this.flowLayoutPanelLesson.Name = "flowLayoutPanelLesson";
            this.flowLayoutPanelLesson.Size = new System.Drawing.Size(961, 201);
            this.flowLayoutPanelLesson.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1026, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "客户电话";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(1083, 143);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "身份证";
            // 
            // LessonConsumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 821);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LessonConsumeForm";
            this.Text = "课程消费";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTeacher)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cloumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLesson;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTeacher;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditCustomer;
        private DevExpress.XtraEditors.TextEdit textEditIdCard;
    }
}