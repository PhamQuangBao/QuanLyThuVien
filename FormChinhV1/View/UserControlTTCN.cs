using FormChinhV1.BLL;
using FormChinhV1.DTO;
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
    public partial class UserControlTTCN : UserControl
    {
        private int _IDND;
        public int IDND { get => _IDND; set => _IDND = value; }

        private static UserControlTTCN _instance;
        public static UserControlTTCN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlTTCN();
                return _instance;
            }
        }
        public UserControlTTCN()
        {
            InitializeComponent();
        }
        private void UserControlTTCN_Load(object sender, EventArgs e)
        {

        }
        public void cleartt()
        {
            txtpassold.Text = "";
            txtpassnew1.Text = "";
            txtpassnew2.Text = "";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (txtpassold.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu cũ.");
            else if (txtpassnew1.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu mới.");
            else if (txtpassnew2.Text == "")
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới.");
            else
            {
                if(txtpassnew1.Text != txtpassnew2.Text)
                {
                    MessageBox.Show("Mật mới không khớp. Vui lòng nhập lại");
                    cleartt();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thay đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (BLL_Account.Instance.ThaydoiMK(IDND, txtpassold.Text, txtpassnew2.Text) == false)
                        {
                            MessageBox.Show("Mật khẩu cũ không chính xác.");
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thành công.");
                        }
                    }
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
