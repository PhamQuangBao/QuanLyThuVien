using FormChinhV1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_PhieuTra
    {
        
        //
        private static BLL_PhieuTra _Instance;

        public static BLL_PhieuTra Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PhieuTra();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        
        private BLL_PhieuTra()
        {

        }

        public List<Nguoi_Dung> GetCBBNgDung()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Nguoi_Dung.Select(p => p);
            return li.ToList();
        }
        public List<Phieu_Muon_Tra> GetCBBPMT()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Muon_Tra.Select(p => p);
            return li.ToList();
        }
        public string GetNameDG(string ID)
        {
            SE_06Entities db = new SE_06Entities();
            string id = "";
            try
            {
                var li = db.Độc_giả.Where(p => p.ID_ĐG == ID).FirstOrDefault();
                id = li.Name_ĐG;
            }
            catch
            {

            }
            return id;
        }
        public List<Tài_Liệu> GetCBBTLieu(string id)
        {
            SE_06Entities db = new SE_06Entities();
            List<Tài_Liệu> tl = new List<Tài_Liệu>();
            try
            {
                var li = db.Tài_Liệu.Select(p => p);
                var list = db.Phieu_Muon.Where(p => p.ID_PhieuMuon == id);

                foreach (Tài_Liệu i in li)
                {
                    foreach (Phieu_Muon j in list)
                    {
                        if (i.ID_TaiLieu == j.ID_TaiLieu)
                            tl.Add(i);
                    }
                }
            }
            catch
            {

            }
            return tl;
        }
        public IList ShowALLPT()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Tra.Select(p => new { p.ID, p.ID_TaiLieu, p.ID_PhieuTra, p.Count_, p.ID_NguoiNhan, p.NgayTra, p.Trang_Thai_Tra });

            return li.ToList();
        }
   
        public void AddPhTra(Phieu_Tra pt)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                string id_tl = pt.ID_PhieuTra;
                string id_pmt = pt.ID_PhieuTra;
                int soluong = Convert.ToInt32(pt.Count_);
                int idnnhan = pt.ID_NguoiNhan;
                DateTime ngayT = pt.NgayTra;
                string TrgThaiM = pt.Trang_Thai_Tra;
                db.Phieu_Tra.Add(pt);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public int KiemSoLuong(string Idtl, int soluong, Phieu_Muon pm, Tài_Liệu tl, Phieu_Tra pt, DateTime a2)
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phieu_Muon.Where(p => p.ID_TaiLieu == Idtl).FirstOrDefault();
            if (li.Count_ >= soluong)
            {
                if (BLL_PhieuMuonTra.Instance.KiemtraTG(a2, li.NgayPhaiTra))
                {
                    //Kiểm tra đúng hạn
                    BLL_PhieuMuon.Instance.UpdatePhieuMuon(Idtl, soluong);
                    BLL_TaiLieu.Instance.UpdateTLieuTangSL(Idtl, soluong);
                    AddPhTra(pt);
                    BLL_PhieuMuon.Instance.DeletePhMuon(Idtl);
                    return 1;
                }
                else
                {
                    //trả quán hạn
                    BLL_PhieuMuon.Instance.UpdatePhieuMuon(Idtl, soluong);
                    BLL_TaiLieu.Instance.UpdateTLieuTangSL(Idtl, soluong);
                    AddPhTra(pt);
                    BLL_PhieuMuon.Instance.DeletePhMuon(Idtl);
                    return 2;
                }
            }
            else
            {
                //Ko trả tài liệu được
                return 0;
            }


        }
    }
}
