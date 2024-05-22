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
    public partial class frmThemPhongMoi : Form
    {
        public frmThemPhongMoi()
        {
            InitializeComponent();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                PhongDAO.Instance.TaoMoiPhong(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Thành Công!");
                //this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tạo Thất Bại!");
            }
        }
    }
}
