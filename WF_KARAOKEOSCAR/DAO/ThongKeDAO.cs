using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return ThongKeDAO.instance; }
            private set { ThongKeDAO.instance = value; }
        }

        private ThongKeDAO()
        {

        }

        public Object LayTongSoHD()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM tblHOADON");
        }

        public Object LayDoanhThu()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT sum(tongtien) FROM tblHOADON");
        }

        public Object LaySoKH()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM tblKHACHHANG");
        }

        public DataTable LayHoaDon()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM tblHOADON");
        }
    }
}
