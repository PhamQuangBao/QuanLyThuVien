using FormChinhV1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_PhieuMuon
    {
        private static BLL_PhieuMuon _Instance;

        public static BLL_PhieuMuon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PhieuMuon();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_PhieuMuon()
        {

        }
        public List<Nguoi_Dung> GetCBBNgDung()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Nguoi_Dung.Select(p => p);
            return li.ToList();
        }
        public List<Tài_Liệu> GetCBBTLieu()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Tài_Liệu.Select(p => p);
            return li.ToList();
        }
        public List<Phieu_Muon_Tra> GetCBBPMT()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Muon_Tra.Select(p => p);
            return li.ToList();
        }
        // Hiển thị toàn bộ phiếu mượn
        public IList ShowALLPM()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Muon.Select(p => new { p.ID_PhieuMuon, p.ID_TaiLieu, p.Count_, p.NgayMuon, p.NgayPhaiTra, p.Trang_Thai_Muon });
            return li.ToList();
        }
        // Lấy ra tình trạng của tài liệu tương ứng
        public string GetTinhTrangTL(string ID_TL)
        {
            string TT = "";
            SE_06Entities db = new SE_06Entities();
            try
            {
                var list = db.Tài_Liệu.Where(p => p.ID_TaiLieu == ID_TL).FirstOrDefault();
                TT = list.TinhTrang;
            }
            catch
            {
            }
            return TT;
        }
        // Thêm phiếu mượn
        public bool AddPhMuon(Phieu_Muon pm)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                    string id_tl = pm.ID_TaiLieu;
                    string id_pmt = pm.ID_PhieuMuon;
                    int soluong = Convert.ToInt32(pm.Count_);
                    int idngdung = pm.ID_NguoiDung;
                    DateTime ngayM = pm.NgayMuon;
                    DateTime ngayT = pm.NgayPhaiTra;
                    string TrgThaiM = pm.Trang_Thai_Muon;

                    db.Phieu_Muon.Add(pm);
                    db.SaveChanges();
                    return true;
                
            }
            catch
            {
                return false;
            }
        }
        //Gia hạn thêm 1 một tháng cho PMT hết hạn
        public void GiaHan(string ID_Pmt)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                var li = db.Phieu_Muon_Tra.Where(p => p.ID_MuonTra == ID_Pmt).FirstOrDefault();
                DateTime date = li.NgayHetHan;
                DateTime datenew = date.AddMonths(1);
                li.NgayHetHan = datenew;
                db.SaveChanges();

            }
            catch
            {

            }
        }
        // Kiểm tra số lượng tài liệu mượn có hợp lệ không và thực hiện thêm phiếu mượn đồng thời cập nhật lại số lượng của tài liệu
        public bool KiemSoLuong(string Idtl, int soluong, Phieu_Muon pm, DateTime nm, string idpmt)
        {
            bool check = false;
            SE_06Entities db = new SE_06Entities();
            var li = db.Tài_Liệu.Where(p => p.ID_TaiLieu == Idtl).FirstOrDefault();
            if (li.SoLuong != 0)
            {
                if (soluong <= li.SoLuong)
                {
                    AddPhMuon(pm);
                    BLL_TaiLieu.Instance.UpdateTLieuGiamSL(Idtl, soluong);
                    check = true;
                }
            }
            else
                check = false;

            return check;
        }
        public void UpdatePhieuMuon(string IdTLieu, int soluong)
        {
            SE_06Entities db = new SE_06Entities();
            Phieu_Muon tl = db.Phieu_Muon.Where(p => p.ID_TaiLieu == IdTLieu).FirstOrDefault();
            tl.Count_ -= soluong;
            db.SaveChanges();
        }
        public void DeletePhMuon(string Idtl)
        {
            SE_06Entities db = new SE_06Entities();
            Phieu_Muon tl = db.Phieu_Muon.Where(p => p.ID_TaiLieu == Idtl).FirstOrDefault();
            if(tl.Count_ == 0)
            {
                db.Phieu_Muon.Remove(tl);
            }
            db.SaveChanges();
        }

    }
}
