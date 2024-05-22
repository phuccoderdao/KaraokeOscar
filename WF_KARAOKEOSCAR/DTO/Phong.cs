using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DTO
{
    public class Phong
    {
        private int maPhong;
        private string tenPhong;
        private int maLoaiPhong;
        private string trangThai;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string Trangthai { get => trangThai; set => trangThai = value; }

        public Phong()
        {

        }

        public Phong(int ma, string ten, int loai, string trangthai)
        {
            this.maPhong = ma;
            this.tenPhong = ten;
            this.maLoaiPhong = loai;
            this.trangThai = trangthai;
        }

        public Phong (DataRow row)
        {
            this.maPhong = (int)row["maPhong"];
            this.tenPhong = row["tenPhong"].ToString();
            this.maLoaiPhong = (int)row["maLoaiPhong"];
            this.trangThai = row["trangThai"].ToString();
        }
    }
}
