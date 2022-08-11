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
    public partial class DoanhThu : Form
    {
        ketnoisql cn = new ketnoisql();
        public DoanhThu()
        {
            InitializeComponent();
        }
        private void anthongtin()
        {
            thang.Enabled = false;
            nam.Enabled = false;
            tgiandau.Enabled = false;
            tgiancuoi.Enabled = false;
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            loaddulieu();
            anthongtin();

        }
        void loaddulieu()
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
        private void rdbtdoanhthuthang_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin();
            if (rdbtdoanhthuthang.Checked == true)
            {
                thang.Enabled = true;
                nam.Enabled = true;
                tgiandau.Enabled = false;
                tgiancuoi.Enabled = false;
            }
        }

        private void rdbtdoanhthuthucong_CheckedChanged(object sender, EventArgs e)
        {
            anthongtin();
            if (rdbtdoanhthuthucong.Checked == true)
            {
                thang.Enabled = false;
                nam.Enabled = false;
                tgiandau.Enabled = true;
                tgiancuoi.Enabled = true;
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnloc_Click(object sender, EventArgs e)
        {

            if (rdbtdoanhthuthang.Checked == true)
            {
                if (thang.Text.Equals("") || nam.Value.ToString().Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ tháng, năm để thống kê!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (thang.Text.Equals("Tất cả"))
                    {
                        dataGridView1.DataSource = cn.Loadthongke3(int.Parse(nam.Value.ToString()));
                        MessageBox.Show("Thống kê thành công");
                    }
                    else if (cn.locthangnam1(int.Parse(thang.Text), int.Parse(nam.Value.ToString())))
                    {
                        dataGridView1.DataSource = cn.Loadthongke1(int.Parse(thang.Text), int.Parse(nam.Value.ToString()));
                        MessageBox.Show("Thống kê thành công");
                    }
                    else
                        MessageBox.Show("Không thành công 1");
                }
            }
            else if (rdbtdoanhthuthucong.Checked == true)
            {
                if (cn.locthangnam2(tgiandau.Text, tgiancuoi.Text))
                {
                    dataGridView1.DataSource = cn.Loadthongke2(tgiandau.Text, tgiancuoi.Text);
                    MessageBox.Show("Thống kê thành công");
                }

                else
                    MessageBox.Show("Không thành công 2");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thích hợp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
