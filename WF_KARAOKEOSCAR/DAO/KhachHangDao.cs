using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DAO
{
    public class KhachHangDao
    {
        private static KhachHangDao instance;

        public static KhachHangDao Instance
        {
            get { if (instance == null) instance = new KhachHangDao(); return KhachHangDao.instance; }
            private set { KhachHangDao.instance = value; }
        }

        public static int TableWidth = 105;
        public static int TableHeight = 105;

        private KhachHangDao()
        {

        }

        public void ThemKhachHang(string hoten, string diachi, string gioitinh, string sodienthoai)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblKHACHHANG ( tenKH, diachi, gioitinh, dienthoai ) VALUES ( @tenKH , @diachi , @gioitinh , @dienthoai )", new object[] { hoten, diachi, gioitinh, sodienthoai });
        }

        public object LayMaKhachHangLonNhat()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT maKH FROM tblKHACHHANG WHERE maKH IN (SELECT max(maKH) FROM tblKHACHHANG)");
        }
    }
}
