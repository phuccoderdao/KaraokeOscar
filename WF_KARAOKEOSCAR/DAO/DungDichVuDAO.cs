using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_KARAOKEOSCAR.DTO;

namespace WF_KARAOKEOSCAR.DAO
{
    public class DungDichVuDAO
    {
        private static DungDichVuDAO instance;

        public static DungDichVuDAO Instance
        {
            get { if (instance == null) instance = new DungDichVuDAO(); return DungDichVuDAO.instance; }
            private set { DungDichVuDAO.instance = value; }
        }

        private DungDichVuDAO()
        {

        }

        public DataTable LayListDichVuTheoHoaDon(int maHD)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT d.tenDV as [Tên Dịch Vụ], s.soluong as [Số Lượng], d.giaDV as [Đơn Giá], (s.soluong * d.giaDV) as [Thành Tiền]  FROM tblHOADON h JOIN tblSUDUNGDICHVU s ON h.maHD = s.maHD JOIN tblDICHVU d ON d.maDV = s.maDV WHERE h.maHD = " + maHD);
        }

        public Object TinhTongTienDichVu(int maHD)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT sum(s.soluong * d.giaDV) FROM tblHOADON h JOIN tblSUDUNGDICHVU s ON h.maHD = s.maHD JOIN tblDICHVU d ON d.maDV = s.maDV WHERE h.maHD = " + maHD);
        }

        public int CheckTonTaiDichVuTrongHoaDon(int maHD, int maDV)
        {
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM tblSUDUNGDICHVU WHERE maHD = " + maHD + " and maDV = " + maDV));

            if(count > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }    
        }

        public void ThemDichVuChoHoaDon(int maHD, int maDV, int soluong)
        {
            if(CheckTonTaiDichVuTrongHoaDon(maHD, maDV) == 1)
            {
                DataProvider.Instance.ExecuteNonQuery("UPDATE tblSUDUNGDICHVU SET soluong = " + soluong + " WHERE maHD = " + maHD + " and maDV = " + maDV);
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblSUDUNGDICHVU VALUES ( @maHD , @maDV , @soluong )", new object[] { maHD, maDV, soluong });
            }    

        }
    }
}
