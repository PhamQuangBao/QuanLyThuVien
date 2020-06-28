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
    public partial class UserControlQLTL : UserControl
    {
        private static UserControlQLTL _instance;
        public static UserControlQLTL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlQLTL();
                return _instance;
            }
        }
        private void UserControlQLTL_Load(object sender, EventArgs e)
        {

        }
        public UserControlQLTL()
        {
            InitializeComponent();
            cbbTinhTrang.SelectedIndex = 0;
            SetView();
        }
        public void SetCBBPhanLoai()
        {
            if (cbbTheLoai.Items == null)
            {
                cbbTheLoai.Items.Clear();
            }
            else
            {
                cbbTheLoai.Items.Add(new CBBItem { Text = "All", Value = "0" });
                foreach (Phan_Loai i in BLL_TaiLieu.Instance.GetCBBPhanLoai())
                {
                    cbbTheLoai.Items.Add(new CBBItem
                    {
                        Value = i.ID,
                        Text = i.Name

                    });
                }
                cbbTheLoai.SelectedIndex = 0;
            }
        }
        public void SetCBBVitri()
        {
            if (cbbVitri.Items == null)
            {
                cbbVitri.Items.Clear();
            }
            else
            {
                cbbVitri.Items.Add(new CBBItem { Text = "All", Value = "0" });
                foreach (ViTri i in BLL_TaiLieu.Instance.GetCBBViTri())
                {
                    cbbVitri.Items.Add(new CBBItem
                    {
                        Value = i.ID.ToString(),
                        Text = i.Vitri1

                    });
                }
                cbbVitri.SelectedIndex = 0;
            }
        }
        public void ShowTL()
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BLL_TaiLieu.Instance.ShowAll();
        }
        public void clearthongtin()
        {
            txtbID_TaiLieu.ReadOnly = false;
            txtbID_TaiLieu.Text = "";
            txtNameTL.Text = "";
            txtTacGia.Text = "";
            txtNhaXB.Text = "";
            cbbTheLoai.SelectedIndex = 0;
            txtSoLuong.Text = "";
            cbbTinhTrang.SelectedIndex = 0;
            txtNamXB.Text = "";
            txtGiaThanh.Text = "";
            cbbVitri.SelectedIndex = 0;
        }
        public void SetView()
        {
            SetCBBPhanLoai();
            SetCBBVitri();
        }
        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string name = txt_Search.Text;
            if(txt_Search.Text == "")
            {
                ShowTL();
            }
            else
            {
                dataGridView1.DataSource = BLL_TaiLieu.Instance.SearchName(name);
            }
            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txtbID_TaiLieu.Text == "")
                MessageBox.Show("Vui lòng nhập mã tài liệu.");
            else if (txtbID_TaiLieu.Text == "")
                MessageBox.Show("Vui lòng nhập tên tài liệu.");
            else if (txtTacGia.Text == "")
                MessageBox.Show("Vui lòng nhập tên tác giả.");
            else if (txtNhaXB.Text == "")
                MessageBox.Show("Vui lòng nhập nhà xuất bản.");
            else if (cbbTheLoai.SelectedIndex == 0)
                MessageBox.Show("Vui lòng lựa chọn thể loại.");
            else if (txtSoLuong.Text == "")
                MessageBox.Show("Vui lòng nhập số lượng tài liệu.");
            else if (txtNamXB.Text == "")
                MessageBox.Show("Vui lòng nhập năm xuất bản tài liệu.");
            else if (txtGiaThanh.Text == "")
                MessageBox.Show("Vui lòng nhập giá thành tài liệu.");
            else if (cbbVitri.SelectedIndex == 0)
                MessageBox.Show("Vui lòng lựa chọn vị trí tài liệu.");
            else
            {
                Tài_Liệu tl = new Tài_Liệu();
                tl.ID_TaiLieu = txtbID_TaiLieu.Text;
                tl.Name_TaiLieu = txtNameTL.Text;
                tl.TacGia = txtTacGia.Text;
                tl.NXB = txtNhaXB.Text;
                tl.ID_TheLoai = ((CBBItem)cbbTheLoai.SelectedItem).Value;
                tl.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                tl.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                tl.NamXB = txtNamXB.Text;
                tl.GiaThanh = Convert.ToInt32(txtGiaThanh.Text);
                tl.ID_ViTri = Convert.ToInt32(((CBBItem)cbbVitri.SelectedItem).Value);

                if (BLL_TaiLieu.Instance.AddTaiLieu(tl) == false)
                    MessageBox.Show("Thêm tài liệu thất bại.");
                else
                    MessageBox.Show("Thêm tài liệu thành công.");
                ShowTL();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                txtbID_TaiLieu.ReadOnly = true;
                txtbID_TaiLieu.Text = dataGridView1.SelectedRows[0].Cells["ID_TaiLieu"].Value.ToString();
                txtNameTL.Text = dataGridView1.SelectedRows[0].Cells["Name_TaiLieu"].Value.ToString();
                txtTacGia.Text = dataGridView1.SelectedRows[0].Cells["TacGia"].Value.ToString();
                txtNhaXB.Text = dataGridView1.SelectedRows[0].Cells["NXB"].Value.ToString();
                string idtheloai = dataGridView1.SelectedRows[0].Cells["ID_TheLoai"].Value.ToString();
                txtSoLuong.Text = dataGridView1.SelectedRows[0].Cells["SoLuong"].Value.ToString();
                txtNamXB.Text = dataGridView1.SelectedRows[0].Cells["NamXB"].Value.ToString();
                txtGiaThanh.Text = dataGridView1.SelectedRows[0].Cells["GiaThanh"].Value.ToString();
                string idvitri = dataGridView1.SelectedRows[0].Cells["ID_ViTri"].Value.ToString();

                CBBItem theloai = new CBBItem();
                foreach(CBBItem i in cbbTheLoai.Items)
                {
                    if (i.Value == idtheloai)
                        theloai = i;
                }
                cbbTheLoai.SelectedIndex = cbbTheLoai.Items.IndexOf(theloai);

                CBBItem vitri = new CBBItem();
                foreach(CBBItem j in cbbVitri.Items)
                {
                    if (j.Value == idvitri)
                        vitri = j;
                }
                cbbVitri.SelectedIndex = cbbVitri.Items.IndexOf(vitri);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearthongtin();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Chưa kiểm tra ko nhập giá trị
            if (txtbID_TaiLieu.Text == "")
                MessageBox.Show("Vui lòng nhập mã tài liệu.");
            else if (txtbID_TaiLieu.Text == "")
                MessageBox.Show("Vui lòng nhập tên tài liệu.");
            else if (txtTacGia.Text == "")
                MessageBox.Show("Vui lòng nhập tên tác giả.");
            else if (txtNhaXB.Text == "")
                MessageBox.Show("Vui lòng nhập nhà xuất bản.");
            else if (cbbTheLoai.SelectedIndex == 0)
                MessageBox.Show("Vui lòng lựa chọn thể loại.");
            else if (txtSoLuong.Text == "")
                MessageBox.Show("Vui lòng nhập số lượng tài liệu.");
            else if (txtNamXB.Text == "")
                MessageBox.Show("Vui lòng nhập năm xuất bản tài liệu.");
            else if (txtGiaThanh.Text == "")
                MessageBox.Show("Vui lòng nhập giá thành tài liệu.");
            else if (cbbVitri.SelectedIndex == 0)
                MessageBox.Show("Vui lòng lựa chọn vị trí tài liệu.");

            else
            {
                string idtl = txtbID_TaiLieu.Text;
                string nametl = txtNameTL.Text;
                string nametg = txtTacGia.Text;
                string NXB = txtNhaXB.Text;
                string Idtheloai = ((CBBItem)cbbTheLoai.SelectedItem).Value;
                int sl = Convert.ToInt32(txtSoLuong.Text);
                string tt = cbbTinhTrang.SelectedItem.ToString();
                string namXB = txtNamXB.Text;
                int giathanh = Convert.ToInt32(txtGiaThanh.Text);
                int vt = Convert.ToInt32(((CBBItem)cbbVitri.SelectedItem).Value);
                if (BLL_TaiLieu.Instance.UpdateTaiLieu(idtl, nametl, nametg, NXB, Idtheloai, sl, tt, namXB, giathanh, vt) == false)
                    MessageBox.Show("Sửa đổi tài liệu thất bại.");
                else
                    MessageBox.Show("Sửa đổi tài liệu thành công.");
                ShowTL();
                clearthongtin();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            List<string> idtl = new List<string>();
            if (r.Count == 0)
                MessageBox.Show("Vui lòng lựa chọn tài liệu.");
            else
            {
                foreach (DataGridViewRow i in r)
                {
                    idtl.Add(i.Cells["ID_TaiLieu"].Value.ToString());
                    BLL_TaiLieu.Instance.DelTaiLieu(idtl);
                }
                ShowTL();
            }
        }
    }
}
