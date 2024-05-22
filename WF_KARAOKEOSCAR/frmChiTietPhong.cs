using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_KARAOKEOSCAR.DAO;

namespace WF_KARAOKEOSCAR
{
    public partial class frmChiTietPhong : Form
    {
        private int maHD;

        public frmChiTietPhong()
        {
            InitializeComponent();
        }

        public frmChiTietPhong(int maHD, DateTime batdau)
        {
            
        }

        public frmChiTietPhong(int maHD)
        {
            this.maHD = maHD;

            InitializeComponent();
            lbmaHD.Text = maHD.ToString();

            lbGio.Text = HoaDonDAO.Instance.LaySoGioKaraoke(maHD).ToString();
            lbBatdau.Text = HoaDonDAO.Instance.LayBatDauMaxTheoPhong(maHD).ToString();
            lbTamTinh.Text = HoaDonDAO.Instance.TamTinhTienHat(maHD).ToString();
            lbTienDV.Text = DungDichVuDAO.Instance.TinhTongTienDichVu(maHD).ToString() + " VNĐ";

            LoadListDichVu();
            LoadCombobox();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            lbmaHD.Text = maHD.ToString();

            lbGio.Text = HoaDonDAO.Instance.LaySoGioKaraoke(this.maHD).ToString();
            lbBatdau.Text = HoaDonDAO.Instance.LayBatDauMaxTheoPhong(this.maHD).ToString();
            lbTamTinh.Text = HoaDonDAO.Instance.TamTinhTienHat(this.maHD).ToString();

            LoadListDichVu();
        }

        void LoadListDichVu()
        {
            DataTable dt = new DataTable();
            dt = DungDichVuDAO.Instance.LayListDichVuTheoHoaDon(this.maHD);
            dgvSdDichVu.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int hd = this.maHD;
            int dv = Convert.ToInt32(cmbdv.Text);
            int sl = (int) nmQuantity.Value;
            DungDichVuDAO.Instance.ThemDichVuChoHoaDon(hd, dv, sl);
            lbTienDV.Text = DungDichVuDAO.Instance.TinhTongTienDichVu(maHD).ToString() + " VNĐ";
            LoadListDichVu();
        }

        void LoadCombobox()
        {
            DataTable dt = new DataTable();
            dt = DichVuDAO.Instance.LayThongTinDichVu();
            cmbdv.DataSource = dt;
            cmbdv.DisplayMember = "maDV";
            cmbdv.ValueMember = "maDV";
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int maHD = this.maHD;
            string batdau = lbBatdau.Text;
            DateTime ketthuc = DateTime.Now;
            string giohat = Convert.ToString(HoaDonDAO.Instance.LaySoGioKaraoke(this.maHD));
            string tienhat = Convert.ToString((HoaDonDAO.Instance.TamTinhTienHat(this.maHD)));
            string tiendv = DungDichVuDAO.Instance.TinhTongTienDichVu(this.maHD).ToString();
            string dongia = "150 000";
            int tongtien = Convert.ToInt32((DungDichVuDAO.Instance.TinhTongTienDichVu(this.maHD))) + Convert.ToInt32((HoaDonDAO.Instance.TamTinhTienHat(this.maHD)));
            string trangthai = "Đã";

            HoaDonDAO.Instance.CapNhatHoaDon(this.maHD, ketthuc, tongtien, trangthai);
            this.Close();
            frmHoaDonBasic frm = new frmHoaDonBasic(this.maHD, batdau, ketthuc, giohat, dongia, tienhat, tiendv, tongtien);
            frm.ShowDialog();
        }

        private void frmChiTietPhong_Load(object sender, EventArgs e)
        {

        }

        private void lbTamTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbBatdau_Click(object sender, EventArgs e)
        {

        }
    }
}
