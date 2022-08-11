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
    public partial class hoadonbanhang : Form
    {
        ketnoisql cn = new ketnoisql();
        public int mahd;
        public hoadonbanhang()
        {
            InitializeComponent();
        }

        private void hoadonbanhang_Load(object sender, EventArgs e)
        {
            DataTable tb = cn.ExecuteQuery("select * from HOADON  left outer join CHITIETHD on HOADON.MAHD=CHITIETHD.MAHD left outer join SANPHAM on CHITIETHD.MASP=SANPHAM.MASP left outer join KHACHHANG on HOADON.MAKH=KHACHHANG.MAKH left outer join NHANVIEN on HOADON.MANV=NHANVIEN.MANV where HOADON.MAHD=" + mahd);
            InHoaDon idh = new InHoaDon();
            idh.SetDataSource(tb);
            crystalReportViewer1.ReportSource = idh;
            idh.SetDatabaseLogon("sa", "123", "DESKTOP-P4VRIGC\\SERVER", "QUANLY_VPP");
        }
    }
}
