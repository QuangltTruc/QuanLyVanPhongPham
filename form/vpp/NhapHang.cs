using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpp
{
    public partial class NhapHang : Form
    {
        public int manv;
        ketnoisql cn = new ketnoisql();
        public NhapHang()
        {
            InitializeComponent();
        }
        private void loadcbb()
        {
            cbtenncc.Items.Clear();

            List<string> dsncc = cn.LoadTenNCC();

            foreach (string item in dsncc)
            {
                cbtenncc.Items.Add(item);
            }

            cbtenloai.Items.Clear();

            List<string> dsloaimh = cn.LoadLoaiSP();

            foreach (string item in dsloaimh)
            {
                cbtenloai.Items.Add(item);
            }

        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            btnsuasp.Enabled = true;
            btnxoasp.Enabled = true;
        }
        private void anthongtin1()
        {
            txttenncc.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            txtdiachi.Enabled = false;
            btnthemncc.Enabled = false;
            btnxoathongtinnhap.Enabled = false;
            btnchuyenncc.Enabled = false;
            cbtenncc.Enabled = false;
        }
        private void anthongtin2()
        {
            btnthemmoisp.Enabled = false;
            btnxoaallinfo.Enabled = false;
            txttenloai.Enabled = false;
            cbtenloai.Enabled = false;
            txttenmathang.Enabled = false;
            cbtenmathan.Enabled = false;
            cbsoluongnhap.Enabled = false;
            dtngaylap.Enabled = false;
            btnthemsp.Enabled = false;
            btnxoasp.Enabled = false;
            btnsuasp.Enabled = false;
            btncapnhatpn.Enabled = false;
            btninpn.Enabled = false;
        }
        public void loadthongtin()
        {
            dataGridView1.DataSource = null;
            DataTable a = cn.ExecuteQuery("select pn.MAPN,ncc.TENNCC,nv.TENNV,pn.NGAYLAP,sp.TENSP,ctpn.SOLUONG " +
                    "from PHIEUNHAP pn, CHITIETPHIEUNHAP ctpn, NHACUNGCAP ncc, NHANVIEN nv, SANPHAM sp " +
                    "where pn.MAPN=ctpn.MAPN " +
                    "and pn.MANV=nv.MANV " +
                    "and pn.MANCC=ncc.MANCC " +
                    "and ctpn.MASP=sp.MASP");
            dataGridView1.DataSource = a;
        }
        private void NhapHang_Load(object sender, EventArgs e)
        {
            lblnhanviennhap.Text = cn.laytennv(manv);
            rdbtsphienco.Checked = false;
            rdbtlhmh.Checked = false;
            rdbtmh.Checked = false;
            //lblnhanviennhap.Text = dtngaylap.Value.ToShortDateString();
            anthongtin1();
            anthongtin2();
            loadcbb();
            loadthongtin(); 
        }

        private void rdbtlhmh_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin2();
            if (rdbtlhmh.Checked == true)
            {
                btnthemmoisp.Enabled = true;
                btnxoaallinfo.Enabled = true;
                txttenloai.Enabled = true;
                txttenmathang.Enabled = true;
                btncapnhatpn.Enabled = true;
            }
        }

        private void rdbtsphienco_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin2();
            if (rdbtsphienco.Checked == true)
            {
                cbtenloai.Enabled = true;
                cbtenmathan.Enabled = true;
                cbsoluongnhap.Enabled = true;
                dtngaylap.Enabled = true;
                btnthemsp.Enabled = true;
                btnxoaallinfo.Enabled = true;
                btncapnhatpn.Enabled = true;
            }
        }

        private void rdbtmh_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin2();
            if (rdbtmh.Checked == true)
            {
                btnthemmoisp.Enabled = true;
                btnxoaallinfo.Enabled = true;
                cbtenloai.Enabled = true;
                txttenmathang.Enabled = true;
                btncapnhatpn.Enabled = true;
            }
        }

        private void rdbtnccmoi_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin1();
            if(rdbtnccmoi.Checked==true)
            {
                txttenncc.Enabled = true;
                txtsdt.Enabled = true;
                txtemail.Enabled = true;
                txtdiachi.Enabled = true;
                btnthemncc.Enabled = true;
                btnxoathongtinnhap.Enabled = true;
            }
        }

        private void rdbtncchco_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin1();
            if (rdbtncchco.Checked == true)
            {
                cbtenncc.Enabled = true;
                
            }
            
        }


        private void cbtenncc_TextChanged(object sender, EventArgs e)
        {
            lblmancc.Text = cn.laymancc(cbtenncc.Text).ToString();
            txttennhacc.Text = cbtenncc.Text;
            lblsdt.Text = cn.laysdt_ncc(int.Parse(lblmancc.Text));
            lblemail.Text = cn.layemail(int.Parse(lblmancc.Text));
            txtdchi.Text = cn.laydiachi(int.Parse(lblmancc.Text));
        }

        private void btnthemncc_Click(object sender, EventArgs e)
        {
            if (txttenncc.Text.Length < 1 || txtsdt.Text.Length < 1 || txtemail.Text.Length < 1 || txtdiachi.Text.Length < 1)
                MessageBox.Show("Vui lòng không được để trống thông tin!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(MessageBox.Show("Bạn chắc muốn thêm nhà cung cấp?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==System.Windows.Forms.DialogResult.Yes)
                {
                    if (cn.themncc(txttenncc.Text, txtsdt.Text, txtemail.Text, txtdiachi.Text))
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công!!");
                        btnchuyenncc.Enabled = true;
                        loadcbb();
                    }
                    else
                        MessageBox.Show("Thêm nhà cung cấp thất bại!!");
                }
            }

            
        }

        private void btnxoathongtinnhap_Click(object sender, EventArgs e)
        {
            txttenncc.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
        }

        private void btnchuyenncc_Click(object sender, EventArgs e)
        {
            lblmancc.Text = cn.laymancc(txttenncc.Text).ToString();
            txttennhacc.Text = txttenncc.Text;
            lblsdt.Text = txtsdt.Text;
            lblemail.Text = txtemail.Text;
            txtdchi.Text = txtdiachi.Text;
        }

        private void cbmaloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthemmoisp_Click(object sender, EventArgs e)
        {
            if (rdbtlhmh.Checked == true) 
            {
                if (cn.themloaisp(txttenloai.Text))
                {
                    int x = cn.laymaloaisanpham(txttenloai.Text);
                    if (cn.themsp(txttenmathang.Text, x, 0, 0, "NULL"))
                    {
                        MessageBox.Show("Thêm thành công");
                        cbsoluongnhap.Enabled = true;
                        dtngaylap.Enabled = true;
                        btnthemsp.Enabled = true;
                        loadcbb();
                        
                    }
                }
                
            }
            if (rdbtmh.Checked == true) 
            {
                int x = cn.laymaloaisanpham(cbtenloai.Text);
                if (cn.themsp(txttenmathang.Text, x, 0, 0, "NULL"))
                {
                    MessageBox.Show("Thêm thành công");
                    cbsoluongnhap.Enabled = true;
                    dtngaylap.Enabled = true;
                    btnthemsp.Enabled = true;
                }
            }
            if (rdbtsphienco.Checked == true)
            {
                int x = cn.laymaloaisanpham(cbtenloai.Text);
                if (cn.themsp(cbtenmathan.Text, x, 0, 0, "NULL"))
                {
                    cbsoluongnhap.Enabled = true;
                    dtngaylap.Enabled = true;
                    btnthemsp.Enabled = true;
                }
            }
        }

        private void btnxoaallinfo_Click(object sender, EventArgs e)
        {
            txttenloai.Text = "";
            txttenmathang.Text = "";
            cbtenloai.Text = "";
            cbtenmathan.Text = "";
            cbsoluongnhap.Text = "";
        }

        private void btncapnhatpn_Click(object sender, EventArgs e)
        {
            if (lblmancc.Text.Length < 1 || listView1.Items.Count < 1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cn.thempn(int.Parse(lblmancc.Text), manv, dtngaylap.Value.ToShortDateString(), 0))
                {
                    int x = cn.laymaphieunhap();
                    foreach (ListViewItem item in listView1.Items)
                    {
                        int masp = cn.laymasanpham(item.SubItems[0].Text);
                        int soluong = int.Parse(item.SubItems[1].Text);
                        if (cn.capnhatsanpham2(masp, soluong) == true)
                        {
                            if (cn.themctpn(x, masp, soluong, 0) == true)
                            { 
                                continue;
                                
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Cập nhật phiếu nhập thất bại 2");
                                return; 
                        }
                            
                    }

                    MessageBox.Show("Cập nhật phiếu nhập thành công");
                    btninpn.Enabled = true;
                    loadthongtin();
                    listView1.Items.Clear();

                }
                else
                    MessageBox.Show("Cập nhật phiếu nhập thất bại 1");
            }
        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {
            if (rdbtlhmh.Checked == true)
            {
                if (txttenloai.Text.Length < 1 && txttenmathang.Text.Length < 1 && cbsoluongnhap.Text.Length < 1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (ListViewItem item1 in listView1.Items)
                    {
                        if (item1.SubItems[0].Text.Trim().Equals(txttenmathang.Text.Trim()))
                        {
                            MessageBox.Show("Mặt hàng này hiện có!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem(new[] {txttenmathang.Text,
                                                                 cbsoluongnhap.Text});
                    listView1.Items.Add(item);
                }
            }
            if (rdbtmh.Checked == true)
            {
                if (cbtenloai.Text.Length < 1 && txttenmathang.Text.Length < 1 && cbsoluongnhap.Text.Length < 1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (ListViewItem item1 in listView1.Items)
                    {
                        if (item1.SubItems[0].Text.Trim().Equals(txttenmathang.Text.Trim()))
                        {
                            MessageBox.Show("Mặt hàng này hiện có!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem(new[] {txttenmathang.Text,
                                                                 cbsoluongnhap.Text});
                    listView1.Items.Add(item);
                }
            }
            if (rdbtsphienco.Checked == true)
            {
                if (cbtenloai.Text.Length < 1 && cbtenmathan.Text.Length < 1 && cbsoluongnhap.Text.Length < 1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (ListViewItem item1 in listView1.Items)
                    {
                        if (item1.SubItems[0].Text.Trim().Equals(cbtenmathan.Text.Trim()))
                        {
                            MessageBox.Show("Mặt hàng này hiện có!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem(new[] {cbtenmathan.Text,
                                                                 cbsoluongnhap.Text});
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnsuasp_Click(object sender, EventArgs e)
        {
            if (rdbtlhmh.Checked == true)
            {
                ListViewItem sua = (ListViewItem)listView1.FocusedItem;

                sua.SubItems[0].Text = txttenmathang.Text;
                sua.SubItems[1].Text = cbsoluongnhap.Text;
            }
            if (rdbtmh.Checked == true)
            {
                ListViewItem sua = (ListViewItem)listView1.FocusedItem;

                sua.SubItems[0].Text = txttenmathang.Text;
                sua.SubItems[1].Text = cbsoluongnhap.Text;
            }
            if (rdbtsphienco.Checked == true)
            {
                ListViewItem sua = (ListViewItem)listView1.FocusedItem;

                sua.SubItems[0].Text = cbtenmathan.Text;
                sua.SubItems[1].Text = cbsoluongnhap.Text;
            }
                
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                item.Remove();
        }

        private void cbmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtenmathan.Text = null;
            cbtenmathan.Items.Clear();
            string x = cbtenloai.Text.Trim();
            List<string> ds = cn.LoadSP(x);

            foreach (string item in ds)
            {
                cbtenmathan.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
