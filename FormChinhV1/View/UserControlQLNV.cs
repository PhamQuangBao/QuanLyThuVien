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
    public partial class UserControlQLNV : UserControl
    {
        private static UserControlQLNV _instance;
        public static UserControlQLNV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlQLNV();
                return _instance;
            }
        }
        public UserControlQLNV()
        {
            InitializeComponent();
            SetCBBChucVu();
        }
        private void UserControlQLNV_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            ShowND();
        }
        public void ShowND()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BLL_NguoiDung.Instance.ShowALLND();
        }
        public void SetCBBChucVu()
        {
            if (cbbChucVu.Items == null)
            {
                cbbChucVu.Items.Clear();
            }
            
            cbbChucVu.Items.Add(new CBBItem { Value = "2", Text = "Nhân viên" });
            cbbChucVu.Items.Add(new CBBItem { Value = "1", Text = "Quản Lý" });
            cbbChucVu.SelectedIndex = 0;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                txtbID_NgDung.ReadOnly = true;
                txtbID_NgDung.Text = dataGridView1.SelectedRows[0].Cells["ID_NguoiDung"].Value.ToString();

                if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Gender"].Value) == true)
                {
                    radiobNam.Checked = true;
                }
                else
                {
                    radiobNu.Checked = true;
                }
                txt_NameNgDung.Text = dataGridView1.SelectedRows[0].Cells["Name_NguoiDung"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["Chuc_Vu"].Value.ToString() == "Nhân viên")
                {
                    cbbChucVu.SelectedIndex = 0;
                }
                else cbbChucVu.SelectedIndex = 1;
                txt_DiaChi .Text = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                txtSoDThoai.Text = dataGridView1.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                dateTimePBirth.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Birth"].Value);

            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Nguoi_Dung nd = new Nguoi_Dung();
            Account ac = new Account();
            if (txt_NameNgDung.Text == "")
                MessageBox.Show("Vui lòng nhập tên người dùng.");
            else if (txtSoDThoai.Text == "")
                MessageBox.Show("Vui lòng nhập số điện thoại.");

            else if (txt_DiaChi.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ người dùng.");
            else
            {
                string namecv = "";
                if (cbbChucVu.SelectedIndex == 0)
                    namecv = "nhanvien";
                else
                    namecv = "admin";
                //add người dùng
                nd.Name_NguoiDung = txt_NameNgDung.Text;
                nd.Birth = dateTimePBirth.Value;
                if (radiobNam.Checked)
                    nd.Gender = true;
                else
                    nd.Gender = false;
                nd.DiaChi = txt_DiaChi.Text;
                nd.PhoneNumber = txtSoDThoai.Text;
                nd.Chuc_Vu = ((CBBItem)cbbChucVu.SelectedItem).Text;
                BLL_NguoiDung.Instance.AddNgDung(nd);
                ShowND();
                //add account
                ac.ID = BLL_NguoiDung.Instance.GetIDNgDung(txt_NameNgDung.Text);
                ac.UserName = namecv + BLL_NguoiDung.Instance.GetIDNgDung(txt_NameNgDung.Text);
                ac.Pass_Word = "123456789";
                ac.Type = Convert.ToInt32(((CBBItem)cbbChucVu.SelectedItem).Value);
                BLL_Account.Instance.AddAccount(ac);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            List<int> idnd = new List<int>();
            foreach (DataGridViewRow i in r)
            {
                idnd.Add(Convert.ToInt32(i.Cells["ID_NguoiDung"].Value));
                BLL_NguoiDung.Instance.DelNgDung(idnd);
            }
            ShowND();
        }
    }
}
