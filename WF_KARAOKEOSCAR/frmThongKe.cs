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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            lbHD.Text = ThongKeDAO.Instance.LayTongSoHD().ToString();
            lbTien.Text = ThongKeDAO.Instance.LayDoanhThu().ToString();
            lbKH.Text = ThongKeDAO.Instance.LaySoKH().ToString();

            LoadData();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            dt = ThongKeDAO.Instance.LayHoaDon();
            dgvThongKe.DataSource = dt;
        }

        private void lbTien_Click(object sender, EventArgs e)
        {

        }
    }
}
