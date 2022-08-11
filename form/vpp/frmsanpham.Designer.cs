namespace vpp
{
    partial class frmsanpham
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.bttk = new System.Windows.Forms.Button();
            this.rdsp = new System.Windows.Forms.RadioButton();
            this.rdloai = new System.Windows.Forms.RadioButton();
            this.txttk = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbmaloai = new System.Windows.Forms.ComboBox();
            this.ptloadanh = new System.Windows.Forms.PictureBox();
            this.btsua_sp = new System.Windows.Forms.Button();
            this.btxoa_sp = new System.Windows.Forms.Button();
            this.btthem_sp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btchonfile = new System.Windows.Forms.Button();
            this.txthinhanh = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.datasanpham = new System.Windows.Forms.DataGridView();
            this.dataloai = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btsualoai = new System.Windows.Forms.Button();
            this.btxoa_loai = new System.Windows.Forms.Button();
            this.btthem_loai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptloadanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataloai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btlammoi);
            this.groupBox4.Controls.Add(this.btthoat);
            this.groupBox4.Controls.Add(this.bttk);
            this.groupBox4.Controls.Add(this.rdsp);
            this.groupBox4.Controls.Add(this.rdloai);
            this.groupBox4.Controls.Add(this.txttk);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(847, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 177);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và thoát";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(131, 127);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(65, 30);
            this.btlammoi.TabIndex = 16;
            this.btlammoi.Text = "Refresh";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(212, 127);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(65, 30);
            this.btthoat.TabIndex = 15;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(231, 87);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(49, 25);
            this.bttk.TabIndex = 14;
            this.bttk.Text = "Tìm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // rdsp
            // 
            this.rdsp.AutoSize = true;
            this.rdsp.Location = new System.Drawing.Point(72, 45);
            this.rdsp.Name = "rdsp";
            this.rdsp.Size = new System.Drawing.Size(82, 20);
            this.rdsp.TabIndex = 13;
            this.rdsp.TabStop = true;
            this.rdsp.Text = "Sản phẩm";
            this.rdsp.UseVisualStyleBackColor = true;
            // 
            // rdloai
            // 
            this.rdloai.AutoSize = true;
            this.rdloai.Location = new System.Drawing.Point(11, 45);
            this.rdloai.Name = "rdloai";
            this.rdloai.Size = new System.Drawing.Size(50, 20);
            this.rdloai.TabIndex = 12;
            this.rdloai.TabStop = true;
            this.rdloai.Text = "Loại";
            this.rdloai.UseVisualStyleBackColor = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(11, 89);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(214, 23);
            this.txttk.TabIndex = 10;
            this.txttk.Enter += new System.EventHandler(this.txttk_Enter);
            this.txttk.Leave += new System.EventHandler(this.txttk_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbmaloai);
            this.groupBox3.Controls.Add(this.ptloadanh);
            this.groupBox3.Controls.Add(this.btsua_sp);
            this.groupBox3.Controls.Add(this.btxoa_sp);
            this.groupBox3.Controls.Add(this.btthem_sp);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btchonfile);
            this.groupBox3.Controls.Add(this.txthinhanh);
            this.groupBox3.Controls.Add(this.txtsoluong);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtdongia);
            this.groupBox3.Controls.Add(this.txtmasp);
            this.groupBox3.Controls.Add(this.txttensp);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(262, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 177);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // cbmaloai
            // 
            this.cbmaloai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmaloai.FormattingEnabled = true;
            this.cbmaloai.Location = new System.Drawing.Point(285, 92);
            this.cbmaloai.Name = "cbmaloai";
            this.cbmaloai.Size = new System.Drawing.Size(101, 23);
            this.cbmaloai.TabIndex = 18;
            // 
            // ptloadanh
            // 
            this.ptloadanh.Location = new System.Drawing.Point(396, 17);
            this.ptloadanh.Name = "ptloadanh";
            this.ptloadanh.Size = new System.Drawing.Size(178, 154);
            this.ptloadanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptloadanh.TabIndex = 17;
            this.ptloadanh.TabStop = false;
            // 
            // btsua_sp
            // 
            this.btsua_sp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua_sp.Location = new System.Drawing.Point(296, 131);
            this.btsua_sp.Name = "btsua_sp";
            this.btsua_sp.Size = new System.Drawing.Size(75, 23);
            this.btsua_sp.TabIndex = 16;
            this.btsua_sp.Text = "Sửa";
            this.btsua_sp.UseVisualStyleBackColor = true;
            this.btsua_sp.Click += new System.EventHandler(this.btsua_sp_Click);
            // 
            // btxoa_sp
            // 
            this.btxoa_sp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa_sp.Location = new System.Drawing.Point(215, 131);
            this.btxoa_sp.Name = "btxoa_sp";
            this.btxoa_sp.Size = new System.Drawing.Size(75, 23);
            this.btxoa_sp.TabIndex = 15;
            this.btxoa_sp.Text = "Xóa";
            this.btxoa_sp.UseVisualStyleBackColor = true;
            this.btxoa_sp.Click += new System.EventHandler(this.btxoa_sp_Click);
            // 
            // btthem_sp
            // 
            this.btthem_sp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem_sp.Location = new System.Drawing.Point(134, 131);
            this.btthem_sp.Name = "btthem_sp";
            this.btthem_sp.Size = new System.Drawing.Size(75, 23);
            this.btthem_sp.TabIndex = 14;
            this.btthem_sp.Text = "Thêm";
            this.btthem_sp.UseVisualStyleBackColor = true;
            this.btthem_sp.Click += new System.EventHandler(this.btthem_sp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Hình ảnh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số lượng";
            // 
            // btchonfile
            // 
            this.btchonfile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchonfile.Location = new System.Drawing.Point(9, 131);
            this.btchonfile.Name = "btchonfile";
            this.btchonfile.Size = new System.Drawing.Size(75, 23);
            this.btchonfile.TabIndex = 11;
            this.btchonfile.Text = "Chọn file";
            this.btchonfile.UseVisualStyleBackColor = true;
            this.btchonfile.Click += new System.EventHandler(this.btchonfile_Click);
            // 
            // txthinhanh
            // 
            this.txthinhanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthinhanh.Location = new System.Drawing.Point(96, 92);
            this.txthinhanh.Name = "txthinhanh";
            this.txthinhanh.Size = new System.Drawing.Size(124, 23);
            this.txthinhanh.TabIndex = 10;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(285, 62);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(101, 23);
            this.txtsoluong.TabIndex = 9;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(285, 30);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(101, 23);
            this.txtdongia.TabIndex = 3;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txtmasp
            // 
            this.txtmasp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasp.Location = new System.Drawing.Point(96, 30);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.ReadOnly = true;
            this.txtmasp.Size = new System.Drawing.Size(75, 23);
            this.txtmasp.TabIndex = 2;
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(96, 62);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(124, 23);
            this.txttensp.TabIndex = 1;
            // 
            // datasanpham
            // 
            this.datasanpham.AllowUserToAddRows = false;
            this.datasanpham.AllowUserToDeleteRows = false;
            this.datasanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datasanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tableLayoutPanel1.SetColumnSpan(this.datasanpham, 2);
            this.datasanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasanpham.Location = new System.Drawing.Point(262, 186);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.ReadOnly = true;
            this.datasanpham.RowTemplate.Height = 27;
            this.datasanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasanpham.Size = new System.Drawing.Size(871, 442);
            this.datasanpham.TabIndex = 4;
            this.datasanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasanpham_CellClick);
            this.datasanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasanpham_CellClick);
            this.datasanpham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datasanpham_CellMouseClick);
            // 
            // dataloai
            // 
            this.dataloai.AllowUserToAddRows = false;
            this.dataloai.AllowUserToDeleteRows = false;
            this.dataloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataloai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataloai.Location = new System.Drawing.Point(3, 186);
            this.dataloai.Name = "dataloai";
            this.dataloai.ReadOnly = true;
            this.dataloai.RowTemplate.Height = 27;
            this.dataloai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataloai.Size = new System.Drawing.Size(253, 442);
            this.dataloai.TabIndex = 1;
            this.dataloai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataloai_CellMouseClick);
            this.dataloai.SelectionChanged += new System.EventHandler(this.dataloai_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btsualoai);
            this.groupBox2.Controls.Add(this.btxoa_loai);
            this.groupBox2.Controls.Add(this.btthem_loai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txttenloai);
            this.groupBox2.Controls.Add(this.txtmaloai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 177);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại sản phẩm";
            // 
            // btsualoai
            // 
            this.btsualoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsualoai.Location = new System.Drawing.Point(168, 114);
            this.btsualoai.Name = "btsualoai";
            this.btsualoai.Size = new System.Drawing.Size(75, 23);
            this.btsualoai.TabIndex = 6;
            this.btsualoai.Text = "Sửa";
            this.btsualoai.UseVisualStyleBackColor = true;
            this.btsualoai.Click += new System.EventHandler(this.btsualoai_Click);
            // 
            // btxoa_loai
            // 
            this.btxoa_loai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa_loai.Location = new System.Drawing.Point(87, 114);
            this.btxoa_loai.Name = "btxoa_loai";
            this.btxoa_loai.Size = new System.Drawing.Size(75, 23);
            this.btxoa_loai.TabIndex = 5;
            this.btxoa_loai.Text = "Xóa";
            this.btxoa_loai.UseVisualStyleBackColor = true;
            this.btxoa_loai.Click += new System.EventHandler(this.btxoa_loai_Click);
            // 
            // btthem_loai
            // 
            this.btthem_loai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem_loai.Location = new System.Drawing.Point(6, 114);
            this.btthem_loai.Name = "btthem_loai";
            this.btthem_loai.Size = new System.Drawing.Size(75, 23);
            this.btthem_loai.TabIndex = 4;
            this.btthem_loai.Text = "Thêm";
            this.btthem_loai.UseVisualStyleBackColor = true;
            this.btthem_loai.Click += new System.EventHandler(this.btthem_loai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(92, 74);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(141, 23);
            this.txttenloai.TabIndex = 1;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(92, 42);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.ReadOnly = true;
            this.txtmaloai.Size = new System.Drawing.Size(141, 23);
            this.txtmaloai.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.6872F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.3128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datasanpham, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataloai, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.00159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.99841F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 631);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAISP";
            this.Column1.HeaderText = "Mã Loại Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAISP";
            this.Column2.HeaderText = "Tên Loại Sản Phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MASP";
            this.Column3.HeaderText = "Mã Sản Phẩm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENSP";
            this.Column4.HeaderText = "Tên Sản Phẩm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MALOAI";
            this.Column8.HeaderText = "Mã Loại";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DONGIA";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SOLUONGTON";
            this.Column6.HeaderText = "Số lượng tồn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "HINHANH";
            this.Column7.HeaderText = "Hình";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frmsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmsanpham_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptloadanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataloai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataloai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btsualoai;
        private System.Windows.Forms.Button btxoa_loai;
        private System.Windows.Forms.Button btthem_loai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.DataGridView datasanpham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btchonfile;
        private System.Windows.Forms.TextBox txthinhanh;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btsua_sp;
        private System.Windows.Forms.Button btxoa_sp;
        private System.Windows.Forms.Button btthem_sp;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.RadioButton rdsp;
        private System.Windows.Forms.RadioButton rdloai;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.PictureBox ptloadanh;
        private System.Windows.Forms.ComboBox cbmaloai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}