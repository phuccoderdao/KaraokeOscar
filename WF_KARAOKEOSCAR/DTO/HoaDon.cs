using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DTO
{
    public class HoaDon
    {
        private int maHD;
        private int maKH;
        private int maPhong;
        private DateTime? batdau;
        private DateTime? ketthuc;
        private int tongtien;
        private string trangthai;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime? Batdau { get => batdau; set => batdau = value; }
        public DateTime? Ketthuc { get => ketthuc; set => ketthuc = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }


        public HoaDon()
        {

        }

        public HoaDon(int maHD, int maKH, int maPhong, DateTime batdau, DateTime ketthuc, int tongtien, string trangthai)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.maPhong = maPhong;
            this.batdau = batdau;
            this.ketthuc = ketthuc;
            this.tongtien = tongtien;
            this.trangthai = trangthai;
        }

        public HoaDon(DataRow row)
        {
            this.maHD = (int)row["maHD"];
            this.maKH = (int)row["maKH"];
            this.maPhong = (int)(int)row["maPhong"];
            this.batdau = (DateTime?)row["batdau"];
            this.ketthuc = (DateTime?)row["ketthuc"];
            this.tongtien = (int)row["tongtien"];
            this.trangthai = row["trangthai"].ToString();
        }
    }
}
