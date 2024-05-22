using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KARAOKEOSCAR.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }

        private TaiKhoanDAO()
        {

        }

        public int KiemTraDangNhap(string ten, string matkhau)
        {
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM tblNHANVIEN WHERE tendangnhap = '" + ten + "' and matkhau = '" + matkhau + "'"));

            return count;  
        }

        
    }
}
