using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_PhieuMuonTra
    {
        private static BLL_PhieuMuonTra _Instance;

        public static BLL_PhieuMuonTra Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PhieuMuonTra();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_PhieuMuonTra()
        {

        }
        // Thêm phiếu mượn trả
        public bool AddPhMuonTra(Phieu_Muon_Tra mt)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                string idmt = mt.ID_MuonTra;
                string iddg = mt.ID_ĐG;
                int idnd = mt.ID_NguoiLapPhieu;
                Nullable<DateTime> ngtao = mt.NgayTao;
                DateTime nghet = mt.NgayHetHan;

                db.Phieu_Muon_Tra.Add(mt);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        // Kiểm tra thời gian 
        public bool KiemtraTG(DateTime d1, DateTime d2)
        {
            bool check = false;
            int kt = DateTime.Compare(d1, d2);
            if (kt <= 0)
            {
                check = true;
            }
            return check;
        }
        // Kiểm tra phiếu mượn có hết hạn không?
        public bool KiemtrTG(DateTime nm, string idpmt)
        {
            bool check;
            SE_06Entities db = new SE_06Entities();
            Phieu_Muon_Tra pmt = db.Phieu_Muon_Tra.Where(p => p.ID_MuonTra == idpmt).FirstOrDefault();
            if (BLL_PhieuMuonTra.Instance.KiemtraTG(nm, pmt.NgayHetHan))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public DateTime GetNgHetHan(string ID_PMT)
        {
            DateTime date = new DateTime();
            try
            {
                
                SE_06Entities db = new SE_06Entities();
                var list = db.Phieu_Muon_Tra.Where(p => p.ID_MuonTra == ID_PMT).FirstOrDefault();
                date = list.NgayHetHan;
            }
            catch
            { }
            return date;

        }
    }
}
