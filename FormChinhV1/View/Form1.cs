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
    
    public partial class Home : Form
    {
        private int _ID;

        public int ID { get => _ID; set => _ID = value; }

        public Home(int id)
        {
            ID = id;
            InitializeComponent();
            button_Home.Visible = false;
            labelNguoiDung.Text = BLL_NguoiDung.Instance.GetNameND(id);
            

        }
        //Thông tin cá nhân
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (!panelHome.Controls.Contains(UserControlInfo.Instance))
            {
                panelHome.Controls.Add(UserControlInfo.Instance);
                UserControlInfo.Instance.Dock = DockStyle.Fill;
                UserControlInfo.Instance.BringToFront();
                UserControlInfo.Instance.IDND = ID;
            }
            else
            {
                button_Home.Visible = true;
                UserControlInfo.Instance.BringToFront();
                UserControlInfo.Instance.IDND = ID;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button_Home.Visible = true;
                if (!panelHome.Controls.Contains(UserControlQLTL.Instance))
                {
                    panelHome.Controls.Add(UserControlQLTL.Instance);
                    UserControlQLTL.Instance.Dock = DockStyle.Fill;
                    UserControlQLTL.Instance.BringToFront();
                    //BLL_TaiLieu.Instance.
                }
                else
                {
                    UserControlQLTL.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Mượn tài liệu
        private void button2_Click(object sender, EventArgs e)
        {
            UserControlMuon.Instance.SetView();
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlMuon.Instance))
            {
                panelHome.Controls.Add(UserControlMuon.Instance);
                UserControlMuon.Instance.Dock = DockStyle.Fill;
                UserControlMuon.Instance.BringToFront();
                UserControlMuon.Instance.IDND = ID;
            }
            else
            {
                button_Home.Visible = true;
                UserControlMuon.Instance.BringToFront();
                UserControlMuon.Instance.IDND = ID;
            }
        }
        //Button trả tài liệu
        private void button3_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlTra.Instance))
            {
                panelHome.Controls.Add(UserControlTra.Instance);
                UserControlTra.Instance.Dock = DockStyle.Fill;
                UserControlTra.Instance.BringToFront();
                UserControlTra.Instance.IDND = ID;

            }
            else
            {
                button_Home.Visible = true;
                UserControlTra.Instance.BringToFront();
                UserControlTra.Instance.IDND = ID;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(UserControlHome.Instance))
            {
                panelHome.Controls.Add(UserControlHome.Instance);
                UserControlHome.Instance.Dock = DockStyle.Fill;
                UserControlHome.Instance.BringToFront();
            }
            else
            {
                button_Home.Visible = false;
                UserControlHome.Instance.BringToFront();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlQLNV.Instance))
            {
                panelHome.Controls.Add(UserControlQLNV.Instance);
                UserControlQLNV.Instance.Dock = DockStyle.Fill;
                UserControlQLNV.Instance.BringToFront();
            }
            else
            {
                button_Home.Visible = true;
                UserControlQLNV.Instance.BringToFront();
            }
        }
        //Quản lý độc giả
        private void button4_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlQLĐG.Instance))
            {
                panelHome.Controls.Add(UserControlQLĐG.Instance);
                UserControlQLĐG.Instance.Dock = DockStyle.Fill;
                UserControlQLĐG.Instance.BringToFront();
                UserControlQLĐG.Instance.IDND = ID;
            }
            else
            {
                button_Home.Visible = true;
                UserControlQLĐG.Instance.BringToFront();
                UserControlQLĐG.Instance.IDND = ID;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlBC.Instance))
            {
                panelHome.Controls.Add(UserControlBC.Instance);
                UserControlBC.Instance.Dock = DockStyle.Fill;
                UserControlBC.Instance.BringToFront();
            }
            else
            {
                button_Home.Visible = true;
                UserControlBC.Instance.BringToFront();
            }
        }
        //Thay đổi mật khẩu
        private void button1_Click_2(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlTTCN.Instance))
            {
                panelHome.Controls.Add(UserControlTTCN.Instance);
                UserControlTTCN.Instance.Dock = DockStyle.Fill;
                UserControlTTCN.Instance.BringToFront();
                UserControlTTCN.Instance.IDND = ID;
            }
            else
            {
                button_Home.Visible = true;
                UserControlTTCN.Instance.BringToFront();
                UserControlTTCN.Instance.IDND = ID;
            }
        }
        //Xử lý vi phạm
        private void button5_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlXLĐG.Instance))
            {
                panelHome.Controls.Add(UserControlXLĐG.Instance);
                UserControlXLĐG.Instance.Dock = DockStyle.Fill;
                UserControlXLĐG.Instance.BringToFront();
                UserControlXLĐG.Instance.IDND = ID;
            }
            else
            {
                button_Home.Visible = true;
                UserControlXLĐG.Instance.BringToFront();
                UserControlXLĐG.Instance.IDND = ID;
            }
        }
    }


}
