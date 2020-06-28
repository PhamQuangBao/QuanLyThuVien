using FormChinhV1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_TaiLieu
    {
        private static BLL_TaiLieu _Instance;

        public static BLL_TaiLieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TaiLieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_TaiLieu()
        {

        }
        public List<Phan_Loai> GetCBBPhanLoai()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Phan_Loai.Select(p => p);
            return li.ToList();
        }
        public List<ViTri> GetCBBViTri()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.ViTris.Select(p => p);
            return li.ToList();
        }
        public IList ShowAll()
        {

            SE_06Entities db = new SE_06Entities();
            var li = db.Tài_Liệu.Select(p => new { p.ID_TaiLieu, p.Name_TaiLieu, p.ID_TheLoai, p.TacGia, p.SoLuong, p.GiaThanh, p.NXB, p.NamXB, p.ID_ViTri, p.TinhTrang });

            return li.ToList();
        }
        public IList SearchName(string name)
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Tài_Liệu.Where(p => p.Name_TaiLieu.Contains(name) || p.TacGia.Contains(name) || p.NamXB.Contains(name)).
                Select(p => new { p.ID_TaiLieu, p.Name_TaiLieu, p.ID_TheLoai, p.TacGia, p.SoLuong, p.GiaThanh, p.NXB, p.NamXB, p.ID_ViTri, p.TinhTrang });
            return li.ToList();
        }
        public bool AddTaiLieu(Tài_Liệu tl)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                string idlt = tl.ID_TaiLieu;
                string nametl = tl.Name_TaiLieu;
                string nametg = tl.TacGia;
                string NXB = tl.NXB;
                string Idtheloai = tl.ID_TheLoai;
                int sl = tl.SoLuong;
                string tt = tl.TinhTrang;
                string namXB = tl.NamXB;
                Nullable<int> giathanh = tl.GiaThanh;
                Nullable<int> vt = tl.ID_ViTri;

                db.Tài_Liệu.Add(tl);
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
        public bool UpdateTaiLieu(string idtl, string nametl, string nametg, string NXB, string idtheloai, int sl, string tt, string namXB, int giathanh, int vt)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                Tài_Liệu tl = db.Tài_Liệu.Where(p => p.ID_TaiLieu == idtl).FirstOrDefault();
                tl.Name_TaiLieu = nametl;
                tl.TacGia = nametg;
                tl.NXB = NXB;
                tl.ID_TheLoai = idtheloai;
                tl.SoLuong = sl;
                tl.TinhTrang = tt;
                tl.NamXB = namXB;
                tl.GiaThanh = giathanh;
                tl.ID_ViTri = vt;

                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;

        }
        // Xóa tài liệu
        public void DelTaiLieu(List<string> idtl)
        {
            SE_06Entities db = new SE_06Entities();
            foreach (Tài_Liệu i in db.Tài_Liệu)
            {
                foreach (string j in idtl)
                {
                    if (i.ID_TaiLieu == j)
                    {
                        db.Tài_Liệu.Remove(i);
                    }
                }
            }
            db.SaveChanges();

        }
        // Update số lượng tài liệu khi mượn 
        public void UpdateTLieuGiamSL(string idtl, int soluong)
        {
            SE_06Entities db = new SE_06Entities();
            Tài_Liệu tl = db.Tài_Liệu.Where(p => p.ID_TaiLieu == idtl).FirstOrDefault();
            tl.SoLuong -= soluong;

            db.SaveChanges();
        }
        // Updatr số lượng tài liệu khi trả
        public void UpdateTLieuTangSL(string idtl, int soluong)
        {
            SE_06Entities db = new SE_06Entities();
            Tài_Liệu tl = db.Tài_Liệu.Where(p => p.ID_TaiLieu == idtl).FirstOrDefault();
            tl.SoLuong += soluong;

            db.SaveChanges();
        }
        public int GetSoluongTL(string IDTL)
        {
            int sl = 0;
            SE_06Entities db = new SE_06Entities();
            Tài_Liệu tl = db.Tài_Liệu.Where(p => p.ID_TaiLieu == IDTL).FirstOrDefault();
            sl = tl.SoLuong;
            return sl;
        }

    }
}
