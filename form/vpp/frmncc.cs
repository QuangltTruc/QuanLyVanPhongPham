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
    public partial class frmncc : Form
    {
        ketnoisql cn = new ketnoisql();
        //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123");
        public frmncc()
        {
            InitializeComponent();
        }

        private void frmncc_Load(object sender, EventArgs e)
        {
            hienthincc();
        }

        public void hienthincc()
        {
            datancc.DataSource = null;
            DataTable tb = cn.ExecuteQuery("select * from NHACUNGCAP");
            datancc.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string sqlselect = "select * from nhacungcap";
            //SqlCommand cmd = new SqlCommand(sqlselect, sqlcon);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datancc.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void datancc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = datancc.CurrentRow.Cells[0].Value.ToString();
            txttenncc.Text = datancc.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = datancc.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = datancc.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = datancc.CurrentRow.Cells[4].Value.ToString();
        }

        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txttenncc.Text.Length < 1||txtemail.Text.Length<1||txtdiachi.Text.Length<1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm nhà cung cấp này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.themncc(txttenncc.Text, txtsdt.Text, txtemail.Text, txtdiachi.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienthincc();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmancc.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
            //        txtmancc.Focus();
            //        return;
            //    }
            //    if (isValidEmail(txtemail.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string inserts = "insert into nhacungcap values (N'" + txttenncc.Text + "', N'" + txtsdt.Text + "', '" + txtemail.Text + "', N'" + txtdiachi.Text + "')";
            //        SqlCommand cmd = new SqlCommand(inserts, sqlcon);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthincc();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng kiểm tra lại tài khoản Email đã nhập");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhà cung cấp này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.suancc(int.Parse(txtmancc.Text), txttenncc.Text, txtsdt.Text, txtemail.Text, txtdiachi.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthincc();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmancc.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
            //        txtmancc.Focus();
            //        return;
            //    }
            //    if (isValidEmail(txtemail.Text) == true)
            //    {
            //        if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //        string updates = "update nhacungcap set tenncc = @tenncc, sdt = @sdt,  email = @email, diachi = @diachi where mancc = @mancc";
            //        SqlCommand cmd = new SqlCommand(updates, sqlcon);
            //        cmd.Parameters.AddWithValue("tenncc", txttenncc.Text);
            //        cmd.Parameters.AddWithValue("sdt", txtsdt.Text);
            //        cmd.Parameters.AddWithValue("email", txtemail.Text);
            //        cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
            //        cmd.Parameters.AddWithValue("mancc", txtmancc.Text);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthincc();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng kiểm tra lại tài khoản Email đã nhập");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            txttkncc.Clear();
            hienthincc();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttk_nv_Click(object sender, EventArgs e)
        {
            DataTable tb = cn.ExecuteQuery("select * from NHACUNGCAP where TENNCC like N'%" + txttkncc.Text + "%'");
            datancc.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string stim = "";
            //SqlCommand cmd = new SqlCommand(stim, sqlcon);
            //cmd.ExecuteNonQuery();
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datancc.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhà cung cấp này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cn.ktramaNCC_Khoangoai(int.Parse(txtmancc.Text)) == false)
                    MessageBox.Show("Thông tin nhà cung cấp đã được sử dụng, không thể xóa");
                else
                {
                    if (cn.xoancc(int.Parse(txtmancc.Text)))
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
            }
            else
                return;
            //try
            //{
            //    //xóa khách hàng
            //    if (ktmancc_pn(txtmancc.Text) == true)
            //    {
            //        string deletes = "delete from nhacungcap where mancc = @ma";
            //        SqlCommand cmd = new SqlCommand(deletes, sqlcon);
            //        cmd.Parameters.AddWithValue("ma", txtmancc.Text);
            //        cmd.ExecuteNonQuery();
            //        if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //        hienthincc();
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thông tin nhà cung cấp đã được sử dụng, không thể xóa");
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Thất bại");
            //}
        }
    }

    //    public bool ktmancc_pn(string pma)
    //    {
    //        sqlcon.Open();
    //        string selectstring = "select * from nhacungcap where mancc = '" + pma + "'";
    //        SqlCommand cmd = new SqlCommand(selectstring, sqlcon);
    //        SqlDataReader rd = cmd.ExecuteReader();
    //        if (rd.HasRows)
    //        {
    //            rd.Close();
    //            sqlcon.Close();
    //            return false;
    //        }
    //        else
    //        {
    //            rd.Close();
    //            sqlcon.Close();
    //            return true;
    //        }
    //
}
