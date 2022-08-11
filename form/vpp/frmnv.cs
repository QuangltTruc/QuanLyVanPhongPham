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
using System.Text.RegularExpressions;

namespace vpp
{
    public partial class frmnv : Form
    {
        ketnoisql cn = new ketnoisql();
        //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123");
        public frmnv()
        {
            InitializeComponent();
        }

        private void frmnv_Load(object sender, EventArgs e)
        {
            hienthinhanvien();
        }

        public void hienthinhanvien()
        {
            datanv.DataSource = null;
            DataTable tb = cn.ExecuteQuery("select * from NHANVIEN");
            datanv.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string sqlselect = "";
            //SqlCommand cmd = new SqlCommand(sqlselect, sqlcon);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datanv.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void datanv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = datanv.CurrentRow.Cells[0].Value.ToString();
            txttennv.Text = datanv.CurrentRow.Cells[1].Value.ToString();
            cbgioitinh.Text = datanv.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = datanv.CurrentRow.Cells[3].Value.ToString();
            txtsdt.Text = datanv.CurrentRow.Cells[4].Value.ToString();
            cbchucvu.Text = datanv.CurrentRow.Cells[5].Value.ToString();
            txttendn.Text = datanv.CurrentRow.Cells[6].Value.ToString();
            txtmk.Text = datanv.CurrentRow.Cells[7].Value.ToString();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttk_nv_Click(object sender, EventArgs e)
        {
            DataTable tb = cn.ExecuteQuery("select * from NHANVIEN where TENNV like N'%" + txttknv.Text + "%'");
            datanv.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string stim = "select * from nhanvien";
            //SqlCommand cmd = new SqlCommand(stim, sqlcon);
            //cmd.ExecuteNonQuery();
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datanv.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            txttknv.Clear();
            hienthinhanvien();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cn.ktramaNV_Khoangoai_HD(int.Parse(txtmanv.Text))==false||cn.ktramaNV_Khoangoai_PN(int.Parse(txtmanv.Text)))
                    MessageBox.Show("Thông tin nhân viên đã được sử dụng, không thể xóa");
                else
                {
                    if (cn.xoanv(int.Parse(txtmanv.Text)))
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
                //try
                //{
                //    //xóa khách hàng
                //    if ((ktmanv_hd(txtmanv.Text) == true) || (ktmanv_pn(txtmanv.Text) == true))
                //    {
                //        string deletes = "delete from nhanvien where manv = @ma";
                //        SqlCommand cmd = new SqlCommand(deletes, sqlcon);
                //        cmd.Parameters.AddWithValue("ma", txtmanv.Text);
                //        cmd.ExecuteNonQuery();
                //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                //        hienthinhanvien();
                //        MessageBox.Show("Thành công");
                //    }
                //    else
                //    {
                //        
                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Thất bại");
                //}
            }
        }

            //public bool ktmanv_hd(string pma)
            //{
            //    sqlcon.Open();
            //    string selectstring = "select * from hoadon where manv = '" + pma + "'";
            //    SqlCommand cmd = new SqlCommand(selectstring, sqlcon);
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    if (rd.HasRows)
            //    {
            //        rd.Close();
            //        sqlcon.Close();
            //        return false;
            //    }
            //    else
            //    {
            //        rd.Close();
            //        sqlcon.Close();
            //        return true;
            //    }
            //}

            //public bool ktmanv_pn(string pma)
            //{
            //    sqlcon.Open();
            //    string selectstring = "select * from phieunhap where manv = '" + pma + "'";
            //    SqlCommand cmd = new SqlCommand(selectstring, sqlcon);
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    if (rd.HasRows)
            //    {
            //        rd.Close();
            //        sqlcon.Close();
            //        return false;
            //    }
            //    else
            //    {
            //        rd.Close();
            //        sqlcon.Close();
            //        return true;
            //    }
            //}

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhân viên này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.suanv(int.Parse(txtmanv.Text), txttennv.Text, cbgioitinh.Text,txtdiachi.Text,txtsdt.Text, int.Parse(cbchucvu.Text), txttendn.Text,txtmk.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthinhanvien();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
                return;
            //errorProvider1.Clear();
            //try
            //{
            //    if (txtmanv.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhân viên");
            //        txtmanv.Focus();
            //        return;
            //    }
            //    if (check_password(txtmk.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string updates = "update nhanvien set tennv = @tennv, gioitinh = @gioitinh, diachi = @diachi, sdt = @sdt, chucvu = @chucvu, tendn = @tendn, mk = @mk where manv = @manv";
            //        SqlCommand cmd = new SqlCommand(updates, sqlcon);
            //        cmd.Parameters.AddWithValue("tennv", txttennv.Text);
            //        cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
            //        cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
            //        cmd.Parameters.AddWithValue("sdt", txtsdt.Text);
            //        cmd.Parameters.AddWithValue("chucvu", cbchucvu.Text);
            //        cmd.Parameters.AddWithValue("tendn", txttendn.Text);
            //        cmd.Parameters.AddWithValue("mk", txtmk.Text);
            //        cmd.Parameters.AddWithValue("manv", txtmanv.Text);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthinhanvien();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng thử laị với một mật khẩu khác");
            //        errorProvider1.SetError(txtmk, "Mật khẩu phải tối thiểu tám ký tự, ít nhất một chữ cái viết hoa, một chữ cái viết thường và một số");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txttennv.Text.Length < 1||txtdiachi.Text.Length<1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm nhân viên?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.themnv(txttennv.Text,cbgioitinh.Text,txtdiachi.Text,txtsdt.Text,int.Parse(cbchucvu.Text),txttendn.Text,txtmk.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienthinhanvien();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
                return;
            //errorProvider1.Clear();
            //try
            //{
            //    if (txtmanv.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhân viên");
            //        txtmanv.Focus();
            //        return;
            //    }
            //    if (check_password(txtmk.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string inserts = "insert into nhanvien values (N'" + txttennv.Text + "', N'" + cbgioitinh.Text + "', N'" + txtdiachi.Text + "','" + txtsdt.Text + "','" + cbchucvu.Text + "','" + txttendn.Text + "','" + txtmk.Text + "')";
            //        SqlCommand cmd = new SqlCommand(inserts, sqlcon);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthinhanvien();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng thử lại với một mật khẩu khác");
            //        errorProvider1.SetError(txtmk, "Mật khẩu phải tối thiểu tám ký tự, ít nhất một chữ cái viết hoa, một chữ cái viết thường và một số");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        public static bool check_password(string mk)
        {
            string strRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(mk))
                return (true);
            else
                return (false);
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //public static bool check_tennv(string ten)
        //{
        //    string strRegex = @"^(?=.*\d)(?=.*[@$!%*?&]$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(ten))
        //        return (false);
        //    else
        //        return (true);
        //}
    }
}
