using FormChinhV1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_DocGia
    {
        private static BLL_DocGia _Instance;

        public static BLL_DocGia Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DocGia();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_DocGia()
        {

        }
        // Hiển thị toàn bộ độc giả có trong CSDL
        public IList ShowALLDocGia()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Độc_giả.Select(p => new { p.ID_ĐG, p.Name_ĐG, p.Birth, p.Gender, p.DiaChi, p.PhoneNumber });
            return li.ToList();
        }
        // Hiển thị toàn bộ phiếu mượn trả có trong CSDL
        public IList ShowALLPMT()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Muon_Tra.Select(p => new { p.ID_MuonTra, p.Độc_giả.Name_ĐG, p.ID_NguoiLapPhieu, p.NgayTao, p.NgayHetHan });

            return li.ToList();
        }
        public List<Độc_giả> GetDocGia(List<string> ID_ND)
        {
            SE_06Entities db = new SE_06Entities();
            List<Độc_giả> LIST_ĐG = new List<Độc_giả>();
            
            foreach (string j in ID_ND)
            {
                LIST_ĐG.Add(db.Độc_giả.Where(p => p.ID_ĐG == j).Select(p => p).FirstOrDefault());
            }
            return LIST_ĐG;
            
        }
        // So sánh và kiểm tra thời gian có hợp lệ không
        public bool KiemtrTG(DateTime nt, DateTime nghh)
        {
            bool check;
            if (BLL_PhieuMuonTra.Instance.KiemtraTG(nt, nghh))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        // Thêm độc giả mới
        public bool AddDocGia(Độc_giả dg)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                string iddg = dg.ID_ĐG;
                string name = dg.Name_ĐG;
                Nullable<DateTime> ngsinh = dg.Birth;
                Nullable<bool> gt = dg.Gender;
                string diachi = dg.DiaChi;
                string phone = dg.PhoneNumber;

                db.Độc_giả.Add(dg);
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
        // Cập nhật thông tin độc giả
        public bool UpdateDocGia(string iddg, string name, DateTime ngsinh, bool gt, string diachi, string phone)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                Độc_giả dg = db.Độc_giả.Where(p => p.ID_ĐG == iddg).FirstOrDefault();
                
                dg.Name_ĐG = name;
                dg.Birth = ngsinh;
                dg.Gender = gt;
                dg.DiaChi = diachi;
                dg.PhoneNumber = phone;

                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
        // Xóa độc giả
        public void DelDocGia(List<string> ID)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                foreach (Độc_giả i in db.Độc_giả)
                {
                    foreach (string j in ID)
                    {
                        if (i.ID_ĐG == j)
                        {
                            db.Độc_giả.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public string GetNameDG(string ID)
        {
            SE_06Entities db = new SE_06Entities();
            string id = "";
            try
            {
                var li = db.Độc_giả.Where(p => p.ID_ĐG == ID).FirstOrDefault();
                //string name = DG.Name_ĐG;
                id = li.Name_ĐG;
            }
            catch
            {

            }
            return id;
        }
    }
}
