namespace vpp
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.txttk_dn = new System.Windows.Forms.TextBox();
            this.txtmk_dn = new System.Windows.Forms.TextBox();
            this.lbtk = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.check_hienthipass = new System.Windows.Forms.CheckBox();
            this.btdn_dn = new System.Windows.Forms.Button();
            this.btthodn_dn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttk_dn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txttk_dn, 2);
            this.txttk_dn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttk_dn.Location = new System.Drawing.Point(145, 82);
            this.txttk_dn.Name = "txttk_dn";
            this.txttk_dn.Size = new System.Drawing.Size(262, 23);
            this.txttk_dn.TabIndex = 3;
            // 
            // txtmk_dn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtmk_dn, 2);
            this.txtmk_dn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtmk_dn.Location = new System.Drawing.Point(145, 119);
            this.txtmk_dn.Name = "txtmk_dn";
            this.txtmk_dn.Size = new System.Drawing.Size(262, 23);
            this.txtmk_dn.TabIndex = 4;
            this.txtmk_dn.UseSystemPasswordChar = true;
            // 
            // lbtk
            // 
            this.lbtk.AutoSize = true;
            this.lbtk.BackColor = System.Drawing.SystemColors.Control;
            this.lbtk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbtk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtk.Location = new System.Drawing.Point(62, 79);
            this.lbtk.Name = "lbtk";
            this.lbtk.Size = new System.Drawing.Size(77, 37);
            this.lbtk.TabIndex = 5;
            this.lbtk.Text = "Tài khoản";
            this.lbtk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.BackColor = System.Drawing.SystemColors.Control;
            this.lbmk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbmk.Location = new System.Drawing.Point(62, 116);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(77, 27);
            this.lbmk.TabIndex = 6;
            this.lbmk.Text = "Mật khẩu";
            this.lbmk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // check_hienthipass
            // 
            this.check_hienthipass.AutoSize = true;
            this.check_hienthipass.BackColor = System.Drawing.SystemColors.Control;
            this.check_hienthipass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check_hienthipass.Location = new System.Drawing.Point(145, 146);
            this.check_hienthipass.Name = "check_hienthipass";
            this.check_hienthipass.Size = new System.Drawing.Size(128, 24);
            this.check_hienthipass.TabIndex = 8;
            this.check_hienthipass.Text = "Hiển thị mật khẩu";
            this.check_hienthipass.UseVisualStyleBackColor = false;
            this.check_hienthipass.CheckedChanged += new System.EventHandler(this.check_hienthipass_CheckedChanged);
            // 
            // btdn_dn
            // 
            this.btdn_dn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdn_dn.BackgroundImage")));
            this.btdn_dn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdn_dn.Image = ((System.Drawing.Image)(resources.GetObject("btdn_dn.Image")));
            this.btdn_dn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdn_dn.Location = new System.Drawing.Point(145, 176);
            this.btdn_dn.Name = "btdn_dn";
            this.btdn_dn.Size = new System.Drawing.Size(110, 45);
            this.btdn_dn.TabIndex = 9;
            this.btdn_dn.Text = "Đăng nhập";
            this.btdn_dn.UseVisualStyleBackColor = true;
            this.btdn_dn.Click += new System.EventHandler(this.btdn_dn_Click);
            // 
            // btthodn_dn
            // 
            this.btthodn_dn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthodn_dn.BackgroundImage")));
            this.btthodn_dn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthodn_dn.Image = ((System.Drawing.Image)(resources.GetObject("btthodn_dn.Image")));
            this.btthodn_dn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthodn_dn.Location = new System.Drawing.Point(279, 176);
            this.btthodn_dn.Name = "btthodn_dn";
            this.btthodn_dn.Size = new System.Drawing.Size(110, 45);
            this.btthodn_dn.TabIndex = 10;
            this.btthodn_dn.Text = "Thoát";
            this.btthodn_dn.UseVisualStyleBackColor = true;
            this.btthodn_dn.Click += new System.EventHandler(this.btthodn_dn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.52344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21094F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.17188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72656F));
            this.tableLayoutPanel1.Controls.Add(this.lbtk, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtmk_dn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btdn_dn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.check_hienthipass, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbmk, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttk_dn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btthodn_dn, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.52613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.407665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.55749F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 287);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vpp.Properties.Resources.duc_tui_bi_kip_kinh_doanh_van_phong_pham_sieu_lai;
            this.ClientSize = new System.Drawing.Size(512, 287);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txttk_dn;
        private System.Windows.Forms.TextBox txtmk_dn;
        private System.Windows.Forms.Label lbtk;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.CheckBox check_hienthipass;
        private System.Windows.Forms.Button btdn_dn;
        private System.Windows.Forms.Button btthodn_dn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}