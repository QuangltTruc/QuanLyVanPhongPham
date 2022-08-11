using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vpp
{
    public partial class frmdangnhap : Form
    {
        ketnoisql cn = new ketnoisql();
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btdn_dn_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123"); 
            //string sdn = "select * from nhanvien where tendn = '" + txttk_dn.Text + "' and mk = '" + txtmk_dn.Text + "'";
            //SqlDataAdapter da = new SqlDataAdapter(sdn, sqlcon);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frmmain formmain = new frmmain(dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString());
            //    formmain.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng kiểm tra lại thông tin tài khoản!");
            //}
            int lays = cn.dangnhap(txttk_dn.Text, txtmk_dn.Text);
            if (lays == 1)
            {
                frmmain a = new frmmain();
                a.manv = cn.laymanv(txttk_dn.Text, txtmk_dn.Text);
                a.layso = lays;
                this.Hide();
                a.ShowDialog();
                this.Show();

            }
            else if (lays == 0)
            {
                frmmain a = new frmmain();
                a.manv = cn.laymanv(txttk_dn.Text, txtmk_dn.Text);
                a.layso = lays;
                this.Hide();
                a.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void check_hienthipass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienthipass.Checked)
            {
                txtmk_dn.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk_dn.UseSystemPasswordChar = true;
            }
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btthodn_dn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
