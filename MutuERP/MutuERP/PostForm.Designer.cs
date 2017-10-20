namespace MutuERP
{
    partial class PostForm
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonModify = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditSalary = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditLevel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 114);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(652, 348);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cloumn1,
            this.gridColumn1,
            this.columnSalary});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPost_RowClick);
            // 
            // cloumn1
            // 
            this.cloumn1.Caption = "岗位名称";
            this.cloumn1.FieldName = "Name";
            this.cloumn1.Name = "cloumn1";
            this.cloumn1.Visible = true;
            this.cloumn1.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "岗位层级";
            this.gridColumn1.FieldName = "Level";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // columnSalary
            // 
            this.columnSalary.AppearanceCell.Options.UseTextOptions = true;
            this.columnSalary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnSalary.Caption = "岗位工资";
            this.columnSalary.DisplayFormat.FormatString = "{0:D} ";
            this.columnSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.columnSalary.FieldName = "BaseSalary";
            this.columnSalary.Name = "columnSalary";
            this.columnSalary.Visible = true;
            this.columnSalary.VisibleIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 466);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonModify, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonClear, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(145, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(367, 41);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonAdd.Location = new System.Drawing.Point(13, 4);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(64, 32);
            this.simpleButtonAdd.TabIndex = 3;
            this.simpleButtonAdd.Text = "增加";
            this.simpleButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // simpleButtonModify
            // 
            this.simpleButtonModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonModify.Location = new System.Drawing.Point(104, 4);
            this.simpleButtonModify.Name = "simpleButtonModify";
            this.simpleButtonModify.Size = new System.Drawing.Size(64, 32);
            this.simpleButtonModify.TabIndex = 3;
            this.simpleButtonModify.Text = "修改";
            this.simpleButtonModify.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonDelete.Location = new System.Drawing.Point(195, 4);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(64, 32);
            this.simpleButtonDelete.TabIndex = 3;
            this.simpleButtonDelete.Text = "删除";
            this.simpleButtonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonClear.Location = new System.Drawing.Point(288, 4);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(64, 32);
            this.simpleButtonClear.TabIndex = 3;
            this.simpleButtonClear.Text = "清空";
            this.simpleButtonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.Controls.Add(this.textEditSalary, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textEditLevel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textEditName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // textEditSalary
            // 
            this.textEditSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditSalary.Location = new System.Drawing.Point(510, 8);
            this.textEditSalary.Name = "textEditSalary";
            this.textEditSalary.Size = new System.Drawing.Size(122, 24);
            this.textEditSalary.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(444, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "岗位工资";
            // 
            // textEditLevel
            // 
            this.textEditLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditLevel.Location = new System.Drawing.Point(289, 8);
            this.textEditLevel.Name = "textEditLevel";
            this.textEditLevel.Size = new System.Drawing.Size(122, 24);
            this.textEditLevel.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(223, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "岗位层级";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(11, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "岗位名称";
            // 
            // textEditName
            // 
            this.textEditName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditName.Location = new System.Drawing.Point(77, 8);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(122, 24);
            this.textEditName.TabIndex = 0;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cloumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn columnSalary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModify;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit textEditSalary;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditLevel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditName;
    }
}