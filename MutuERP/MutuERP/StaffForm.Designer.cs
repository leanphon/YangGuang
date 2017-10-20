namespace MutuERP
{
    partial class StaffForm
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.dateEditStatus = new DevExpress.XtraEditors.DateEdit();
            this.dateEditBirthday = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDateStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStaffNumber = new System.Windows.Forms.TextBox();
            this.textBoxBankCard = new System.Windows.Forms.TextBox();
            this.textBoxIdCard = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.gridCtrlPost = new DevExpress.XtraGrid.GridControl();
            this.gridViewPost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cloumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStatus.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.comboBoxStatus);
            this.panelInput.Controls.Add(this.comboBoxDep);
            this.panelInput.Controls.Add(this.dateEditStatus);
            this.panelInput.Controls.Add(this.dateEditBirthday);
            this.panelInput.Controls.Add(this.comboBoxSex);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.labelDateStatus);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.textBoxPhone);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.textBoxStaffNumber);
            this.panelInput.Controls.Add(this.textBoxBankCard);
            this.panelInput.Controls.Add(this.textBoxIdCard);
            this.panelInput.Controls.Add(this.textBoxName);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(3, 4);
            this.panelInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1103, 112);
            this.panelInput.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "试用",
            "转正",
            "离职"});
            this.comboBoxStatus.Location = new System.Drawing.Point(736, 70);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 26);
            this.comboBoxStatus.TabIndex = 8;
            this.comboBoxStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxStatus_SelectedValueChanged);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(736, 19);
            this.comboBoxDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(121, 26);
            this.comboBoxDep.TabIndex = 4;
            // 
            // dateEditStatus
            // 
            this.dateEditStatus.EditValue = null;
            this.dateEditStatus.Location = new System.Drawing.Point(964, 70);
            this.dateEditStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEditStatus.Name = "dateEditStatus";
            this.dateEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStatus.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditStatus.Size = new System.Drawing.Size(120, 24);
            this.dateEditStatus.TabIndex = 9;
            // 
            // dateEditBirthday
            // 
            this.dateEditBirthday.EditValue = null;
            this.dateEditBirthday.Location = new System.Drawing.Point(545, 20);
            this.dateEditBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEditBirthday.Name = "dateEditBirthday";
            this.dateEditBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBirthday.Size = new System.Drawing.Size(120, 24);
            this.dateEditBirthday.TabIndex = 3;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSex.Location = new System.Drawing.Point(415, 19);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(54, 26);
            this.comboBoxSex.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "部门";
            // 
            // labelDateStatus
            // 
            this.labelDateStatus.AutoSize = true;
            this.labelDateStatus.Location = new System.Drawing.Point(889, 73);
            this.labelDateStatus.Name = "labelDateStatus";
            this.labelDateStatus.Size = new System.Drawing.Size(68, 18);
            this.labelDateStatus.TabIndex = 1;
            this.labelDateStatus.Text = "转正时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "手机";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "工号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "银行卡";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "身份证";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(65, 70);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(105, 26);
            this.textBoxPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // textBoxStaffNumber
            // 
            this.textBoxStaffNumber.Location = new System.Drawing.Point(68, 19);
            this.textBoxStaffNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStaffNumber.Name = "textBoxStaffNumber";
            this.textBoxStaffNumber.Size = new System.Drawing.Size(102, 26);
            this.textBoxStaffNumber.TabIndex = 0;
            // 
            // textBoxBankCard
            // 
            this.textBoxBankCard.Location = new System.Drawing.Point(475, 70);
            this.textBoxBankCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBankCard.Name = "textBoxBankCard";
            this.textBoxBankCard.Size = new System.Drawing.Size(190, 26);
            this.textBoxBankCard.TabIndex = 7;
            // 
            // textBoxIdCard
            // 
            this.textBoxIdCard.Location = new System.Drawing.Point(234, 70);
            this.textBoxIdCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdCard.Name = "textBoxIdCard";
            this.textBoxIdCard.Size = new System.Drawing.Size(162, 26);
            this.textBoxIdCard.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(234, 19);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(116, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(651, 4);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 38);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(556, 4);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 38);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(456, 4);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 38);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "修改";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(353, 4);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 38);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "增加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // gridCtrlPost
            // 
            this.gridCtrlPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlPost.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrlPost.Location = new System.Drawing.Point(3, 192);
            this.gridCtrlPost.MainView = this.gridViewPost;
            this.gridCtrlPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrlPost.Name = "gridCtrlPost";
            this.gridCtrlPost.Size = new System.Drawing.Size(1103, 492);
            this.gridCtrlPost.TabIndex = 0;
            this.gridCtrlPost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPost,
            this.gridView1});
            // 
            // gridViewPost
            // 
            this.gridViewPost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cloumn1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewPost.GridControl = this.gridCtrlPost;
            this.gridViewPost.Name = "gridViewPost";
            this.gridViewPost.OptionsBehavior.Editable = false;
            this.gridViewPost.OptionsView.ColumnAutoWidth = false;
            this.gridViewPost.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPost.OptionsView.ShowGroupPanel = false;
            this.gridViewPost.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPost_RowClick);
            // 
            // cloumn1
            // 
            this.cloumn1.Caption = "姓名";
            this.cloumn1.FieldName = "Name";
            this.cloumn1.Name = "cloumn1";
            this.cloumn1.Visible = true;
            this.cloumn1.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "工号";
            this.gridColumn1.FieldName = "StaffNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "性别";
            this.gridColumn2.FieldName = "Sex";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 51;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "手机";
            this.gridColumn3.FieldName = "Phone";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "身份证";
            this.gridColumn4.FieldName = "IdCard";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "银行卡";
            this.gridColumn5.FieldName = "BankCard";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 197;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "生日";
            this.gridColumn6.FieldName = "Birthday";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "部门";
            this.gridColumn7.FieldName = "Department";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "状态";
            this.gridColumn8.FieldName = "Status";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "入职时间";
            this.gridColumn9.FieldName = "DateEntry";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "转正时间";
            this.gridColumn10.FieldName = "DateFormal";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrlPost;
            this.gridView1.Name = "gridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrlPost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 688);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.2043F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 124);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffForm";
            this.Text = "PostForm";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStatus.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStaffNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBankCard;
        private System.Windows.Forms.TextBox textBoxIdCard;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhone;
        private DevExpress.XtraEditors.DateEdit dateEditBirthday;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl gridCtrlPost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPost;
        private DevExpress.XtraGrid.Columns.GridColumn cloumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.DateEdit dateEditStatus;
        private System.Windows.Forms.Label labelDateStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}