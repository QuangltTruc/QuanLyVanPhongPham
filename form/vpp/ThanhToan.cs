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
    public partial class ThanhToan : Form
    {
        public int manv;
        ketnoisql cn = new ketnoisql();
        public static int mahoadon;
        public ThanhToan()
        {
            InitializeComponent();
        }
        private void anthongtin()
        {
            txthoten.Enabled = false;
            txtsdt.Enabled = false;
            cbgioitinh.Enabled = false;
            btnthemkh.Enabled = false;
            btnxoathongtin.Enabled = false;
            btnchuyenkh.Enabled = false;
            btnxacnhankh.Enabled = false;
            btninhoadon.Enabled = false;
        }

        private void hienthiloaisanpham()
        {
            cbloaimh.Items.Clear();

            List<string> ds = cn.LoadLoaiSP();

            foreach (string item in ds)
            {
                cbloaimh.Items.Add(item);
            }
        }
        public void loadthongtin()
        {
            dataGridView1.DataSource = null;
            DataTable a = cn.ExecuteQuery("select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV");
            dataGridView1.DataSource = a;
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            lblnvlap.Text = cn.laytennv(manv);
            loadthongtin();
            anthongtin();
            hienthiloaisanpham();
            int thanhtien = 0;
            if (listView1.Items.Count < 1)
                thanhtien = 0;
            else
            {
                foreach (ListViewItem item1 in listView1.Items)
                    thanhtien += int.Parse(item1.SubItems[3].Text);
            }
            lblthanhtien.Text = thanhtien.ToString();
        }

        private void cbloaimh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmathang.Text = "";
            cbmathang.Items.Clear();
            string x = cbloaimh.Text.Trim();
            List<string> ds = cn.LoadSP(x);

            foreach (string item in ds)
            {
                cbmathang.Items.Add(item);
            }
        }

        private void cbmathang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtdongiasp.Text = null;
            //if (cbmathang.Text != null)
            //{
            //    //txtdongiasp.Text = null;
            //    string x = cbmathang.Text.Trim();
            //    if (cn.laygiasanpham(x) == -1)
            //        MessageBox.Show("Không lấy được tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        txtdongiasp.Text = (cn.laygiasanpham(x)).ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnthemthongtinsp_Click(object sender, EventArgs e)
        {
            if(cbloaimh.Text.Length<1 || cbmathang.Text.Length<1)
            {
                MessageBox.Show("Vui lòng nhập loại mặt hàng và mặt hàng");
                return;
            }
            int thanhtien = 0;
            int a = cn.laymasanpham(cbmathang.Text);
            int aa = cn.kiemtrasoluongton(a);
            if (nbsoluongmua.Value < 1)
                MessageBox.Show("Vui lòng nhập số lượng mua > 0");
            else if (nbsoluongmua.Value > aa)
                MessageBox.Show("Trong kho chỉ còn " + aa);
            else
            {
                string x = cbmathang.Text.Trim();
                foreach (ListViewItem item1 in listView1.Items)
                {
                    if (item1.SubItems[0].Text.Equals(cbmathang.Text))
                    {
                        MessageBox.Show("Mặt hàng này hiện có!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                ListViewItem item = new ListViewItem(new[] {cbmathang.Text,
                                                                        nbsoluongmua.Value.ToString(),
                                                                      (cn.laygiasanpham(x)).ToString(),//txtdongiasp.Text,                                            
                                                                       //(int.Parse(txtdongiasp.Text)*nbsoluongmua.Value).ToString()});
                                                                       (cn.laygiasanpham(x)*nbsoluongmua.Value).ToString()});
                listView1.Items.Add(item);
            }

            if (listView1.Items.Count < 1)
                thanhtien = 0;
            else
            {
                foreach (ListViewItem item1 in listView1.Items)
                    thanhtien += int.Parse(item1.SubItems[3].Text);
            }
            lblthanhtien.Text = thanhtien.ToString();
            nbsoluongmua.Value = 1;
        }

        private void btnsuathongtinsp_Click(object sender, EventArgs e)
        {
            string x = cbmathang.Text.Trim();
            int a = cn.laymasanpham(cbmathang.Text);
            int aa = cn.kiemtrasoluongton(a);
            if (nbsoluongmua.Value > aa)
            { 
                MessageBox.Show("Trong kho chỉ còn " + aa);
                return;
            }
            
            if (listView1.FocusedItem != null)
            {
                int thanhtien = 0;
                ListViewItem sua = (ListViewItem)listView1.FocusedItem;

                sua.SubItems[0].Text = cbmathang.Text;
                sua.SubItems[1].Text = nbsoluongmua.Value.ToString();
                sua.SubItems[2].Text = cn.laygiasanpham(x).ToString();//txtdongiasp.Text;
                sua.SubItems[3].Text = (cn.laygiasanpham(x) * nbsoluongmua.Value).ToString();
                if (listView1.Items.Count < 1)
                    thanhtien = 0;
                else
                {
                    foreach (ListViewItem item1 in listView1.Items)
                        thanhtien += int.Parse(item1.SubItems[3].Text);
                }
                lblthanhtien.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để cập nhật!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoathongtinsp_Click(object sender, EventArgs e)
        {
            int thanhtien = 0;
            foreach (ListViewItem item in listView1.SelectedItems)
                item.Remove();
            if (listView1.Items.Count < 1)
                thanhtien = 0;
            else
            {
                foreach (ListViewItem item1 in listView1.Items)
                    thanhtien += int.Parse(item1.SubItems[3].Text);
            }
            lblthanhtien.Text = thanhtien.ToString();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                ListViewItem item1 = (ListViewItem)listView1.FocusedItem;
                cbmathang.Text = item1.SubItems[0].Text;
                //txtdongiasp.Text = item1.SubItems[1].Text;
                nbsoluongmua.Value = int.Parse(item1.SubItems[1].Text);
            }

        }
        private void btnlockh_Click(object sender, EventArgs e)
        {
            if (txthtkh.Text.Length < 1 && txtsodt.Text.Length < 1)
                MessageBox.Show("Vui lòng nhập tên hoặc số điện thoại khách hàng");
            else
            {
                listkhachhang.Items.Clear();
                if (rdbtkhachcu.Checked == false && rdbtkhachmoi.Checked == false)
                {
                    if (cn.timkh(txthtkh.Text) > 0)
                        MessageBox.Show("Có khách hàng này, vui lòng chọn mục khách cũ để lấy thông tin");
                    else
                        MessageBox.Show("Chưa có khách hàng này, vui lòng chọn mục khách mới để thêm khách hàng");
                }
                else if (rdbtkhachcu.Checked == true && rdbtkhachmoi.Checked == false)
                {
                    if (cn.timkh(txthtkh.Text) > 0)
                    {
                        //listkhachhang.DataSource = null;
                        //listkhachhang.DataSource = cn.LoadTenKH(txthtkh.Text);
                        listkhachhang.Items.Clear();

                        List<string> ds = cn.LoadTenKH(txthtkh.Text, txtsodt.Text);

                        foreach (string item in ds)
                        {
                            listkhachhang.Items.Add(item);
                        }
                        btnxacnhankh.Enabled = true;
                    }
                    else
                        MessageBox.Show("Chưa có khách hàng này, vui lòng chọn mục khách mới để thêm khách hàng");
                }
                else
                    MessageBox.Show("Muốn tìm hoặc lọc khách hàng thì vui lòng chọn khách cũ!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void rdbtkhachcu_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin();
            if (rdbtkhachcu.Checked == true)
            {
            }
        }

        private void rdbtkhachmoi_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin();
            if (rdbtkhachmoi.Checked == true)
            {
                txthoten.Enabled = true;
                txtsdt.Enabled = true;
                cbgioitinh.Enabled = true;
                btnthemkh.Enabled = true;
                btnxoathongtin.Enabled = true;
            }

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            if (cn.themkh(txthoten.Text, txtsdt.Text, cbgioitinh.Text) == true)
                MessageBox.Show("Thêm khách hàng thành công");
            else
                MessageBox.Show("Thêm khách hàng thất bại");
            btnchuyenkh.Enabled = true;
        }

        private void btnxoathongtin_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
            txtsdt.Text = "";
            cbgioitinh.Text = "";
        }

        private void btnchuyenkh_Click(object sender, EventArgs e)
        {
            if (txthoten.Text.Length < 1 || txtsdt.Text.Length < 1 || cbgioitinh.Text.Length < 1)
            {
                MessageBox.Show("Không có dữ liệu để chuyển qua");
                return;
            }
            lblmakh.Text = cn.laymakh(txthoten.Text, txtsdt.Text).ToString();
            lblhotenkh.Text = txthoten.Text;
            lblsdt.Text = txtsdt.Text;
            lblgioitinh.Text = cbgioitinh.Text;
        }

        private void btnxacnhankh_Click(object sender, EventArgs e)
        {
            //if (txthtkh.Text.Length < 1 || txtsodt.Text.Length < 1 || cbgioitinh.Text.Length < 1)
            //{
            //    MessageBox.Show("Không có dữ liệu để chuyển qua");
            //    return;
            //}
            if (listkhachhang.SelectedItem != null)
            {
                lblmakh.Text = cn.laymakh2(listkhachhang.SelectedItem.ToString()).ToString();
                lblhotenkh.Text = listkhachhang.SelectedItem.ToString();
                lblsdt.Text = cn.laysdt(int.Parse(lblmakh.Text));
                lblgioitinh.Text = cn.laygioitinh(int.Parse(lblmakh.Text));
            }
            else
                MessageBox.Show("Vui lòng chọn 1 mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnxoalistkh_Click(object sender, EventArgs e)
        {
            txthtkh.Text = "";
            txtsodt.Text = "";
            listkhachhang.Items.Clear();
        }

        private void lblthanhtien_TextChanged(object sender, EventArgs e)
        {
            if ((int.Parse(lblthanhtien.Text)) >= 100000 && (int.Parse(lblthanhtien.Text))<200000)
                lblgiamgia.Text =  (5000).ToString();
            else if((int.Parse(lblthanhtien.Text)) >= 200000 && (int.Parse(lblthanhtien.Text)) <300000)
                lblgiamgia.Text =  (10000).ToString();
            else if ((int.Parse(lblthanhtien.Text)) >= 300000 && (int.Parse(lblthanhtien.Text)) <400000)
                lblgiamgia.Text =  (15000).ToString();
            else if ((int.Parse(lblthanhtien.Text)) >= 400000)
                lblgiamgia.Text =  (20000).ToString();
            else
                lblgiamgia.Text = "0";
            
        }

        private void btncapnhathd_Click(object sender, EventArgs e)
        {
            if (lblmakh.Text.Length < 1 || listView1.Items.Count < 1)
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cn.themhd(int.Parse(lblmakh.Text), manv, dtngaylap.Value.ToShortDateString(), decimal.Parse(lblgiamgia.Text), (decimal.Parse(lblthanhtien.Text) - decimal.Parse(lblgiamgia.Text))))
                {
                    int x = cn.laymahoadon();
                    foreach(ListViewItem item in listView1.Items)
                    {
                        int masp = cn.laymasanpham(item.SubItems[0].Text);
                        int soluong = int.Parse(item.SubItems[1].Text);
                        decimal thanhtien = decimal.Parse(item.SubItems[3].Text);
                        if (cn.capnhatsanpham(masp, soluong) == true)
                        {
                            if (cn.themcthd(x, masp, soluong, thanhtien) == true)
                            {
                                continue;
                            }
                            
                        }
                        else
                        { 
                            MessageBox.Show("Cập nhật hóa đơn thất bại 3");
                            return;
                        }
                    }
                    if (cn.capnhattienhoadon() == true)
                    { 
                        MessageBox.Show("Cập nhật hóa đơn thành công"); 
                        btninhoadon.Enabled = true;
                        loadthongtin();
                        mahoadon = x;

                    }
                    else
                        MessageBox.Show("Cập nhật hóa đơn thất bại 2");
                }
                else
                    MessageBox.Show("Cập nhật hóa đơn thất bại 1");
            }
            
           // lblnvlap.Text = (int.Parse(lblthanhtien.Text)+int.Parse(lblgiamgia.Text)).ToString();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            hoadonbanhang a = new hoadonbanhang();
            a.mahd = mahoadon;
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
