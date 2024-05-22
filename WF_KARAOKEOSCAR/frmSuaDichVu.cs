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
    public partial class frmSuaDichVu : Form
    {
        int flag_madv;

        public frmSuaDichVu(int madv, string tendv, int dongia)
        {
            InitializeComponent();

            flag_madv = madv;
            txtTenDichVu.Text = tendv;
            txtDonGia.Text = dongia.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtTenDichVu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDichVu.Text == "" | txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (Convert.ToInt32(txtDonGia.Text) < 1000 | KiemTraSoNhapVao(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá dịch vụ không hợp lệ");
            }
            else
            {
                try
                {
                    if(DichVuDAO.Instance.SuaDichVu(flag_madv, txtTenDichVu.Text, Convert.ToInt32(txtDonGia.Text)) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private bool KiemTraSoNhapVao(string a)
        {
            foreach (char c in a)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
