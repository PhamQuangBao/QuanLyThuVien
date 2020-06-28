using FormChinhV1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_NguoiDung
    {
        private static BLL_NguoiDung _Instance;

        public static BLL_NguoiDung Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NguoiDung();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_NguoiDung()
        {

        }
        // Lấy ra thông tin người dùng
        public Nguoi_Dung GetInfo(int idND)
        {
            SE_06Entities db = new SE_06Entities();
            Nguoi_Dung li = db.Nguoi_Dung.Where(p => p.ID_NguoiDung == idND).FirstOrDefault();
            return li;
        }
        // Hiển thị toàn bộ người dùng
        public IList ShowALLND()
        {
            SE_06Entities db = new SE_06Entities();
            var li = db.Nguoi_Dung.Select(p => new { p.ID_NguoiDung, p.Name_NguoiDung, p.Birth, p.Gender, p.DiaChi, p.PhoneNumber, p.Chuc_Vu });
            return li.ToList();
        }
        // Thêm người dùng
        public void AddNgDung(Nguoi_Dung nd)
        {
            try
            {
                SE_06Entities db = new SE_06Entities();
                //int IdND = nd.ID_NguoiDung;
                string NameND = nd.Name_NguoiDung;
                DateTime Ngsinh = nd.Birth;
                bool GioiTinh = nd.Gender;
                string Diachi = nd.DiaChi;
                string Sdt = nd.PhoneNumber;
                string Chucvu = nd.Chuc_Vu;

                db.Nguoi_Dung.Add(nd);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        // Lấy ra tên người dùng
        public string GetNameND(int id)
        {
            string name = "";
            try
            {
                SE_06Entities db = new SE_06Entities();
                var li = db.Nguoi_Dung.Where(p => p.ID_NguoiDung == id).FirstOrDefault();
                name = li.Name_NguoiDung;
                
            }
            catch
            {

            }
            return name;
        }
        // Lấy ra ID người dùng 
        public int GetIDNgDung(string name)
        {
            int id = 0;
            try
            {
                SE_06Entities db = new SE_06Entities();
                var li = db.Nguoi_Dung.Where(p => p.Name_NguoiDung == name).FirstOrDefault();
                id = li.ID_NguoiDung;
            }
            catch 
            { 
            }
            return id;

        }
        // Cập nhật thông tin người dùng
        public bool UpdateNgDung(int idnd, string name, DateTime birth, bool gioitinh, string diachi, string sdt, string chucvu)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                Nguoi_Dung ng = db.Nguoi_Dung.Where(p => p.ID_NguoiDung == idnd).FirstOrDefault();
                ng.Name_NguoiDung = name;
                ng.Birth = birth;
                ng.Gender = gioitinh;
                ng.DiaChi = diachi;
                ng.PhoneNumber = sdt;
                ng.Chuc_Vu = chucvu;

                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;

        }
        // Xóa người dùng
        public void DelNgDung(List<int> idnd)
        {
            SE_06Entities db = new SE_06Entities();
            foreach (Nguoi_Dung i in db.Nguoi_Dung)
            {
                foreach (int j in idnd)
                {
                    if (i.ID_NguoiDung == j)
                    {
                        db.Nguoi_Dung.Remove(i);
                    }
                }
            }
            db.SaveChanges();
        }
      
    }
}
