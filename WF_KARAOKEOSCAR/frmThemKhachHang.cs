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
using WF_KARAOKEOSCAR.DTO;

namespace WF_KARAOKEOSCAR
{
    public partial class frmThemKhachHang : Form
    {
        private int maphong;

        public frmThemKhachHang()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        public frmThemKhachHang(int id)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.maphong= id;
        }


        private void btnReLoad_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemThongTinKhachHang();
            TaoMoiHoaDonDatPhong();
            ThanhCong();
            CapNhatTrangThaiPhong();
            HienThiChiTietPhongVuaTao();
            this.Close();
        }

        void HienThiChiTietPhongVuaTao()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.Instance.GetInforOrderByMaxID();

            frmChiTietPhong frm = new frmChiTietPhong(dt.Rows[0].Field<int>("maHD"));
            frm.ShowDialog();
        }

        void ThemThongTinKhachHang()
        {
            string flag;

            if(radioButton1.Checked == true)
            {
                flag = "Nam";
            }
            else
            {
                flag = "Nữ";
            }

            try
            {
                KhachHangDao.Instance.ThemKhachHang(textBox1.Text, textBox2.Text, flag, textBox3.Text);
            }
            catch(Exception)
            {
                ThatBai();
            }
        }

        void TaoMoiHoaDonDatPhong()
        {
            int flag = (int) KhachHangDao.Instance.LayMaKhachHangLonNhat();
            HoaDonDAO.Instance.CreateOrder(DateTime.Now, 0, flag, this.maphong, "Đang Dùng");
        }

        void ThanhCong()
        {
            MessageBox.Show("Thành Công!");
        }

        void ThatBai()
        {
            MessageBox.Show("Thất Bại!");
        }

        void CapNhatTrangThaiPhong()
        {
            PhongDAO.Instance.CapNhatTrangThaiPhong(this.maphong);
        }
    }
}
