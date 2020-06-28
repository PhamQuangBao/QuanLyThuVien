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
    public partial class Form3 : Form
    {
        private int _ID;

        public int ID { get => _ID; set => _ID = value; }
        public Form3(int id)
        {
            ID = id;
            InitializeComponent();
            labelTenNhanvien.Text = BLL_NguoiDung.Instance.GetNameND(id);
        }

        private void btn_QLTL_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;

            if (!panelHome.Controls.Contains(UserControlQLTL.Instance))
            {
                panelHome.Controls.Add(UserControlQLTL.Instance);
                UserControlQLTL.Instance.Dock = DockStyle.Fill;
                UserControlQLTL.Instance.BringToFront();
            }
            else
            {
                UserControlQLTL.Instance.BringToFront();
            }
        }
        // Mượn tài liệu
        private void button2_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            //userControlMuon1.BringToFront();
            if (!panelHome.Controls.Contains(UserControlMuon.Instance))
            {
                panelHome.Controls.Add(UserControlMuon.Instance);
                UserControlMuon.Instance.Dock = DockStyle.Fill;
                UserControlMuon.Instance.BringToFront();
                UserControlMuon.Instance.IDND = ID;
            }
            else
            {
                UserControlMuon.Instance.BringToFront();
                UserControlMuon.Instance.IDND = ID;
            }
        }
        // Trả tài liệu
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
                UserControlTra.Instance.BringToFront();
                UserControlTra.Instance.IDND = ID;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            //userControlQLĐG1.BringToFront();
            if (!panelHome.Controls.Contains(UserControlQLĐG.Instance))
            {
                panelHome.Controls.Add(UserControlQLĐG.Instance);
                UserControlQLĐG.Instance.Dock = DockStyle.Fill;
                UserControlQLĐG.Instance.BringToFront();
            }
            else
            {
                UserControlQLĐG.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            //userControlXLĐG1.BringToFront();
            if (!panelHome.Controls.Contains(UserControlXLĐG.Instance))
            {
                panelHome.Controls.Add(UserControlXLĐG.Instance);
                UserControlXLĐG.Instance.Dock = DockStyle.Fill;
                UserControlXLĐG.Instance.BringToFront();
                UserControlXLĐG.Instance.IDND = ID;
            }
            else
            {
                UserControlXLĐG.Instance.BringToFront();
                UserControlXLĐG.Instance.IDND = ID;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            //userControlInfo1.BringToFront();
            if (!panelHome.Controls.Contains(UserControlInfo.Instance))
            {
                panelHome.Controls.Add(UserControlInfo.Instance);
                UserControlInfo.Instance.Dock = DockStyle.Fill;
                UserControlInfo.Instance.BringToFront();
                UserControlInfo.Instance.IDND = ID;
            }
            else
            {
                UserControlInfo.Instance.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            //userControlPass1.BringToFront();
            if (!panelHome.Controls.Contains(UserControlTTCN.Instance))
            {
                panelHome.Controls.Add(UserControlTTCN.Instance);
                UserControlTTCN.Instance.Dock = DockStyle.Fill;
                UserControlTTCN.Instance.BringToFront();
            }
            else
            {
                UserControlInfo.Instance.BringToFront();
            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlHome.Instance))
            {
                panelHome.Controls.Add(UserControlHome.Instance);
                UserControlHome.Instance.Dock = DockStyle.Fill;
                UserControlHome.Instance.BringToFront();
            }
            else
            {
                UserControlHome.Instance.BringToFront();
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            if (!panelHome.Controls.Contains(UserControlInfo.Instance))
            {
                panelHome.Controls.Add(UserControlInfo.Instance);
                UserControlInfo.Instance.Dock = DockStyle.Fill;
                UserControlInfo.Instance.BringToFront();
            }
            else
            {
                UserControlInfo.Instance.BringToFront();
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
    }
}
