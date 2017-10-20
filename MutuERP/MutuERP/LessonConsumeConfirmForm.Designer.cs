namespace MutuERP
{
    partial class LessonConsumeConfirmForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textEditCustomer = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdCard = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 50);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(946, 350);
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
            this.gridColumn7.FieldName = "TeacherName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 94;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 468);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel3.Controls.Add(this.textEditPhone, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textEditCustomer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textEditIdCard, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(886, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textEditPhone
            // 
            this.textEditPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditPhone.Enabled = false;
            this.textEditPhone.Location = new System.Drawing.Point(334, 8);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Mask.EditMask = "\\d+";
            this.textEditPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditPhone.Size = new System.Drawing.Size(132, 24);
            this.textEditPhone.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.simpleButtonSubmit, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.simpleButtonCancel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(344, 412);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // simpleButtonSubmit
            // 
            this.simpleButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonSubmit.Location = new System.Drawing.Point(22, 5);
            this.simpleButtonSubmit.Name = "simpleButtonSubmit";
            this.simpleButtonSubmit.Size = new System.Drawing.Size(89, 37);
            this.simpleButtonSubmit.TabIndex = 0;
            this.simpleButtonSubmit.Text = "确认并打印";
            this.simpleButtonSubmit.Click += new System.EventHandler(this.simpleButtonSubmit_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(155, 5);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(89, 37);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "取消";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(993, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "客户电话";
            // 
            // textEditCustomer
            // 
            this.textEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditCustomer.Enabled = false;
            this.textEditCustomer.Location = new System.Drawing.Point(92, 8);
            this.textEditCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditCustomer.Name = "textEditCustomer";
            this.textEditCustomer.Size = new System.Drawing.Size(132, 24);
            this.textEditCustomer.TabIndex = 21;
            // 
            // textEditIdCard
            // 
            this.textEditIdCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditIdCard.Enabled = false;
            this.textEditIdCard.Location = new System.Drawing.Point(565, 8);
            this.textEditIdCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditIdCard.Name = "textEditIdCard";
            this.textEditIdCard.Size = new System.Drawing.Size(186, 24);
            this.textEditIdCard.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(26, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "客户姓名";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(268, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "客户电话";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(514, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "身份证";
            // 
            // LessonConsumeConfirmForm
            // 
            this.AcceptButton = this.simpleButtonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(957, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LessonConsumeConfirmForm";
            this.Text = "课程消费";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdCard.Properties)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.TextEdit textEditCustomer;
        private DevExpress.XtraEditors.TextEdit textEditIdCard;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}