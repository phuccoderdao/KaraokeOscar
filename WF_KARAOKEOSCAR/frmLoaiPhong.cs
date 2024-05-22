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
    public partial class frmLoaiPhong : Form
    {
        public static int flag;
        public static string tenLoaiPhong;
        public static int dongia;
        public static int ma;

        public frmLoaiPhong()
        {
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.Instance.LayThongTinPhong();
            dgvPhong.DataSource = dt;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTSPhong frmTS = new frmTSPhong();
            frmTS.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 0)
                {
                    MessageBox.Show("Vui lòng click chuột vào thông tin loại phòng cần xóa!");
                }
                else
                {
                    PhongDAO.Instance.XoaLoaiPhong(flag);
                    MessageBox.Show("Xóa Thành Công!");
                    flag = 0;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Xóa Thất Bại!");
            }

            flag = 0;
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(ma == 0)
            {
                MessageBox.Show("Vui lòng click chuột vào thông tin loại phòng cần sửa!");
            }    
            else
            {
                frmTSPhong frmTSPhong = new frmTSPhong(ma, tenLoaiPhong, dongia);
                frmTSPhong.ShowDialog();
            }

            ma = 0;
            loaddata();
        }

        private void dgvLoaiPhong(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            flag = Convert.ToInt32(dgvPhong.Rows[numrow].Cells[0].Value);
            ma = Convert.ToInt32(dgvPhong.Rows[numrow].Cells[0].Value);
            tenLoaiPhong = dgvPhong.Rows[numrow].Cells[1].Value.ToString();
            dongia = Convert.ToInt32(dgvPhong.Rows[numrow].Cells[2].Value.ToString());
        }
    }
}
