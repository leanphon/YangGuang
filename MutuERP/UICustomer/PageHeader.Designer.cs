namespace UICustomer
{
    partial class PageHeader
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageHeader));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonFisrtPage = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPrevPage = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNextPage = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLastPage = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlPage = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditSelect = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButtonGo = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelect.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonFisrtPage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonPrevPage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonNextPage, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonLastPage, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControlPage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxEditSelect, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonGo, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 35);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // simpleButtonFisrtPage
            // 
            this.simpleButtonFisrtPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonFisrtPage.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonFisrtPage.Image")));
            this.simpleButtonFisrtPage.Location = new System.Drawing.Point(3, 3);
            this.simpleButtonFisrtPage.Name = "simpleButtonFisrtPage";
            this.simpleButtonFisrtPage.Size = new System.Drawing.Size(36, 29);
            this.simpleButtonFisrtPage.TabIndex = 11;
            this.simpleButtonFisrtPage.Text = "|<";
            this.simpleButtonFisrtPage.Click += new System.EventHandler(this.buttonFirstPage_Click);
            // 
            // simpleButtonPrevPage
            // 
            this.simpleButtonPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonPrevPage.Image")));
            this.simpleButtonPrevPage.Location = new System.Drawing.Point(60, 3);
            this.simpleButtonPrevPage.Name = "simpleButtonPrevPage";
            this.simpleButtonPrevPage.Size = new System.Drawing.Size(36, 29);
            this.simpleButtonPrevPage.TabIndex = 11;
            this.simpleButtonPrevPage.Text = "<";
            this.simpleButtonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // simpleButtonNextPage
            // 
            this.simpleButtonNextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonNextPage.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonNextPage.Image")));
            this.simpleButtonNextPage.Location = new System.Drawing.Point(188, 3);
            this.simpleButtonNextPage.Name = "simpleButtonNextPage";
            this.simpleButtonNextPage.Size = new System.Drawing.Size(36, 29);
            this.simpleButtonNextPage.TabIndex = 11;
            this.simpleButtonNextPage.Text = ">";
            this.simpleButtonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // simpleButtonLastPage
            // 
            this.simpleButtonLastPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonLastPage.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLastPage.Image")));
            this.simpleButtonLastPage.Location = new System.Drawing.Point(239, 3);
            this.simpleButtonLastPage.Name = "simpleButtonLastPage";
            this.simpleButtonLastPage.Size = new System.Drawing.Size(36, 29);
            this.simpleButtonLastPage.TabIndex = 11;
            this.simpleButtonLastPage.Text = ">";
            this.simpleButtonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // labelControlPage
            // 
            this.labelControlPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControlPage.Location = new System.Drawing.Point(139, 8);
            this.labelControlPage.Name = "labelControlPage";
            this.labelControlPage.Size = new System.Drawing.Size(22, 18);
            this.labelControlPage.TabIndex = 12;
            this.labelControlPage.Text = "1/1";
            // 
            // comboBoxEditSelect
            // 
            this.comboBoxEditSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEditSelect.Location = new System.Drawing.Point(301, 5);
            this.comboBoxEditSelect.Name = "comboBoxEditSelect";
            this.comboBoxEditSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSelect.Size = new System.Drawing.Size(87, 24);
            this.comboBoxEditSelect.TabIndex = 13;
            this.comboBoxEditSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // simpleButtonGo
            // 
            this.simpleButtonGo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonGo.Location = new System.Drawing.Point(399, 3);
            this.simpleButtonGo.Name = "simpleButtonGo";
            this.simpleButtonGo.Size = new System.Drawing.Size(36, 29);
            this.simpleButtonGo.TabIndex = 11;
            this.simpleButtonGo.Text = "GO";
            this.simpleButtonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // PageHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "PageHeader";
            this.Size = new System.Drawing.Size(449, 35);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelect.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFisrtPage;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPrevPage;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNextPage;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLastPage;
        private DevExpress.XtraEditors.LabelControl labelControlPage;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelect;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGo;
    }
}
