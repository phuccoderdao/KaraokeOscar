using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_KARAOKEOSCAR.DTO;

namespace WF_KARAOKEOSCAR.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        public static int TableWidth = 105;
        public static int TableHeight = 105;

        private HoaDonDAO()
        {

        }

        public int GetPhongByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM tblBill WHERE maPhong = " + id  + " AND trangthai = 'Đang Sử Dụng'");

            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.MaHD;
            }

            return -1;
        }

        public DataTable GetInforOrderByMaxID()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT hd.maHD, hd.batdau, lp.giaPhong FROM tblHOADON hd JOIN  tblPHONG p ON p.maPhong = hd.maPhong JOIN tblLOAIPHONG lp ON p.maLoaiPhong = lp.maLoaiPhong WHERE hd.maHD IN (SELECT max(maHD) FROM tblHOADON)");
        }


        public void CreateOrder(DateTime batdau, int tongtien, int maKH, int maPhong, string trangthai)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblHOADON ( batdau , tongtien , maKH , maPhong, trangthai ) VALUES ( @batdau , @tongtien , @maKH , @maPhong , @trangthai )", new object[] { batdau, tongtien, maKH, maPhong, trangthai });
        }

        public object LayHoaDonMaxTheoPhong(int maPhong)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT max(maHD) FROM tblHOADON WHERE maPhong = " + maPhong + " GROUP BY (maPhong)");
        }

        public object LaySoGioKaraoke(int maHD)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT CONVERT(float, ROUND (DATEDIFF (minute, batdau, GETDATE())* 1.0 /60, 1)) FROM tblHOADON WHERE maHD = " + maHD);
        }

        public object LayBatDauMaxTheoPhong(int maHD)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT batdau FROM tblHOADON WHERE maHD = " + maHD);
        }

        public object TamTinhTienHat(int maHD)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT CONVERT(float, ROUND (DATEDIFF (minute, batdau, GETDATE())* 1.0 /60, 1)) *l.giaPhong as tiengio  FROM tblHOADON h JOIN tblPHONG p ON h.maPhong = p.maPhong JOIN tblLOAIPHONG l ON l.maLoaiPhong = p.maLoaiPhong WHERE maHD = " + maHD);
        }

        public void CapNhatHoaDon(int maHD, DateTime ketthuc, int tongtien, string trangthai)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE tblHOADON SET ketthuc = '" + ketthuc + "' ,tongtien = " + tongtien + " ,trangthai = '" + trangthai + "' WHERE maHD = " + maHD);
        }
    }
}
