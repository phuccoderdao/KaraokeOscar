using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_KARAOKEOSCAR.DTO;

namespace WF_KARAOKEOSCAR.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return DichVuDAO.instance; }
            private set { DichVuDAO.instance = value; }
        }

        private DichVuDAO()
        {

        }

        public DataTable LayThongTinDichVu()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT maDV FROM tblDICHVU");
        }

        public DataTable LayTatCaDichVu()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM tblDICHVU");
        }

        public int ThemDichVu(string tendichvu, int dongia)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO tblDICHVU ( tenDV , giaDV) VALUES ( @tendv , @giadv )", new object[] { tendichvu, dongia });
        }

        public int XoaDichVu(int ma)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM tblDICHVU WHERE maDV = @madv ", new object[] { ma});
        }

        public int SuaDichVu(int ma, string tendichvu, int dongia)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE tblDICHVU SET tenDV = @tendV , giaDV = @giadv WHERE maDV = @madv", new object[] { tendichvu, dongia, ma});
        }
    }
}
