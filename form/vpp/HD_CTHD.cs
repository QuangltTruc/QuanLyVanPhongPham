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
    public partial class HD_CTHD : Form
    {
        ketnoisql cn = new ketnoisql();
        public HD_CTHD()
        {
            InitializeComponent();
        }
        void combobox()
        {
            cbmanv.Items.Clear();

            List<string> dsnv = cn.LoadTenNV();

            foreach (string item in dsnv)
            {
                cbmanv.Items.Add(item);
            }

            cbtenkh.Items.Clear();

            List<string> dskh = cn.LoadTenKH_full();

            foreach (string item in dskh)
            {
                cbtenkh.Items.Add(item);
            }

            cbtensp.Items.Clear();

            List<string> dssp = cn.LoadSP_all();

            foreach (string item in dssp)
            {
                cbtensp.Items.Add(item);
            }
        }
        void loaddulieu()
        {
            DataTable table1 = cn.ExecuteQuery("SELECT * FROM HOADON");
            dtgvhd.DataSource = table1;
            DataTable table2 = cn.ExecuteQuery("SELECT * FROM CHITIETHD");
            dtgvcthd.DataSource = table2;
        }
        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            if (cn.ktramaHD_Khoangoai(int.Parse(txtmahd.Text))==false)
                MessageBox.Show("Xóa không được vì dính chi tiết hóa đơn!");
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (cn.xoahd(int.Parse(txtmahd.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        loaddulieu();
                    }
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
                else
                    return;
            }
        }

        private void HD_CTHD_Load(object sender, EventArgs e)
        {
            loaddulieu();
            combobox();
        }

        private void btninhd_Click(object sender, EventArgs e)
        {
            hoadonbanhang a = new hoadonbanhang();
            if (txtmahd.Text.Length < 1)
                MessageBox.Show("Không có mã hóa đơn để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                a.mahd = int.Parse(txtmahd.Text);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void dtgvhd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmahd.Text = dtgvhd.CurrentRow.Cells[0].Value.ToString();
            cbmanv.Text = cn.laytennv(int.Parse(dtgvhd.CurrentRow.Cells[2].Value.ToString()));
            cbtenkh.Text = cn.laytenkh(int.Parse(dtgvhd.CurrentRow.Cells[1].Value.ToString()));
            dateTimePicker1.Text = dtgvhd.CurrentRow.Cells[3].Value.ToString();
            txtgiamgia.Text = dtgvhd.CurrentRow.Cells[4].Value.ToString();
            txttongtien.Text = dtgvhd.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btnluucthd_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btnsuahoadon_Click(object sender, EventArgs e)
        {
            //if()
            int y = cn.laymakh2(cbtenkh.Text);
            int x = cn.laymanv_ten(cbmanv.Text);
            if (cn.suahd(int.Parse(txtmahd.Text), y, x, dateTimePicker1.Value.ToShortDateString(), decimal.Parse(txtgiamgia.Text), decimal.Parse(txttongtien.Text)))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
        }

        private void btnsuacthd_Click(object sender, EventArgs e)
        {
            int x = cn.laymasanpham(cbtensp.Text);
            if (cn.suacthd(int.Parse(txtmacthd.Text),x,int.Parse(txtsoluong.Text)))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
        }

        private void btnxoacthd_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.xoacthd(int.Parse(txtmahd.Text)))
                {
                    if (cn.capnhattienhoadon())
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void dtgvcthd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmacthd.Text = dtgvcthd.CurrentRow.Cells[0].Value.ToString();
            txtmahd_cthd.Text = dtgvcthd.CurrentRow.Cells[1].Value.ToString();
            cbtensp.Text = cn.laytensp(int.Parse(dtgvcthd.CurrentRow.Cells[2].Value.ToString()));
            txtsoluong.Text = dtgvcthd.CurrentRow.Cells[3].Value.ToString();
            txtthanhtien.Text = dtgvcthd.CurrentRow.Cells[4].Value.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvcthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
