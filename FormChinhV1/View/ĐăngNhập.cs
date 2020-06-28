using FormChinhV1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinhV1
{
    public partial class ĐăngNhập : Form
    {
        public ĐăngNhập()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = txtbNameUser.Text;
            string pass = txtbPassWord.Text;
            

            if(BLL_Account.Instance.login(user,pass))
            {
                if (BLL_Account.Instance.Kiemtra(user))
                {
                    Home f = new Home(BLL_Account.Instance.GetIDND(user));
                    this.Hide();
                    f.ShowDialog();
                   // f.Close();
                    this.Show();
                }
                else
                {
                    Form3 f3 = new Form3(BLL_Account.Instance.GetIDND(user));
                    this.Hide();
                    f3.ShowDialog();

                 //   f3.Close();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thông báo", "Bạn có muốn thoát không", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtbNameUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtbNameUser.SelectAll();
        }

        private void txtbPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtbPassWord.SelectAll();
        }
    }
}
