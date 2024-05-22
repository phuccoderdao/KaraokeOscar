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
    public partial class frmHoaDonBasic : Form
    {
        private int mahd;

        public frmHoaDonBasic()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            PhongDAO.Instance.CapNhatTrangThaiPhongTrong(Convert.ToInt32(PhongDAO.Instance.LayMaPhongTheoMaHoaDon(this.mahd)));
            this.Close();
        }

        public frmHoaDonBasic(int maHD, string batdau, DateTime ketthuc, string giohat, string dongia, string tienhat, string tiendv, int tongtien)
        {
            this.mahd = maHD;
            InitializeComponent();
            lbMaHD.Text = maHD.ToString();
            lbketthuc.Text = ketthuc.ToString();
            lbbatdau.Text = batdau;
            lbtonghoadon.Text = tongtien.ToString();
            lbgiohat.Text = giohat;
            lbdongia.Text = dongia;
            lbthanhtien.Text = tienhat;
            lbtongdichvu.Text = tiendv;

            LoadListDV();
        }

        void LoadListDV()
        {
            DataTable dt = new DataTable();
            dt = DungDichVuDAO.Instance.LayListDichVuTheoHoaDon(this.mahd);
            dgvsddv.DataSource = dt;
        }

        private void lbgiohat_Click(object sender, EventArgs e)
        {

        }
    }
}
