namespace DataAnalyser
{
    partial class SaleHistoryForm
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
            this.gridControlTrade = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnFinalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelLevelHigh = new System.Windows.Forms.Label();
            this.comboBoxLevelHigh = new System.Windows.Forms.ComboBox();
            this.comboBoxLevelMid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLevelLow = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlTrade
            // 
            this.gridControlTrade.Location = new System.Drawing.Point(12, 103);
            this.gridControlTrade.MainView = this.gridView1;
            this.gridControlTrade.Name = "gridControlTrade";
            this.gridControlTrade.Size = new System.Drawing.Size(910, 476);
            this.gridControlTrade.TabIndex = 0;
            this.gridControlTrade.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnSerial,
            this.columnPrice,
            this.columnDate,
            this.columnQuantity,
            this.gridColumnName,
            this.columnFinalPrice});
            this.gridView1.GridControl = this.gridControlTrade;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // columnSerial
            // 
            this.columnSerial.AppearanceCell.Options.UseTextOptions = true;
            this.columnSerial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnSerial.Caption = "流水号";
            this.columnSerial.FieldName = "TradeSerial";
            this.columnSerial.Name = "columnSerial";
            this.columnSerial.Visible = true;
            this.columnSerial.VisibleIndex = 0;
            this.columnSerial.Width = 235;
            // 
            // columnPrice
            // 
            this.columnPrice.AppearanceCell.Options.UseTextOptions = true;
            this.columnPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnPrice.Caption = "单价";
            this.columnPrice.FieldName = "UnitPrice";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.Visible = true;
            this.columnPrice.VisibleIndex = 3;
            // 
            // columnDate
            // 
            this.columnDate.AppearanceCell.Options.UseTextOptions = true;
            this.columnDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnDate.Caption = "交易时间";
            this.columnDate.FieldName = "TradeDate";
            this.columnDate.Name = "columnDate";
            this.columnDate.Visible = true;
            this.columnDate.VisibleIndex = 5;
            this.columnDate.Width = 183;
            // 
            // columnQuantity
            // 
            this.columnQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.columnQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnQuantity.Caption = "数量";
            this.columnQuantity.FieldName = "Quantity";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.Visible = true;
            this.columnQuantity.VisibleIndex = 2;
            this.columnQuantity.Width = 81;
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnName.Caption = "商品";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 248;
            // 
            // columnFinalPrice
            // 
            this.columnFinalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.columnFinalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.columnFinalPrice.Caption = "总价";
            this.columnFinalPrice.FieldName = "FinalPrice";
            this.columnFinalPrice.Name = "columnFinalPrice";
            this.columnFinalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FinalPrice", "{0}")});
            this.columnFinalPrice.Visible = true;
            this.columnFinalPrice.VisibleIndex = 4;
            this.columnFinalPrice.Width = 68;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.comboBoxLevelLow);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.comboBoxLevelMid);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.comboBoxLevelHigh);
            this.groupControl1.Controls.Add(this.labelLevelHigh);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(910, 85);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "筛选";
            // 
            // labelLevelHigh
            // 
            this.labelLevelHigh.AutoSize = true;
            this.labelLevelHigh.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelLevelHigh.Location = new System.Drawing.Point(23, 37);
            this.labelLevelHigh.Name = "labelLevelHigh";
            this.labelLevelHigh.Size = new System.Drawing.Size(61, 21);
            this.labelLevelHigh.TabIndex = 1;
            this.labelLevelHigh.Text = "一级：";
            // 
            // comboBoxLevelHigh
            // 
            this.comboBoxLevelHigh.FormattingEnabled = true;
            this.comboBoxLevelHigh.Location = new System.Drawing.Point(91, 35);
            this.comboBoxLevelHigh.Name = "comboBoxLevelHigh";
            this.comboBoxLevelHigh.Size = new System.Drawing.Size(121, 26);
            this.comboBoxLevelHigh.TabIndex = 2;
            // 
            // comboBoxLevelMid
            // 
            this.comboBoxLevelMid.FormattingEnabled = true;
            this.comboBoxLevelMid.Location = new System.Drawing.Point(312, 35);
            this.comboBoxLevelMid.Name = "comboBoxLevelMid";
            this.comboBoxLevelMid.Size = new System.Drawing.Size(121, 26);
            this.comboBoxLevelMid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "二级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(465, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "三级：";
            // 
            // comboBoxLevelLow
            // 
            this.comboBoxLevelLow.FormattingEnabled = true;
            this.comboBoxLevelLow.Location = new System.Drawing.Point(533, 35);
            this.comboBoxLevelLow.Name = "comboBoxLevelLow";
            this.comboBoxLevelLow.Size = new System.Drawing.Size(121, 26);
            this.comboBoxLevelLow.TabIndex = 4;
            // 
            // SaleHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 658);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlTrade);
            this.Name = "SaleHistoryForm";
            this.Text = "销售记录";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnSerial;
        private DevExpress.XtraGrid.Columns.GridColumn columnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn columnDate;
        private DevExpress.XtraGrid.Columns.GridColumn columnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn columnFinalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gridControlTrade;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBoxLevelLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLevelMid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLevelHigh;
        private System.Windows.Forms.Label labelLevelHigh;
    }
}