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
    public partial class frmkh : Form
    {
        ketnoisql cn = new ketnoisql();
        //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123");
        public frmkh()
        {
            InitializeComponent();
        }

        private void frmkh_Load(object sender, EventArgs e)
        {
            hienthikhachhang();

        }

        public void hienthikhachhang()
        {
            datakh.DataSource = null;
            DataTable tb = cn.ExecuteQuery("select * from KHACHHANG");
            datakh.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string sqlselect = "";
            //SqlCommand cmd = new SqlCommand(sqlselect, sqlcon);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datakh.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txttenkh.Text.Length < 1||txtsdt.Text.Length<1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.themkh(txttenkh.Text,txtsdt.Text,cbgioitinh.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienthikhachhang();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
                return;
            //errorProvider1.Clear();
            //try
            //{
            //    if (txtmakh.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhân viên");
            //        txtmakh.Focus();
            //        return;
            //    }
            //    //if (check_tenkh_2(txttenkh.Text.Trim()) == true)
            //    //{
            //    //    MessageBox.Show("tên sai");
            //    //}
            //    //else
            //    if (check_tenkh(txttenkh.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string inserts = "insert into khachhang values (N'" + txttenkh.Text + "', N'" + txtsdt.Text + "', N'" + cbgioitinh.Text + "')";
            //        SqlCommand cmd = new SqlCommand(inserts, sqlcon);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthikhachhang();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng kiểm tra lại tên khách hàng");
            //        errorProvider1.SetError(txttenkh, "Tên phải có họ và tên, viết hoa chữ cái đầu");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void datakh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = datakh.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = datakh.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = datakh.CurrentRow.Cells[2].Value.ToString();
            cbgioitinh.Text = datakh.CurrentRow.Cells[3].Value.ToString();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            txttkkh.Clear();
            hienthikhachhang();
        }

        private void bttk_kh_Click(object sender, EventArgs e)
        {
            DataTable tb = cn.ExecuteQuery("select * from KHACHHANG where TENKH like N'%" + txttkkh.Text + "%'");
            datakh.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string stim = "select * from khachhang";
            //SqlCommand cmd = new SqlCommand(stim, sqlcon);
            //cmd.ExecuteNonQuery();
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datakh.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.suakh(int.Parse(txtmakh.Text),txttenkh.Text,txtsdt.Text,cbgioitinh.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthikhachhang();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmakh.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã khách hàng");
            //        txtmakh.Focus();
            //        return;
            //    }
            //    if (check_tenkh(txttenkh.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string updates = "update khachhang set tenkh = @tenkh, sdt = @sdt,  gioitinh = @gioitinh where makh = @makh";
            //        SqlCommand cmd = new SqlCommand(updates, sqlcon);
            //        cmd.Parameters.AddWithValue("tenkh", txttenkh.Text);
            //        cmd.Parameters.AddWithValue("sdt", txtsdt.Text);
            //        cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
            //        cmd.Parameters.AddWithValue("makh", txtmakh.Text);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthikhachhang();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng kiểm tra lại tên khách hàng");
            //        errorProvider1.SetError(txttenkh, "Tên phải có họ và tên, viết hoa chữ cái đầu");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool check_tenkh(string ten)
        {
            //Kiểm tra tên có phải gồm nhiều hơn hai từ không 
            if (ten.IndexOf(" ") == -1)
                return false;
            //Kiểm tra ký tự đầu tiên có phải viết hoa hay không
            string[] arr = ten.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i][0]) == true)
                    return false;
            }
            //for (int j = 0; 1 < arr.Length; j++)
            //{
            //    if (char.IsUpper(arr[j][0]) == true)
            //        return false;
            //}
            return true;
            //string strRegex = @"^(\p{L}+\s?)+$";
            //Regex re = new Regex(strRegex);
            //if (re.IsMatch(ten))
            //    return (false);
            //else
            //    return (true);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cn.ktramaKH_Khoangoai(int.Parse(txtmakh.Text)) == false)
                    MessageBox.Show("Thông tin khách hàng đã được sử dụng, không thể xóa");
                else
                {
                    if (cn.xoakh(int.Parse(txtmakh.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        hienthikhachhang();
                    }
                    else
                        MessageBox.Show("Xóa thất bại");
                }
            }
            else
                return;
                //try
                //{
                //    //xóa khách hàng
                //    if (ktmakh_hd(txtmakh.Text) == true)
                //    {
                //        string deletes = "delete from khachhang where makh = @ma";
                //        SqlCommand cmd = new SqlCommand(deletes, sqlcon);
                //        cmd.Parameters.AddWithValue("ma", txtmakh.Text);
                //        cmd.ExecuteNonQuery();
                //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                //        hienthikhachhang();
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

            //public bool ktmakh_hd(string pma)
            //{
            //    sqlcon.Open();
            //    string selectstring = "select * from hoadon where makh = '" + pma + "'";
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

        //public static bool check_tenkh_2(string ten)
        //{
        //    string strRegex = @"^(?=.*?[#?!@$%^&*-])$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(ten))
        //        return (true);
        //    else
        //        return (false);
        //}
    }
}
