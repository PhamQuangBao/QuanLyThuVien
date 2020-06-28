using FormChinhV1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_DGViPham
    {
        private static BLL_DGViPham _Instance;

        public static BLL_DGViPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DGViPham();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_DGViPham()
        {

        }
        // Xử lý độc giả vi phạm 
        public bool AddVipham(Độc_Giả_Vi_Phạm vp)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                string Iddg = vp.ID_Độc_Giả;

                int Idnd = Convert.ToInt32(vp.ID_Nguoi_Xu_Phat);
                string Lydoxp = vp.Li_do_xu_phat;
                string Hinhthucxp = vp.Hinh_thuc_xu_phat;
                DateTime Ngayxp = vp.Ngay_xu_phat;
                string Ghichu = vp.GhiChu;

                db.Độc_Giả_Vi_Phạm.Add(vp);
                db.SaveChanges();
                return true;
            }
            catch
            {
               return false;
            }
        }
    }
}
