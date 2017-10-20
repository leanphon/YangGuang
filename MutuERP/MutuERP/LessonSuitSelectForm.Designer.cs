namespace MutuERP
{
    partial class LessonSuitSelectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.gridCtrlPost = new DevExpress.XtraGrid.GridControl();
            this.gridViewPost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cloumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 44);
            this.panel1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(292, 7);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 32);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(383, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 32);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // gridCtrlPost
            // 
            this.gridCtrlPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlPost.Location = new System.Drawing.Point(3, 3);
            this.gridCtrlPost.MainView = this.gridViewPost;
            this.gridCtrlPost.Name = "gridCtrlPost";
            this.gridCtrlPost.Size = new System.Drawing.Size(780, 517);
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
            this.gridColumn3,
            this.gridColumn2});
            this.gridViewPost.GridControl = this.gridCtrlPost;
            this.gridViewPost.Name = "gridViewPost";
            this.gridViewPost.OptionsBehavior.Editable = false;
            this.gridViewPost.OptionsView.ColumnAutoWidth = false;
            this.gridViewPost.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPost.OptionsView.ShowFooter = true;
            this.gridViewPost.OptionsView.ShowGroupedColumns = true;
            this.gridViewPost.OptionsView.ShowGroupPanel = false;
            // 
            // cloumn1
            // 
            this.cloumn1.Caption = "课程名称";
            this.cloumn1.FieldName = "Name";
            this.cloumn1.Name = "cloumn1";
            this.cloumn1.Visible = true;
            this.cloumn1.VisibleIndex = 1;
            this.cloumn1.Width = 322;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "课程代码";
            this.gridColumn1.FieldName = "LessonNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 149;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "课时";
            this.gridColumn3.FieldName = "Time Length";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "价格";
            this.gridColumn2.FieldName = "Sex";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 119;
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
            this.tableLayoutPanel1.Controls.Add(this.gridCtrlPost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LessonSuitSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LessonSuitSelectForm";
            this.Text = "课程选择";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private DevExpress.XtraGrid.GridControl gridCtrlPost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPost;
        private DevExpress.XtraGrid.Columns.GridColumn cloumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}