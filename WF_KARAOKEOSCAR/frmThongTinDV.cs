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
    public partial class frmThongTinDV : Form
    {
        int flag_madv = 0;
        string flag_tendv;
        int flag_giadv;

        public frmThongTinDV()
        {
            InitializeComponent();
        }

        private void frmThongTinDV_Load(object sender, EventArgs e)
        {
            LoadBangDichVu();
        }

        private void dgvDichVu_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            flag_madv = Convert.ToInt32(dgvDichVu.Rows[numrow].Cells[0].Value.ToString());
            flag_tendv = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
            flag_giadv = Convert.ToInt32(dgvDichVu.Rows[numrow].Cells[2].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmThemDichVu frm = new frmThemDichVu();
            frm.ShowDialog();
            LoadBangDichVu();

        }

        private void LoadBangDichVu()
        {
            DataTable dt = new DataTable();
            dt = DichVuDAO.Instance.LayTatCaDichVu();
            dgvDichVu.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag_madv == 0)
            {
                MessageBox.Show("Vui lòng click chuột vào dòng thông tin dịch vụ cần xóa!");
            }
            else
            {
                try
                {
                    if(DichVuDAO.Instance.XoaDichVu(flag_madv) > 0)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại!");
                    }    
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa dịch vụ đã đưa vào cho khách hàng sử dụng");
                }

                flag_madv = 0;
                LoadBangDichVu();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(flag_madv == 0)
            {
                MessageBox.Show("Vui lòng click chuột vào dòng thông tin dịch vụ cần sửa!");
            }
            else
            {
                frmSuaDichVu frm = new frmSuaDichVu(flag_madv, flag_tendv, flag_giadv);
                frm.ShowDialog();
            }

            flag_madv = 0;
            LoadBangDichVu();
        }
    }
}
