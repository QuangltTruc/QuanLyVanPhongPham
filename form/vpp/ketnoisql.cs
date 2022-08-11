using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace vpp
{
    class ketnoisql
    {
        //SqlConnection sqlcon = new SqlConnection("data source = DESKTOP-VK3147V\\EWCRUSH; initial catalog = QUANLY_VPP; user id = sa; password = 123");
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-P4VRIGC\\SERVER; Initial Catalog = QUANLY_VPP; User ID = sa; Password = 123");
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-P4VRIGC\\SERVER; Initial Catalog = QUANLY_VPP; User ID = sa; Password = 123"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);

                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        //=========================================================================================================================================================

        //======================= KHÁCH HÀNG =====================
        public DataTable Loadkh()
        {
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public string laytenkh(int makh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select TENKH from KHACHHANG  where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }

        public int timkh(string tenkh)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string caulenh = "select count(*) from KHACHHANG where TENKH like N'%" + tenkh + "%'";
            SqlCommand cmd = new SqlCommand(caulenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public List<string> LoadTenKH_full()
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select * from KHACHHANG";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENKH"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }
        }
        public List<string> LoadTenKH(string tenkh, string sdt)
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (tenkh.Length > 0 && sdt.Length < 1)
                {
                    string caulenh1 = "select * from KHACHHANG where TENKH like N'%" + tenkh + "%'";
                    SqlCommand cmd1 = new SqlCommand(caulenh1, conn);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {
                        string ketqua = rd1["TENKH"].ToString();
                        dskq.Add(ketqua);
                    }
                    rd1.Close();
                }
                else if (tenkh.Length < 1 && sdt.Length > 0)
                {
                    string caulenh2 = "select * from KHACHHANG where SDT='" + sdt + "'";
                    SqlCommand cmd2 = new SqlCommand(caulenh2, conn);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    while (rd2.Read())
                    {
                        string ketqua = rd2["TENKH"].ToString();
                        dskq.Add(ketqua);
                    }
                    rd2.Close();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }
        }
        public bool themkh(string tenkh, string sdt, string gioitinh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into KHACHHANG values(N'" + tenkh + "','" + sdt + "',N'" + gioitinh + "')";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoakh(int makh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from KHACHHANG where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suakh(int makh, string tenkh, string sdt, string gioitinh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update KHACHHANG set TENKH = N'" + tenkh + "', SDT='" + sdt + "', GIOITINH=N'" + gioitinh + "'  where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int laymakh(string tenkh,string sdt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MAKH from KHACHHANG where TENKH=N'" + tenkh + "' and SDT='" + sdt + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymakh = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymakh;
            }
            catch
            {
                return -1;
            }
        }
        public int laymakh2(string tenkh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MAKH from KHACHHANG where TENKH like N'" + tenkh + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymakh = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymakh;
            }
            catch
            {
                return -1;
            }
        }
        //lấy thông tin khách hàng từ khách hàng cũ họ tên và số điện thoại
        public string laysdt(int makh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select SDT from KHACHHANG where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laysdt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laysdt;
            }
            catch
            {
                return "";
            }
        }
        public string laygioitinh(int makh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select GIOITINH from KHACHHANG where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public bool ktramaKH_Khoangoai(int makh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from HOADON where MAKH=" + makh;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        //=========================================================================================================================================================
        //======================= NHÂN VIÊN =====================
        public DataTable Loadnv()
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public int dangnhap(string tendn, string mk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh1 = "select count(*) from NHANVIEN where TENDN='" + tendn + "' and MK='" + mk + "'";
                SqlCommand cmd = new SqlCommand(caulenh1, conn);
                int kq1 = (int)cmd.ExecuteScalar();
                string caulenh2 = "select count(*) from NHANVIEN where TENDN='" + tendn + "' and MK='" + mk + "' and CHUCVU=1";
                SqlCommand cmmd = new SqlCommand(caulenh2, conn);
                int kq2 = (int)cmmd.ExecuteScalar();
                string caulenh3 = "select count(*) from NHANVIEN where TENDN='" + tendn + "' and MK='" + mk + "' and CHUCVU=0";
                SqlCommand commd = new SqlCommand(caulenh3, conn);
                int kq3 = (int)commd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq1 >= 1)
                {
                    if (kq2 >= 1)
                        return 1;
                    else if (kq3 >= 1)
                        return 0;
                    else
                        return -1;
                }
                else
                    return -1;
            }
            catch
            {
                return -1;
            }
        }
        public List<string> LoadTenNV()
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string caulenh = "select * from NHANVIEN";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENNV"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }
        }
            public bool themnv(string tennv, string gioitinh, string diachi,string sdt,int cv,string tendn,string mk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into NHANVIEN values(N'" + tennv + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "'," + cv + ",'" + tendn + "','" + mk + "')";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoanv(int manv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from NHANVIEN where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suanv(int manv, string tennv, string gioitinh, string diachi, string sdt, int cv, string tendn, string mk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update NHANVIEN set TENNV = N'" + tennv + "', GIOITINH=N'" + gioitinh + "', DIACHI=N'" + diachi + "', SDT='" + sdt + "', CV=" + cv + ", TENDN='" + tendn + "', MK='" + mk + "'  where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int laymanv(string tendangnhap, string mk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MANV from NHANVIEN  where TENDN='" + tendangnhap + "' and MK='" + mk + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymanv = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymanv;
            }
            catch
            {
                return -1;
            }
        }
        public int laymanv_ten(string tennv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MANV from NHANVIEN  where TENNV=N'" + tennv + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymanv = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymanv;
            }
            catch
            {
                return -1;
            }
        }
        public string laytennv(int manv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select TENNV from NHANVIEN  where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public bool ktramaNV_Khoangoai_HD(int manv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from HOADON where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktramaNV_Khoangoai_PN(int manv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from PHIEUNHAP where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool doimk(int manv,string mk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update NHANVIEN set MK='"+mk+"' where MANV=" + manv;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //if (txttennv.Text.Length< 1)
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        //        return;
        //    }
        //=========================================================================================================================================================
        //======================= NHÀ CUNG CẤP =====================
        public DataTable Loadncc()
        {
            SqlCommand cmd = new SqlCommand("select * from NHACUNGCAP", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public bool themncc(string tenncc, string sdt, string email,string diachi)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into NHACUNGCAP values(N'" + tenncc + "','" + sdt + "','" + email + "',N'" + diachi + "')";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoancc(int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from NHACUNGCAP where MANCC=" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suancc(int mancc, string tenncc, string sdt, string email,string diachi)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update NHACUNGCAP set TENNCC = N'" + tenncc + "', SDT='" + sdt + "', EMAIL='" + email + "', DIACHI=N'" + diachi + "'  where MANCC='" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int laymancc(string tenncc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MANCC from NHACUNGCAP where TENNCC=N'"+tenncc+"'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymancc = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymancc;
            }
            catch
            {
                return -1;
            }
        }
        public string laysdt_ncc(int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select SDT from NHACUNGCAP where MANCC=" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public string layemail(int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select EMAIL from NHACUNGCAP  where MANCC=" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public string laydiachi(int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select DIACHI from NHACUNGCAP  where MANCC=" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public List<string> LoadTenNCC()
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string caulenh = "select * from NHACUNGCAP";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENNCC"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }
        }
        public bool ktramaNCC_Khoangoai(int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from PHIEUNHAP where MANCC=" + mancc;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        //=========================================================================================================================================================
        //======================= PHIẾU NHẬP - CT PHIẾU NHẬP =====================
        public DataTable Loadphieunhap()
        {
            SqlCommand cmd = new SqlCommand("select pn.MAPN,ncc.TENNCC,nv.TENNV,pn.NGAYLAP,sp.TENSP,ctpn.SOLUONG,ctpn.THANHTIEN,pn.TONGTIEN " +
                    "from PHIEUNHAP pn, CHITIETPHIEUNHAP ctpn, NHACUNGCAP ncc, NHANVIEN nv, SANPHAM sp " +
                    "where pn.MAPN=ctpn.MAPN " +
                    "and pn.MANV=nv.MANV " +
                    "and pn.MANCC=ncc.MANCC " +
                    "and ctpn.MASP=sp=MASP", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public bool thempn(int mancc, int manv, string ngaylap, decimal tongtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into PHIEUNHAP values(" + mancc + "," + manv + ",convert(date,'" + ngaylap + "',103)," + tongtien + ")";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoapn(int mapn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from PHIEUNHAP where MAPN=" + mapn;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suapn(int mapn, int mancc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update PHIEUNHAP set MANCC=" + mancc + " where MAPN=" + mapn;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktramaPN_Khoangoai(int mapn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from CHITIETPHIEUNHAP where MAPN=" + mapn;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themctpn(int mapn,int masp,int soluong, decimal thanhtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into CHITIETPHIEUNHAP values(" + mapn + "," + masp + "," + soluong + "," + thanhtien + ")";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoactpn(int mactpn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from CHITIETPHIEUNHAP where MACTPN=" + mactpn;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suactpn(int mactpn, decimal thanhtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update CHITIETPHIEUNHAP set THANHTIEN ="+thanhtien+"  where MACTPN=" + mactpn;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public int laymaphieunhap()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select max(MAPN) from PHIEUNHAP";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymapn = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymapn;
            }
            catch
            {
                return -1;
            }
        }

        public bool capnhattienphieunhap()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update PHIEUNHAP set TONGTIEN=(select SUM(THANHTIEN) from CHITIETPHIEUNHAP where PHIEUNHAP.MAPN = CHITIETPHIEUNHAP.MAPN)";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }










        //=========================================================================================================================================================
        //======================= HÓA ĐƠN - CT HÓA ĐƠN =====================
        SqlDataAdapter daa;
        public DataTable Loadhoadon()
        {
            SqlCommand cmd = new SqlCommand("select hd.MAHD,hd.MANV,hd.MAKH,hd.NGAYLAP,cthd.MASP,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd " +
                    "where hd.MAHD=cthd.MAHD ", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public DataTable Loadhoadon_mix()
        {
            SqlCommand cmd = new SqlCommand("select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        //public DataTable Loadhoadon()
        //{
        //    SqlCommand cmd = new SqlCommand("select hd.MAHD,hd.MANV,hd.MAKH,hd.NGAYLAP,cthd.MASP,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
        //            "from HOADON hd, CHITIETHD cthd " +
        //            "where hd.MAHD=cthd.MAHD ", conn);
        //    daa = new SqlDataAdapter(cmd);
        //    DataTable tab = new DataTable();

        //    daa.Fill(tab);
        //    return tab;

        //}
        public bool themhd(int makh, int manv, string ngaylap, decimal giamgia, decimal tongtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into HOADON values(" + makh + "," + manv + ",convert(date,'" + ngaylap + "',103)," + giamgia + "," + tongtien + ")";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoahd(int mahd)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from HOADON where MAHD=" + mahd;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suahd(int mahd, int makh, int manv, string ngaylap, decimal giamgia, decimal tongtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update HOADON set MAKH=" + makh + ",MANV=" + manv + "  where MAHD=" + mahd;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capnhattienhoadon()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update HOADON set TONGTIEN=(select SUM(THANHTIEN) from CHITIETHD where HOADON.MAHD = CHITIETHD.MAHD)";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktramaHD_Khoangoai(int mahd)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from CHITIETHD where MAHD=" + mahd;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public int laymahoadon()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select max(MAHD) from HOADON ";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymahd = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymahd;
            }
            catch
            {
                return -1;
            }
        }

        public bool themcthd(int mahd, int masp, int soluong, decimal thanhtien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into CHITIETHD(MAHD,MASP,SOLUONG,THANHTIEN) values(" + mahd + "," + masp + "," + soluong + "," + thanhtien + ")";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoacthd(int macthd)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from CHITIETHD where MACTHD=" + macthd;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suacthd(int macthd, int masp, int soluong)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update HOADON set MASP=" + masp + ",SOLUONG=" + soluong + "  where MACTHD=" + macthd;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }








        //=========================================================================================================================================================
        public DataTable LoadloaiSP()
        {
            SqlCommand cmd = new SqlCommand("select * from LOAISP", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public DataTable LoadSP()
        {
            SqlCommand cmd = new SqlCommand("select * from SANPHAM", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public int kiemtrasoluongton(int masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select SOLUONGTON from SANPHAM where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int ktraslt = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return ktraslt;
            }
            catch
            {
                return -1;
            }
        }
        public bool capnhatsanpham(int masp, int slmua)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update SANPHAM set SOLUONGTON=(SOLUONGTON - "+slmua+") where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capnhatsanpham2(int masp, int slnhap)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update SANPHAM set SOLUONGTON=(SOLUONGTON + " + slnhap + ") where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string laytenloaisp(int maloaisp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select TENLOAISP from LOAISP  where MALOAISP=" + maloaisp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public string laytensp(int masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select TENSP from SANPHAM  where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                string laygt = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laygt;
            }
            catch
            {
                return "";
            }
        }
        public bool themloaisp(string tenloaisp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into LOAISP values(N'"+tenloaisp+"')";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaloaisp(int maloaisp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from LOAISP where MALOAISP=" + maloaisp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sualoaisp(int maloaisp, string tenloaisp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update LOAISP set TENLOAISP=N'" + tenloaisp + "' where MALOAISP=" + maloaisp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool themsp(string tensp,int maloai,decimal dongia,int soluongton,string hinh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "insert into SANPHAM values(N'" + tensp + "',"+maloai+","+dongia+","+soluongton+",N'"+hinh+"')";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoasp(int masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "delete from SANPHAM where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suasp(int masp, string tensp, int maloai, decimal dongia, int soluongton, string hinh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "update SANPHAM set TENSP=N'" + tensp + "', MALOAI=" + maloai + ", DONGIA=" + dongia + ", SOLUONGTON=" + soluongton + ", HINHANH=N'" + hinh + "' where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<string> LoadLoaiSP()
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select * from LOAISP";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENLOAISP"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }

        }
        public List<string> LoadSP(string maloaisp)
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select distinct(TENSP) from SANPHAM, LOAISP where TENLOAISP=N'" + maloaisp+"' and SANPHAM.MALOAI=LOAISP.MALOAISP ";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENSP"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }

        }
        public List<string> LoadSP_all()
        {
            List<string> dskq = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select * from SANPHAM";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string ketqua = rd["TENSP"].ToString();
                    dskq.Add(ketqua);
                }
                rd.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return dskq;
            }
            catch
            {
                return null;
            }

        }

        public ketnoisql()
        {
            LoadLoaiSanPham();
            //LoadDichvu();
            //Loadthongke();
            //LoadPhong();
            //LoadNhanVien();
        }
        DataSet dsLoaiSP = new DataSet();
        SqlDataAdapter da;
        public DataTable LoadLoaiSanPham()
        {
            dsLoaiSP.Clear();
            da = new SqlDataAdapter("select * from LOAISP", conn);
            da.Fill(dsLoaiSP, "LOAISP");
            //DataColumn[] key = new DataColumn[1];

            //key[0] = dsKH.Tables["KHACHHANG"].Columns[0];

            //dsKH.Tables["KHACHHANG"].PrimaryKey = key;
            return dsLoaiSP.Tables["LOAISP"];

        }
        DataSet dsSP = new DataSet();
        public DataTable LoadSPtheoloai(string loaisp)
        {
            dsSP.Tables.Clear();
            da = new SqlDataAdapter("select MASP,TENSP from SANPHAM,LOAISP where TENLOAISP=N'" + loaisp + "'", conn);
            da.Fill(dsSP, "SANPHAM");
            //DataColumn[] key = new DataColumn[1];

            //key[0] = dsPhong.Tables["PHONG1"].Columns[0];

            //dsPhong.Tables["PHONG1"].PrimaryKey = key;

            return dsSP.Tables["SANPHAM"];

        }
        public int laygiasanpham(string masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select convert(int,DONGIA) from SANPHAM where TENSP=N'" + masp + "'";//convert(int,DONGIA)
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int hdhd = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return hdhd;
            }
            catch
            {
                return -1;
            }
        }
        public int laymaloaisanpham(string tenloaisp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MALOAISP from LOAISP where TENLOAISP=N'" + tenloaisp + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymaloaisp = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymaloaisp;
            }
            catch
            {
                return -1;
            }
        }
        public int laymasanpham(string tensp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select MASP from SANPHAM where TENSP=N'" + tensp + "'";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int laymasp = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return laymasp;
            }
            catch
            {
                return -1;
            }
        }
        public bool ktramaloaiSP_Khoangoai(int malsp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from SANPHAM where MALOAI=" + malsp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktramaSP_Khoangoai_HD(int masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from CHITIETHD where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktramaSP_Khoangoai_PN(int masp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select count(*) from CHITIETPHIEUNHAP where MASP=" + masp;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (kq >= 1)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }


        //==============================================================================================================================

        public bool locthangnam1(int thang, int nam)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV" +
                    "and MONTH(NGAYLAP)=" + thang + " and YEAR(NGAYLAP)=" + nam;
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool locthangnam2(string ngaydau, string ngaycuoi)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string caulenh = "select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV" +
                    "and NGAYLAP>= convert(date,'" + ngaydau + "',103) " +
                    "and NGAYLAP<= convert(date,'" + ngaycuoi + "',103)";
                SqlCommand cmd = new SqlCommand(caulenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable Loadthongke2(string ngaydau, string ngaycuoi)
        {
            SqlCommand cmd = new SqlCommand("select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV" +
                    " and hd.NGAYLAP>= convert(date,'" + ngaydau + "',103)" +
                    " and hd.NGAYLAP<= convert(date,'" + ngaycuoi + "',103) ", conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;

        }
        public DataTable Loadthongke1(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand("select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV" +
                    "and MONTH(NGAYLAP)=" + thang + " and YEAR(NGAYLAP)=" + nam, conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;
        }
        public DataTable Loadthongke3(int nam)
        {
            SqlCommand cmd = new SqlCommand("select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN " +
                    "from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv " +
                    "where hd.MAHD=cthd.MAHD " +
                    "and cthd.MASP=sp.MASP " +
                    "and hd.MAKH=kh.MAKH " +
                    "and nv.MANV=hd.MANV" +
                    "and YEAR(NGAYLAP)=" + nam, conn);
            daa = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            daa.Fill(tab);
            return tab;
        }


    }
}
