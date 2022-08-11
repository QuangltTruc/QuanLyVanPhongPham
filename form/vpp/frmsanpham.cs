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
    public partial class frmsanpham : Form
    {
        //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = nvkh; user id = sa; password = 123");
        ketnoisql cn = new ketnoisql();
        public frmsanpham()
        {
            InitializeComponent();
            txttk.ForeColor = Color.LightGray;
            txttk.Text = "Nhập vào tên mà bạn cần tìm...";

        }

        public void loadanh(PictureBox a)
        {
            if (datasanpham.CurrentRow.Cells[5].Value.ToString().Length < 1)
                return;
            else
            {
                string ha = datasanpham.CurrentRow.Cells[5].Value.ToString();
                if (ha == null)
                    a.Hide();
                else
                    a.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ha);
            }

        }

        private void frmsanpham_Load(object sender, EventArgs e)
        {
            loadmaloai();
            hienthiloai();
            hienthisanpham();
            rdsp.Checked = true;
        }

        public void hienthiloai()
        {
            dataloai.DataSource = null;
            DataTable tb = cn.ExecuteQuery("select * from LOAISP");
            dataloai.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string sqlselect = "select * from loaisp";
            //SqlCommand cmd = new SqlCommand(sqlselect, sqlcon);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataloai.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        public void hienthisanpham()
        {
            datasanpham.DataSource = null;
            DataTable tb = cn.ExecuteQuery("select * from SANPHAM");
            datasanpham.DataSource = tb;
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string sqlselect = "select * from sanpham where maloai ='" + txtmaloai.Text + "'";
            //SqlCommand cmd = new SqlCommand(sqlselect, sqlcon);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //datasanpham.DataSource = dt;
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void dataloai_SelectionChanged(object sender, EventArgs e)
        {
            //{
            //    int i = dataloai.CurrentRow.Index;
            //    txtmaloai.Text = txtmaloai.Text = dataloai.Rows[i].Cells[0].Value.ToString().Trim();
            //    txttenloai.Text = dataloai.Rows[i].Cells[1].Value.ToString().Trim();
            //}

            //hienthisanpham();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttk_Enter(object sender, EventArgs e)
        {
            if (txttk.Text == "Nhập vào tên mà bạn cần tìm...")
            {
                txttk.Text = "";
                txttk.ForeColor = Color.Black;
            }
        }

        private void txttk_Leave(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                txttk.Text = "Nhập vào tên mà bạn cần tìm...";
                txttk.ForeColor = Color.Gray;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            txttk.Clear();
            hienthiloai();
            hienthisanpham();
        }

        private void btsualoai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa loại sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.sualoaisp(int.Parse(txtmaloai.Text),txttenloai.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthiloai();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmaloai.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã loại");
            //        txtmaloai.Focus();
            //        return;
            //    }
            //    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //    string updates = "update loaisp set tenloaisp = @tenloai where maloaisp = @maloai";
            //    SqlCommand cmd = new SqlCommand(updates, sqlcon);
            //    cmd.Parameters.AddWithValue("tenloai", txttenloai.Text);
            //    cmd.Parameters.AddWithValue("maloai", txtmaloai.Text);
            //    cmd.ExecuteNonQuery();
            //    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //    hienthiloai();
            //    MessageBox.Show("Thành công");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void loadmaloai()
        {
            cbmaloai.Items.Clear();

            List<string> ds = cn.LoadLoaiSP();

            foreach (string item in ds)
            {
                cbmaloai.Items.Add(item);
            }
            //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //string selectstring = "select * from loaisp";
            //SqlCommand cmd = new SqlCommand(selectstring, sqlcon);
            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    cbmaloai.Items.Add(rd["maloaisp"].ToString());
            //}
            //rd.Close();
            //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }

        private void btthem_loai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm loại sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.themloaisp(txttenloai.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienthiloai();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
                return;

            //try
            //{
            //    if (txtmaloai.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã loại");
            //        txtmaloai.Focus();
            //        return;
            //    }
            //    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //    string inserts = "insert into loaisp values (N'" + txttenloai.Text + "')";
            //    SqlCommand cmd = new SqlCommand(inserts, sqlcon);
            //    cmd.ExecuteNonQuery();
            //    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //    hienthiloai();
            //    loadmaloai();
            //    MessageBox.Show("Thành công");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void datasanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = datasanpham.CurrentRow.Index;
            //txtmasp.Text = datasanpham.Rows[i].Cells[0].Value.ToString();
            //txttensp.Text = datasanpham.Rows[i].Cells[1].Value.ToString();
            //cbmaloai.Text = datasanpham.Rows[i].Cells[2].Value.ToString();
            //txtdongia.Text = datasanpham.Rows[i].Cells[3].Value.ToString();
            //txtsoluong.Text = datasanpham.Rows[i].Cells[4].Value.ToString();
            //txthinhanh.Text = datasanpham.Rows[i].Cells[5].Value.ToString();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            if (rdloai.Checked == true)
            {
                DataTable tb = cn.ExecuteQuery("select * from LOAISP where TENLOAISP like N'%" + txttk.Text + "%'");
                if(tb.Rows.Count<1)
                    MessageBox.Show("Không có loại sản phẩm này!");
                else
                    dataloai.DataSource = tb;
                //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                //string stim = "select * from loaisp where tenloaisp like N'%" + txttk.Text + "%'";
                //SqlCommand cmd = new SqlCommand(stim, sqlcon);
                //cmd.ExecuteNonQuery();
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //dataloai.DataSource = dt;
                //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            if (rdsp.Checked == true)
            {
                DataTable tb = cn.ExecuteQuery("select * from SANPHAM where TENSP like N'%" + txttk.Text + "%'");
                if (tb.Rows.Count < 1)
                    MessageBox.Show("Không có loại sản phẩm này!");
                else
                    datasanpham.DataSource = tb;
                //if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                //string stim = "select * from sanpham where tensp like N'%" + txttk.Text + "%'";
                //SqlCommand cmd = new SqlCommand(stim, sqlcon);
                //cmd.ExecuteNonQuery();
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //datasanpham.DataSource = dt;
                //if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        private void btsua_sp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa loại sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int x = cn.laymaloaisanpham(cbmaloai.Text);
                if (cn.suasp(int.Parse(txtmasp.Text),txttensp.Text,x,decimal.Parse(txtdongia.Text),int.Parse(txtsoluong.Text),txthinhanh.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthisanpham();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmasp.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            //        txtmasp.Focus();
            //        return;
            //    }
            //    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //    string updates = "update sanpham set tensp = @tensp, maloai = @maloai, dongia = @dongia, soluongton = @soluongton, hinhanh = @hinhanh where masp = @masp";
            //    SqlCommand cmd = new SqlCommand(updates, sqlcon);
            //    cmd.Parameters.AddWithValue("tensp", txttensp.Text);
            //    cmd.Parameters.AddWithValue("maloai", cbmaloai.Text);
            //    cmd.Parameters.AddWithValue("dongia", txtdongia.Text);
            //    cmd.Parameters.AddWithValue("soluongton", txtsoluong.Text);
            //    cmd.Parameters.AddWithValue("hinhanh", txthinhanh.Text);
            //    cmd.Parameters.AddWithValue("masp", txtmasp.Text);
            //    cmd.ExecuteNonQuery();
            //    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //    hienthisanpham();
            //    MessageBox.Show("Thành công");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void btthem_sp_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thêm sản phẩm mới?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int x = cn.laymaloaisanpham(cbmaloai.Text);
                if (cn.themsp(txttensp.Text,x ,decimal.Parse(txtdongia.Text),int.Parse(txtsoluong.Text),txthinhanh.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienthisanpham();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
                return;
            //try
            //{
            //    if (txtmasp.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã nhân viên");
            //        txtmasp.Focus();
            //        return;
            //    }
            //    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            //    string inserts = "insert into sanpham values (N'" + txttensp.Text + "', '" + cbmaloai.Text + "', '" + txtdongia.Text + "', '" + txtsoluong.Text + "', '" + txthinhanh.Text + "')";
            //    SqlCommand cmd = new SqlCommand(inserts, sqlcon);
            //    cmd.ExecuteNonQuery();
            //    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //    hienthisanpham();
            //    MessageBox.Show("Thành công");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất bại", ex.Message);
            //}
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btxoa_sp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cn.ktramaSP_Khoangoai_HD(int.Parse(txtmasp.Text)) == false && cn.ktramaSP_Khoangoai_PN(int.Parse(txtmasp.Text)) == false)
                    MessageBox.Show("Thông tin sản phẩm đã được sử dụng, không thể xóa");
                else
                {
                    if (cn.xoasp(int.Parse(txtmasp.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        hienthisanpham();
                    }
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
            }
            else
                return;
            //if (MessageBox.Show("Bạn muốn xóa sản phẩm này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        //xóa sản phẩm
            //        if ((ktmasp_hd(txtmasp.Text) == true) || (ktmasp_pn(txtmasp.Text) == true))
            //        {
            //            string deletes = "delete from sanpham where masp = @ma";
            //            SqlCommand cmd = new SqlCommand(deletes, sqlcon);
            //            cmd.Parameters.AddWithValue("ma", txtmasp.Text);
            //            cmd.ExecuteNonQuery();
            //            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //            hienthisanpham();
            //            MessageBox.Show("Thành công");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thông tin sản phẩm đã được sử dụng, không thể xóa");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Thất bại");
            //    }
            //}
        }

        //public bool ktmasp_hd(string pma)
        //{
        //    sqlcon.Open();
        //    string selectstring = "select * from chitiethd where masp = '" + pma + "'";
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

        //public bool ktmasp_pn(string pma)
        //{
        //    sqlcon.Open();
        //    string selectstring = "select * from chitietphieunhap where masp = '" + pma + "'";
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

        private void btxoa_loai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa loại sản phẩm này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cn.ktramaloaiSP_Khoangoai(int.Parse(txtmaloai.Text)) == false)
                    MessageBox.Show("Thông tin loại sản phẩm đã được sử dụng, không thể xóa");
                else
                {
                    if (cn.xoaloaisp(int.Parse(txtmaloai.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        hienthiloai();
                    }
                    else
                        MessageBox.Show("Xóa thất bại!");
                }
            }
            else
                return;
            //if ()
            //{
            //    try
            //    {
            //        //xóa khách hàng
            //        if (ktmaloai_sp(txtmaloai.Text) == true)
            //        {
            //            string deletes = "delete from sanpham where maloai = @ma";
            //            SqlCommand cmd = new SqlCommand(deletes, sqlcon);
            //            cmd.Parameters.AddWithValue("ma", txtmaloai.Text);
            //            cmd.ExecuteNonQuery();
            //            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            //            hienthiloai();
            //            MessageBox.Show("Thành công");
            //        }
            //        else
            //        {
            //            
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Thất bại");
            //    }
            //}
        }

        //public bool ktmaloai_sp(string pma)
        //{
        //    sqlcon.Open();
        //    string selectstring = "select * from sanpham where maloai = '" + pma + "'";
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

        private void btchonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();
            opdl.Title = "Chọn ảnh";
            opdl.Filter= "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (opdl.ShowDialog() == DialogResult.OK)
            {
                ptloadanh.ImageLocation = opdl.FileName;
            }
            //openFileDialog1.ShowDialog();
            //string file = openFileDialog1.FileName;
            //if (string.IsNullOrEmpty(file))
            //    return;
            //txthinhanh.Text = file;
            //Image hinh = Image.FromFile(txthinhanh.Text);
            //ptloadanh.Image = hinh;
        }

        private void datasanpham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmasp.Text = datasanpham.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = datasanpham.CurrentRow.Cells[1].Value.ToString();
            cbmaloai.Text = cn.laytenloaisp(int.Parse(datasanpham.CurrentRow.Cells[2].Value.ToString()));
            txtdongia.Text = datasanpham.CurrentRow.Cells[3].Value.ToString();
            txtsoluong.Text = datasanpham.CurrentRow.Cells[4].Value.ToString();
            txthinhanh.Text = datasanpham.CurrentRow.Cells[5].Value.ToString();
            loadanh(ptloadanh);
        }

        private void dataloai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmaloai.Text = dataloai.CurrentRow.Cells[0].Value.ToString();
            txttenloai.Text = dataloai.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
