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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            raAll.Checked = true;
            PhongListAll();
        }
        public static int flag;

        void PhongListAll()
        {
            listphong.Controls.Clear();

            List<Phong> phongList = PhongDAO.Instance.LoadPhongList();

            foreach (Phong item in phongList)
            {
                Button btn = new Button() { Width = PhongDAO.TableWidth, Height = PhongDAO.TableHeight };
                btn.Text = item.TenPhong + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                listphong.Controls.Add(btn);
            }
        }

        void PhongListNull()
        {
            listphong.Controls.Clear();

            List<Phong> phongList = PhongDAO.Instance.LoadPhongIsNull();

            foreach (Phong item in phongList)
            {
                Button btn = new Button() { Width = PhongDAO.TableWidth, Height = PhongDAO.TableHeight };
                btn.Text = item.TenPhong + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                listphong.Controls.Add(btn);
            }
        }

        void PhongListNotNull()
        {
            listphong.Controls.Clear();

            List<Phong> phongList = PhongDAO.Instance.LoadPhongIsNotNull();

            foreach (Phong item in phongList)
            {
                Button btn = new Button() { Width = PhongDAO.TableWidth, Height = PhongDAO.TableHeight };
                btn.Text = item.TenPhong + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                listphong.Controls.Add(btn);
            }
        }

        /*Events*/
        private void raAll_CheckedChanged(object sender, EventArgs e)
        {
            PhongListAll();
        }

        private void raNull_CheckedChanged(object sender, EventArgs e)
        {
            PhongListNull();
        }

        private void raNotNull_CheckedChanged(object sender, EventArgs e)
        {
            PhongListNotNull();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            raAll.Checked = false;
            raNotNull.Checked = false;
            raNull.Checked = false;
        }

        void btn_Click(object sender, EventArgs e)
        {
            int maPhong = (int)((sender as Button).Tag as Phong).MaPhong;
            string flag = ((sender as Button).Tag as Phong).Trangthai.ToString();

            if (PhongDAO.Instance.KiemtraTonTaiMaPhongTrongHoaDon(maPhong) > 0)
            {
                int maHD = (int)HoaDonDAO.Instance.LayHoaDonMaxTheoPhong(maPhong);

                switch (flag)
                {
                    case "Trống":
                        frmThemKhachHang frmKH = new frmThemKhachHang(maPhong);
                        frmKH.ShowDialog();
                        break;
                    default:
                        frmChiTietPhong frmCTPhong = new frmChiTietPhong(maHD);
                        frmCTPhong.ShowDialog();
                        break;
                }
            }
            else
            {
                frmThemKhachHang frmKH = new frmThemKhachHang(maPhong);
                frmKH.ShowDialog();
            }

            PhongListAll();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            PhongListAll();
            raAll.Checked = true;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            plmain.Controls.Add(childForm);
            plmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnReLoad_Click_1(object sender, EventArgs e)
        {
            PhongListAll();
            raAll.Checked = true;
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinDV());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control p in plmain.Controls)
            {
                if (p is Form)
                {
                    plmain.Controls.Remove(p);
                }
            }
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void btnTaoMoiPhong_Click(object sender, EventArgs e)
        {
            frmThemPhongMoi frm = new frmThemPhongMoi();
            frm.ShowDialog();
            PhongListAll();
        }

        private void listphong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}