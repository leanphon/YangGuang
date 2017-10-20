namespace MutuERP
{
    partial class LessonInputForm
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonModify = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanelLesson = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEditTimeLength = new DevExpress.XtraEditors.TextEdit();
            this.textEditDescription = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelLesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Location = new System.Drawing.Point(3, 124);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(780, 468);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cloumn1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // cloumn1
            // 
            this.cloumn1.Caption = "课程名称";
            this.cloumn1.FieldName = "Name";
            this.cloumn1.Name = "cloumn1";
            this.cloumn1.Visible = true;
            this.cloumn1.VisibleIndex = 0;
            this.cloumn1.Width = 287;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "补充描述";
            this.gridColumn1.FieldName = "Description";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 202;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "价格(￥/节)";
            this.gridColumn2.FieldName = "Price";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 119;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "课时(h/节)";
            this.gridColumn3.FieldName = "TimeLength";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrl;
            this.gridView1.Name = "gridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLesson, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridCtrl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 596);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonModify, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonClear, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(194, 67);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonAdd.Location = new System.Drawing.Point(24, 5);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(61, 35);
            this.simpleButtonAdd.TabIndex = 0;
            this.simpleButtonAdd.Text = "增加";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonModify
            // 
            this.simpleButtonModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonModify.Location = new System.Drawing.Point(133, 5);
            this.simpleButtonModify.Name = "simpleButtonModify";
            this.simpleButtonModify.Size = new System.Drawing.Size(61, 35);
            this.simpleButtonModify.TabIndex = 0;
            this.simpleButtonModify.Text = "修改";
            this.simpleButtonModify.Click += new System.EventHandler(this.simpleButtonModify_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonDelete.Location = new System.Drawing.Point(224, 5);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(61, 35);
            this.simpleButtonDelete.TabIndex = 0;
            this.simpleButtonDelete.Text = "删除";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButtonClear.Location = new System.Drawing.Point(313, 5);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(61, 35);
            this.simpleButtonClear.TabIndex = 0;
            this.simpleButtonClear.Text = "清空";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // tableLayoutPanelLesson
            // 
            this.tableLayoutPanelLesson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelLesson.ColumnCount = 8;
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelLesson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanelLesson.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.labelControl4, 6, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.textEditName, 1, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.textEditPrice, 3, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.textEditTimeLength, 5, 0);
            this.tableLayoutPanelLesson.Controls.Add(this.textEditDescription, 7, 0);
            this.tableLayoutPanelLesson.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanelLesson.Name = "tableLayoutPanelLesson";
            this.tableLayoutPanelLesson.RowCount = 1;
            this.tableLayoutPanelLesson.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLesson.Size = new System.Drawing.Size(765, 46);
            this.tableLayoutPanelLesson.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "课程名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(227, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "课程价格";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(392, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "课程时长";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(557, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "补充描述";
            // 
            // textEditName
            // 
            this.textEditName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditName.Location = new System.Drawing.Point(78, 11);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(129, 24);
            this.textEditName.TabIndex = 1;
            // 
            // textEditPrice
            // 
            this.textEditPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditPrice.Location = new System.Drawing.Point(293, 11);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Size = new System.Drawing.Size(76, 24);
            this.textEditPrice.TabIndex = 1;
            // 
            // textEditTimeLength
            // 
            this.textEditTimeLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditTimeLength.Location = new System.Drawing.Point(458, 11);
            this.textEditTimeLength.Name = "textEditTimeLength";
            this.textEditTimeLength.Size = new System.Drawing.Size(76, 24);
            this.textEditTimeLength.TabIndex = 1;
            // 
            // textEditDescription
            // 
            this.textEditDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textEditDescription.Location = new System.Drawing.Point(623, 11);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Size = new System.Drawing.Size(129, 24);
            this.textEditDescription.TabIndex = 1;
            // 
            // LessonInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LessonInputForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanelLesson.ResumeLayout(false);
            this.tableLayoutPanelLesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cloumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLesson;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private DevExpress.XtraEditors.TextEdit textEditTimeLength;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModify;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
    }
}