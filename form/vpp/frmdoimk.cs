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
    public partial class frmdoimk : Form
    {
        public int manv;
        string tendn = "";
        string mk = "";
        ketnoisql cn = new ketnoisql();
       // SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123");
        public frmdoimk()
        {
            InitializeComponent();
        }

        public frmdoimk(string tendn, string mk)
        {
            InitializeComponent();
            this.tendn = tendn;
            this.mk = mk;
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {
            txtmkcu.Focus();
            bts_mkc.Hide();
            bth_mkc.Hide();
            bth_mkm.Hide();
            bth_nl.Hide();
            bts_mkm.Hide();
            bts_nl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter ("select count (*) from taikhoan where tendangnhap = '"+txttendn.Text+"' and matkhau = '"+txtmkcu.Text+"'", sqlcon);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            errorProvider1.Clear();
            if ((txtmkcu.Text == string.Empty) || (txtmkmoi.Text == string.Empty) || (txtnhaplai.Text == string.Empty))
            {
                MessageBox.Show("vui long nhap day du thong tin", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtnhaplai.Text.Equals(txtmkmoi.Text)) //neu da nhap day du thong tin roi thi thuc hien tiep
            {
                if (cn.doimk(manv, txtmkmoi.Text))
                    MessageBox.Show("Đổi mật khẩu thành công");
                else
                    MessageBox.Show("Đổi mật khẩu thất bại");
                //if (kttk(txttendn.Text) == false) //neu tai khoan ton tai thi thuc hien tiep
                //{
                //if (dt.Rows[0][0].ToString() == "1") //neu tai khoan va mat khau trung nhau thi thuc hien tiep

                //if (txtmkcu.Text == mk)
                //{
                //    if (txtmkmoi.Text == txtnhaplai.Text) //neu mat khau moi va nhap lai trung nhau thi thuc hien tiep
                //    {
                //        SqlDataAdapter da1 = new SqlDataAdapter("update nhanvien set mk = '" + txtmkmoi.Text + "' where tendn = '" + tendn + "' and mk = '" + mk + "'", sqlcon);
                //        DataTable dt1 = new DataTable();
                //        da1.Fill(dt1);
                //        MessageBox.Show("doi mat khau thanh cong", "thong bao");
                //    }
                //    else //xuat hien errorprovider khi mat khau moi va nhap lai khong trung nhau
                //    {
                //        errorProvider1.SetError(txtnhaplai, "nhap lai sai!");
                //    }
                //}
                //else //mat khau cu sai
                //{
                //    //errorProvider1.SetError(txttendn, "nguoi dung nay khong ton tai");
                //    errorProvider1.SetError(txtmkcu, "mat khau cu sai");
                //    //MessageBox.Show("loi");
                //}

                //}
                //else //ten nguoi dung khong ton tai
                //{
                //    errorProvider1.SetError(txttendn, "nguoi dung nay khong ton tai");
                //}
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng mật khẩu mới!");
            }

            bts_mkc.Hide();
            bth_mkc.Hide();
            bth_mkm.Hide();
            bth_nl.Hide();
            bts_mkm.Hide();
            bts_nl.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmkcu.Clear();
            txtmkmoi.Clear();
            txtnhaplai.Clear();
            txtmkcu.Focus();
            bts_mkc.Hide();
            bth_mkc.Hide();
            bth_mkm.Hide();
            bth_nl.Hide();
            bts_mkm.Hide();
            bts_nl.Hide();
        }

        private void txtmkcu_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bts_mkc.BringToFront();
            bts_mkc.Show();
            bth_mkc.Show();
            bth_mkm.Hide();
            bth_nl.Hide();
            bts_mkm.Hide();
            bts_nl.Hide();
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bts_mkm.BringToFront();
            bts_mkm.Show();
            bth_mkm.Show();
            bts_mkc.Hide();
            bth_mkc.Hide();
            bth_nl.Hide();
            bts_nl.Hide();
        }

        private void txtnhaplai_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bts_nl.BringToFront();
            bts_nl.Show();
            bth_nl.Show();
            bts_mkc.Hide();
            bth_mkc.Hide();
            bts_mkm.Hide();
            bth_mkm.Hide();
        }

        private void bts_mkc_Click(object sender, EventArgs e)
        {
            if (txtmkcu.PasswordChar == '*')
            {
                bth_mkc.BringToFront();
                txtmkcu.PasswordChar = '\0';
            }
        }

        private void bth_mkc_Click(object sender, EventArgs e)
        {
            if (txtmkcu.PasswordChar == '\0')
            {
                bts_mkc.BringToFront();
                txtmkcu.PasswordChar = '*';
            }
        }

        private void bts_mkm_Click(object sender, EventArgs e)
        {
            if (txtnhaplai.PasswordChar == '*')
            {
                bth_nl.BringToFront();
                txtnhaplai.PasswordChar = '\0';
            }
        }

        private void bth_mkm_Click(object sender, EventArgs e)
        {
            if (txtmkmoi.PasswordChar == '\0')
            {
                bts_mkm.BringToFront();
                txtmkmoi.PasswordChar = '*';
            }
        }

        private void bts_nl_Click(object sender, EventArgs e)
        {
            if (txtmkmoi.PasswordChar == '*')
            {
                bth_mkm.BringToFront();
                txtmkmoi.PasswordChar = '\0';
            }
        }

        private void bth_nl_Click(object sender, EventArgs e)
        {
            if (txtnhaplai.PasswordChar == '\0')
            {
                bts_nl.BringToFront();
                txtnhaplai.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
