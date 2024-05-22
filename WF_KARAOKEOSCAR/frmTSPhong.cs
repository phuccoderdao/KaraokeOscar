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
    public partial class frmTSPhong : Form
    {
        private int flag = 0;
        private int maLoaiPhong;
        private int giaPhong;
        private string tenPhong;
        public frmTSPhong()
        {
            InitializeComponent();
            flag = 1;
        }

        public frmTSPhong(int ma, string ten, int gia)
        {
            this.maLoaiPhong = ma;
            this.tenPhong = ten;
            this.giaPhong = gia;

            InitializeComponent();
            textBox1.Text = ten;
            textBox2.Text = gia.ToString();
            flag = 2;
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
            if(flag == 1)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Điền đủ thông tin!");
                }
                else
                {
                    try
                    {
                        PhongDAO.Instance.TaoLoaiPhongMoi(textBox1.Text, Convert.ToInt32(textBox2.Text));
                        MessageBox.Show("Thêm Thành Công!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm Thất Bại!");
                    }
                }
            }
            else
            {
                PhongDAO.Instance.SuaThongTinLoaiPhong(this.maLoaiPhong, textBox1.Text, Convert.ToInt32(textBox2.Text));
                /*try
                {
                    btnReLoad.Enabled = false;
                    PhongDAO.Instance.SuaThongTinLoaiPhong(this.maLoaiPhong, textBox1.Text, Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("Thành Công!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại!");
                }*/
            }    
            
        }
    }
}
