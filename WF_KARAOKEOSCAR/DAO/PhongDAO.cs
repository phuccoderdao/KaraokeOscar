using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_KARAOKEOSCAR.DTO;

namespace WF_KARAOKEOSCAR.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }

        public static int TableWidth = 105;
        public static int TableHeight = 105;

        private PhongDAO()
        {

        }

        public List<Phong> LoadPhongList()
        {
            List<Phong> phongList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM tblPHONG");

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongList.Add(phong);
            }

            return phongList;
        }

        public List<Phong> LoadPhongIsNull()
        {
            List<Phong> phongList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM tblPHONG WHERE trangthai = N'Trống'");

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongList.Add(phong);
            }

            return phongList;
        }

        public List<Phong> LoadPhongIsNotNull()
        {
            List<Phong> phongList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM tblPHONG WHERE trangthai = N'Có Người'");

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongList.Add(phong);
            }

            return phongList;
        }

        public void CapNhatTrangThaiPhong(int maphong)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE tblPHONG SET trangthai = N'Có Người' WHERE maPhong = @maPhong ", new object[] { maphong });
        }

        public void CapNhatTrangThaiPhongTrong(int maphong)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE tblPHONG SET trangthai = N'Trống' WHERE maPhong = @maPhong ", new object[] { maphong });
        }

        public object LayMaPhongTheoMaHoaDon(int mahoadon)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT maPhong FROM tblHOADON WHERE maHD = " + mahoadon);
        }

        public DataTable LayThongTinPhong()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM tblLOAIPHONG");
        }

        public void TaoLoaiPhongMoi(string tenphong, int gia)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblLOAIPHONG ( tenLoaiPhong, giaPhong ) VALUES ( @tenLoaiPhong , @giaPhong )", new object[] { tenphong, gia });
        }

        public void XoaLoaiPhong(int maLoai)
        {
           DataProvider.Instance.ExecuteNonQuery("DELETE FROM tblLOAIPHONG WHERE maLoaiPhong = '" + maLoai + "'");
        }

        public void SuaThongTinLoaiPhong(int maLoai, string tenloai, int gia)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE tblLOAIPHONG SET tenLoaiPhong = @tenloai , giaPhong = @gia WHERE maLoaiPhong = @maLoaiPhong ",new object[] { tenloai, gia, maLoai });
        }

        public int KiemtraTonTaiMaPhongTrongHoaDon(int maphong)
        {
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM tblHOADON WHERE maPhong = " + maphong));

            return count;
        }

        public void TaoMoiPhong(int maLoaiPhong, string tenPhong)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblPHONG ( maLoaiPhong , tenPhong , trangthai ) VALUES ( @maLoaiPhong , @tenPhong , N'Trống' )", new object[] { maLoaiPhong, tenPhong });
        }
    }
}
