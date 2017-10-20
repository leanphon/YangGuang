namespace MutuERP
{
    partial class LessonEnrollForm
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
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCustomer = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdCard = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonRemark = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditCheck)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditPhone
            // 
            this.textEditPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditPhone.Enabled = false;
            this.textEditPhone.Location = new System.Drawing.Point(330, 49);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Mask.EditMask = "\\d+";
            this.textEditPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditPhone.Size = new System.Drawing.Size(132, 24);
            this.textEditPhone.TabIndex = 4;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(3, 93);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditCheck});
            this.gridControl.Size = new System.Drawing.Size(1100, 525);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "选择";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEditCheck;
            this.gridColumn1.FieldName = "Check";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 47;
            // 
            // repositoryItemCheckEditCheck
            // 
            this.repositoryItemCheckEditCheck.AutoHeight = false;
            this.repositoryItemCheckEditCheck.Name = "repositoryItemCheckEditCheck";
            this.repositoryItemCheckEditCheck.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEditCheck_CheckedChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "课程名称";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 208;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "课程单价(￥/节)";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 110;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "课程节数";
            this.gridColumn4.FieldName = "Count";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 109;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "课程总价(￥)";
            this.gridColumn5.FieldName = "PriceTotal";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 131;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "优惠额(￥)";
            this.gridColumn6.FieldName = "PriceDiscount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "实际总价(￥)";
            this.gridColumn7.FieldName = "PriceReal";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 81;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textEditPhone, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonRemark, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.lookUpEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textEditCustomer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textEditIdCard, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1100, 81);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.lookUpEdit, 3);
            this.lookUpEdit.Location = new System.Drawing.Point(104, 9);
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
            this.lookUpEdit.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gridControl, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1106, 680);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(38, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "客户搜索";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(38, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "客户姓名";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(264, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "客户电话";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(499, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "身份证";
            // 
            // textEditCustomer
            // 
            this.textEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditCustomer.Enabled = false;
            this.textEditCustomer.Location = new System.Drawing.Point(104, 49);
            this.textEditCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditCustomer.Name = "textEditCustomer";
            this.textEditCustomer.Size = new System.Drawing.Size(132, 24);
            this.textEditCustomer.TabIndex = 4;
            // 
            // textEditIdCard
            // 
            this.textEditIdCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditIdCard.Enabled = false;
            this.textEditIdCard.Location = new System.Drawing.Point(550, 49);
            this.textEditIdCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditIdCard.Name = "textEditIdCard";
            this.textEditIdCard.Size = new System.Drawing.Size(158, 24);
            this.textEditIdCard.TabIndex = 4;
            // 
            // simpleButtonSubmit
            // 
            this.simpleButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonSubmit.Location = new System.Drawing.Point(14, 5);
            this.simpleButtonSubmit.Name = "simpleButtonSubmit";
            this.simpleButtonSubmit.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonSubmit.TabIndex = 3;
            this.simpleButtonSubmit.Text = "提交";
            this.simpleButtonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonCancel.Location = new System.Drawing.Point(118, 5);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonCancel.TabIndex = 3;
            this.simpleButtonCancel.Text = "取消";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.simpleButtonCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButtonSubmit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(449, 626);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // simpleButtonRemark
            // 
            this.simpleButtonRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonRemark.Location = new System.Drawing.Point(742, 45);
            this.simpleButtonRemark.Name = "simpleButtonRemark";
            this.simpleButtonRemark.Size = new System.Drawing.Size(98, 33);
            this.simpleButtonRemark.TabIndex = 3;
            this.simpleButtonRemark.Text = "备注信息...";
            this.simpleButtonRemark.Click += new System.EventHandler(this.simpleButtonRemark_Click);
            // 
            // LessonEnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 703);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LessonEnrollForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditCheck)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditCheck;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditCustomer;
        private DevExpress.XtraEditors.TextEdit textEditIdCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemark;
    }
}