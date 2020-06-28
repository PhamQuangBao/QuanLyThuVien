using FormChinhV1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinhV1
{
    public partial class UserControlInfo : UserControl
    {
        private int _IDND;

        public int IDND { get => _IDND; set => _IDND = value; }

        private static UserControlInfo _instance;
        public static UserControlInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlInfo();
                return _instance;
            }
        }
        //string ID;
        //chưa lấy giá trị trong hàm dựng, nên ko gọi đến hàm chứa giá đó trong hàm dựng được
        //vì vậy sau khi khởi tạo hàm dựng thì giá trị mới được khởi tạo, sau đó mới gọi giá trị thông qua button mới lấy được giá trị tương ứng
        public UserControlInfo()
        {
            InitializeComponent();
            txtIDNgdung.ReadOnly = true;
            txtChucvu.ReadOnly = true;

        }
        private void UserControlInfo_Load(object sender, EventArgs e)
        {

        }
        public void ShowInfo()
        {
            Nguoi_Dung nd = BLL_NguoiDung.Instance.GetInfo(IDND);
            txtIDNgdung.Text = nd.ID_NguoiDung.ToString();
            txtNameND.Text = nd.Name_NguoiDung;
            if (nd.Gender)
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
            dateTimeBirth.Value = nd.Birth;
            txtSDT.Text = nd.PhoneNumber;
            txtDiaChi.Text = nd.DiaChi;
            txtChucvu.Text = nd.Chuc_Vu;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDNgdung.Text);
            string name = txtNameND.Text;
            bool gt;
            if (radioNam.Checked)
                gt = true;
            else
                gt = false;
            DateTime ngaysinh = dateTimeBirth.Value;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string chucvu = txtChucvu.Text;
            if (BLL_NguoiDung.Instance.UpdateNgDung(id, name, ngaysinh, gt, diachi, sdt, chucvu) == true)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại.");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
