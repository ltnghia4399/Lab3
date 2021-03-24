
namespace Lab3
{
    partial class BookSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSales));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBody = new System.Windows.Forms.Panel();
            this.gbBoxInfo = new System.Windows.Forms.GroupBox();
            this.chkDisStudent = new System.Windows.Forms.CheckBox();
            this.chkDis = new System.Windows.Forms.CheckBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.lbNetDue = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtExPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbExPrice = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.menuStrip1.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.gbBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuCal,
            this.mnuSum,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(125, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuCal
            // 
            this.mnuCal.Name = "mnuCal";
            this.mnuCal.Size = new System.Drawing.Size(125, 22);
            this.mnuCal.Text = "Calculate";
            this.mnuCal.Click += new System.EventHandler(this.mnuCal_Click);
            // 
            // mnuSum
            // 
            this.mnuSum.Name = "mnuSum";
            this.mnuSum.Size = new System.Drawing.Size(125, 22);
            this.mnuSum.Text = "Summary";
            this.mnuSum.Click += new System.EventHandler(this.mnuSum_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(125, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.gbBoxInfo);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 24);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(594, 415);
            this.pnBody.TabIndex = 1;
            // 
            // gbBoxInfo
            // 
            this.gbBoxInfo.Controls.Add(this.bunifuLabel1);
            this.gbBoxInfo.Controls.Add(this.chkDisStudent);
            this.gbBoxInfo.Controls.Add(this.chkDis);
            this.gbBoxInfo.Controls.Add(this.txtNet);
            this.gbBoxInfo.Controls.Add(this.lbNetDue);
            this.gbBoxInfo.Controls.Add(this.txtDis);
            this.gbBoxInfo.Controls.Add(this.lbDiscount);
            this.gbBoxInfo.Controls.Add(this.txtExPrice);
            this.gbBoxInfo.Controls.Add(this.txtPrice);
            this.gbBoxInfo.Controls.Add(this.txtQuality);
            this.gbBoxInfo.Controls.Add(this.txtTitle);
            this.gbBoxInfo.Controls.Add(this.lbExPrice);
            this.gbBoxInfo.Controls.Add(this.lbPrice);
            this.gbBoxInfo.Controls.Add(this.lbQuality);
            this.gbBoxInfo.Controls.Add(this.lbTitle);
            this.gbBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoxInfo.ForeColor = System.Drawing.Color.Blue;
            this.gbBoxInfo.Location = new System.Drawing.Point(12, 15);
            this.gbBoxInfo.Name = "gbBoxInfo";
            this.gbBoxInfo.Size = new System.Drawing.Size(570, 388);
            this.gbBoxInfo.TabIndex = 0;
            this.gbBoxInfo.TabStop = false;
            this.gbBoxInfo.Text = "Book Information";
            // 
            // chkDisStudent
            // 
            this.chkDisStudent.AutoSize = true;
            this.chkDisStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisStudent.ForeColor = System.Drawing.Color.Black;
            this.chkDisStudent.Location = new System.Drawing.Point(390, 321);
            this.chkDisStudent.Name = "chkDisStudent";
            this.chkDisStudent.Size = new System.Drawing.Size(146, 22);
            this.chkDisStudent.TabIndex = 13;
            this.chkDisStudent.Text = "Distinct Student";
            this.chkDisStudent.UseVisualStyleBackColor = true;
            // 
            // chkDis
            // 
            this.chkDis.AutoSize = true;
            this.chkDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDis.ForeColor = System.Drawing.Color.Black;
            this.chkDis.Location = new System.Drawing.Point(390, 263);
            this.chkDis.Name = "chkDis";
            this.chkDis.Size = new System.Drawing.Size(154, 22);
            this.chkDis.TabIndex = 12;
            this.chkDis.Text = "Normal Discount";
            this.chkDis.UseVisualStyleBackColor = true;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(153, 324);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(203, 22);
            this.txtNet.TabIndex = 11;
            // 
            // lbNetDue
            // 
            this.lbNetDue.AutoSize = true;
            this.lbNetDue.Location = new System.Drawing.Point(26, 324);
            this.lbNetDue.Name = "lbNetDue";
            this.lbNetDue.Size = new System.Drawing.Size(57, 16);
            this.lbNetDue.TabIndex = 10;
            this.lbNetDue.Text = "Net Due";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(153, 263);
            this.txtDis.Name = "txtDis";
            this.txtDis.ReadOnly = true;
            this.txtDis.Size = new System.Drawing.Size(203, 22);
            this.txtDis.TabIndex = 9;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(26, 263);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(60, 16);
            this.lbDiscount.TabIndex = 8;
            this.lbDiscount.Text = "Discount";
            // 
            // txtExPrice
            // 
            this.txtExPrice.Location = new System.Drawing.Point(153, 208);
            this.txtExPrice.Name = "txtExPrice";
            this.txtExPrice.ReadOnly = true;
            this.txtExPrice.Size = new System.Drawing.Size(203, 22);
            this.txtExPrice.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(153, 93);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(203, 22);
            this.txtQuality.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(153, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(405, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // lbExPrice
            // 
            this.lbExPrice.AutoSize = true;
            this.lbExPrice.Location = new System.Drawing.Point(26, 208);
            this.lbExPrice.Name = "lbExPrice";
            this.lbExPrice.Size = new System.Drawing.Size(99, 16);
            this.lbExPrice.TabIndex = 3;
            this.lbExPrice.Text = "Extended Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(26, 150);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(39, 16);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbQuality
            // 
            this.lbQuality.AutoSize = true;
            this.lbQuality.Location = new System.Drawing.Point(26, 93);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(49, 16);
            this.lbQuality.TabIndex = 1;
            this.lbQuality.Text = "Quality";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(26, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(34, 16);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(390, 156);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(79, 18);
            this.bunifuLabel1.TabIndex = 14;
            this.bunifuLabel1.Text = "bunifuLabel1";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BookSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 439);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.gbBoxInfo.ResumeLayout(false);
            this.gbBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuCal;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.GroupBox gbBoxInfo;
        private System.Windows.Forms.TextBox txtExPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbExPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuSum;
        private System.Windows.Forms.CheckBox chkDis;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.Label lbNetDue;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.CheckBox chkDisStudent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}

