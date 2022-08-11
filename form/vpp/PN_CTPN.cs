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
    public partial class PN_CTPN : Form
    {
        ketnoisql cn = new ketnoisql();
        public PN_CTPN()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            DataTable table1 = cn.ExecuteQuery("SELECT * FROM PHIEUNHAP");
            dtgvhd.DataSource = table1;
            DataTable table2 = cn.ExecuteQuery("SELECT * FROM CHITIETPHIEUNHAP");
            dtgvcthd.DataSource = table2;
        }
        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text.Length < 1)
                MessageBox.Show("Không tìm thấy mã phiếu nhập");
            else
            {
                if(cn.ktramaPN_Khoangoai(int.Parse(txtmahd.Text))==false)
                    MessageBox.Show("Không xóa được vì mã phiếu nhập này đã được dùng");
                else
                {
                    if (cn.xoapn(int.Parse(txtmahd.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        loaddata();
                    }
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnsuahoadon_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text.Length < 1)
                MessageBox.Show("Không tìm thấy mã phiếu nhập");
            else
            {
                int x = cn.laymancc(cbtenncc.Text);
                if (cn.suapn(int.Parse(txtmahd.Text), x))
                {
                    MessageBox.Show("Sửa thành công!");
                    loaddata();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnxoacthd_Click(object sender, EventArgs e)
        {
            if (txtmacthd.Text.Length < 1)
                MessageBox.Show("Không tìm thấy mã chi tiết phiếu nhập");
            else
            {
                if (cn.xoactpn(int.Parse(txtmacthd.Text)))
                {
                    if (cn.capnhattienphieunhap())
                    {
                        MessageBox.Show("Xóa thành công!");
                        loaddata();
                    }
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnsuacthd_Click(object sender, EventArgs e)
        {
            if (txtmacthd.Text.Length < 1)
                MessageBox.Show("Không tìm thấy mã chi tiết phiếu nhập");
            else
            {
                if (cn.suactpn(int.Parse(txtmacthd.Text), decimal.Parse(txtthanhtien.Text)))
                {
                    if (cn.capnhattienphieunhap())
                    {
                        MessageBox.Show("Sửa thành công!");
                        loaddata();
                    }
 
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnluucthd_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void PN_CTPN_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
