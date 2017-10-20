namespace MutuERP
{
    partial class MainMenuForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.buttonLesson = new System.Windows.Forms.Button();
            this.buttonPolicy = new System.Windows.Forms.Button();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonEnroll);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonLesson);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.buttonPolicy);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.buttonSetup);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(63, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1037, 474);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEnroll.FlatAppearance.BorderSize = 0;
            this.buttonEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnroll.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEnroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEnroll.Image = global::MutuERP.Properties.Resources.add;
            this.buttonEnroll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEnroll.Location = new System.Drawing.Point(3, 3);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(170, 205);
            this.buttonEnroll.TabIndex = 0;
            this.buttonEnroll.Text = "报名";
            this.buttonEnroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnroll.UseVisualStyleBackColor = true;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // buttonLesson
            // 
            this.buttonLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLesson.FlatAppearance.BorderSize = 0;
            this.buttonLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLesson.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLesson.Image = global::MutuERP.Properties.Resources.next;
            this.buttonLesson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLesson.Location = new System.Drawing.Point(208, 3);
            this.buttonLesson.Name = "buttonLesson";
            this.buttonLesson.Size = new System.Drawing.Size(170, 205);
            this.buttonLesson.TabIndex = 0;
            this.buttonLesson.Text = "授课";
            this.buttonLesson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLesson.UseVisualStyleBackColor = true;
            this.buttonLesson.Click += new System.EventHandler(this.buttonLesson_Click);
            // 
            // buttonPolicy
            // 
            this.buttonPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPolicy.FlatAppearance.BorderSize = 0;
            this.buttonPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolicy.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonPolicy.Image = global::MutuERP.Properties.Resources.doc;
            this.buttonPolicy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPolicy.Location = new System.Drawing.Point(413, 3);
            this.buttonPolicy.Name = "buttonPolicy";
            this.buttonPolicy.Size = new System.Drawing.Size(170, 205);
            this.buttonPolicy.TabIndex = 0;
            this.buttonPolicy.Text = "决策数据";
            this.buttonPolicy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPolicy.UseVisualStyleBackColor = true;
            this.buttonPolicy.Click += new System.EventHandler(this.buttonPolicy_Click);
            // 
            // buttonSetup
            // 
            this.buttonSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetup.FlatAppearance.BorderSize = 0;
            this.buttonSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetup.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSetup.Image = global::MutuERP.Properties.Resources.auto;
            this.buttonSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSetup.Location = new System.Drawing.Point(618, 3);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(170, 205);
            this.buttonSetup.TabIndex = 0;
            this.buttonSetup.Text = "自动化运营";
            this.buttonSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Image = global::MutuERP.Properties.Resources.appl;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(823, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 205);
            this.button1.TabIndex = 0;
            this.button1.Text = "设置";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(179, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 166);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(384, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 166);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(794, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 166);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(589, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 166);
            this.panel4.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "主界面";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Button buttonLesson;
        private System.Windows.Forms.Button buttonPolicy;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}