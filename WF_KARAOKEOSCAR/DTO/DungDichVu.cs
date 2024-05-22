using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DTO
{
    public class DungDichVu
    {
        private int maHD;
        private int maDV;
        private int soLuong;
        private int donGia;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaDV { get => maDV; set => maDV = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }

        public DungDichVu()
        {

        }

        public DungDichVu(int maHD, int maDV, int soLuong, int dongia)
        {
            this.maHD = maHD;
            this.maDV = maDV;
            this.soLuong = soLuong;
            this.donGia = dongia;
        }

        public DungDichVu(DataRow row)
        {
            this.maHD = (int)row["maHD"];
            this.maDV = (int)row["maDV"];
            this.soLuong = (int)row["soluong"];
            this.donGia = (int)row["dongia"];
        }
    }
}
