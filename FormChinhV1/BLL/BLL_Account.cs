using FormChinhV1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.BLL
{
    class BLL_Account
    {
        private static BLL_Account _Instance;

        public static BLL_Account Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Account();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Account()
        {

        }
        // Kiểm tra đăng nhập thành công hay thất bại
        public bool login(string username ,string pass)
        {
            bool check;
            SE_06Entities db = new SE_06Entities();
            var v = db.Accounts.FirstOrDefault(p => p.UserName == username);
            if (v != null)
            {
                if (v.Pass_Word == pass)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                
            }
            else
            {
                check = false;
            }
            return check;
        }
        // Kiểm tra quyền đăng nhập
        public bool Kiemtra(string username)
        {
            bool check;
            SE_06Entities db = new SE_06Entities();
            var v = db.Accounts.FirstOrDefault(p => p.UserName == username);
            if (v.Type == 1)
            {
                check = true;
            }
            else
                check = false;
            return check;
        }
        // Thêm mới account
        public void AddAccount(Account ac)
        {
            SE_06Entities db = new SE_06Entities();
            
            //string user = name + idnd;
             //pass = "123456789";
            int id = ac.ID;
            string user = ac.UserName;
            string pass = ac.Pass_Word;
            int type = ac.Type;

            db.Accounts.Add(ac);
            db.SaveChanges();
        }
        // Lấy ra ID_NgDung
        public int GetIDND(string nameuser)//trả về Id người dung = id account
        {
            
            int IdND = 0;
            SE_06Entities db = new SE_06Entities();
            var li = db.Accounts.Where(p => p.UserName == nameuser).FirstOrDefault();
            try
            {
                if(li != null)
                IdND = li.ID;
            }
            catch
            {
                
            }
            return IdND;

        }
        public bool ThaydoiMK(int id, string passold, string passnew)
        {
            SE_06Entities db = new SE_06Entities();
            try
            {
                Account ac = db.Accounts.Where(p => p.ID == id).Where(p => p.Pass_Word == passold).FirstOrDefault();
                ac.Pass_Word = passnew;
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
    }
}
