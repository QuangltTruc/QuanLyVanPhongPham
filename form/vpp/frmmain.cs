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
    public partial class frmmain : Form
    {
        string chucvu = "", tendn = "", mk = "";

        public int manv;
        public int layso;
        public frmmain()
        {
            InitializeComponent();
        }

        public frmmain(string chucvu, string tendn, string mk)
        {
            InitializeComponent();
            this.chucvu = chucvu;
            this.tendn = tendn;
            this.mk = mk;
        }
        private void hienthi(Form a)
        {
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(a);
            a.Show();
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.IsMdiContainer = true;
            //lblxinchao.Text = "Xin chào " + layten + " !";
            if (layso == 1)
            {
                mnit_quanly.Enabled = true;
            }
            else
            {
                mnit_quanly.Enabled = false;
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            frmnv a = new frmnv();
            hienthi(a);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            frmkh a = new frmkh();
            hienthi(a);
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            frmncc a = new frmncc();
            hienthi(a);
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            HD_CTHD a = new HD_CTHD();
            hienthi(a);
        }

        private void quảnLýPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            PN_CTPN a = new PN_CTPN();
            hienthi(a);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            ThanhToan a = new ThanhToan();
            a.manv = this.manv;
            hienthi(a);
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            NhapHang a = new NhapHang();
            a.manv = this.manv;
            hienthi(a);
        }

        private void xemDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            DoanhThu a = new DoanhThu();
            hienthi(a);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            frmsanpham a = new frmsanpham();
            hienthi(a);
        }

        private void mnit_dmkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoimk frmdmk = new frmdoimk(tendn, mk);
            frmdmk.manv = this.manv;
            this.Hide();
            frmdmk.ShowDialog();
            this.Show();
        }

        private void mnit_hethong_Click(object sender, EventArgs e)
        {

        }
    }
}
