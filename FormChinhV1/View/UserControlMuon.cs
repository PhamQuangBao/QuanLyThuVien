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
    public partial class UserControlMuon : UserControl
    {
        private int _IDND;
        public int IDND { get => _IDND; set => _IDND = value; }

        private static UserControlMuon _instance;
        public static UserControlMuon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlMuon();
                return _instance;
            }
        }
        public UserControlMuon()
        {
            InitializeComponent();
            SetView();
        }
        private void UserControlMuon_Load(object sender, EventArgs e)
        {

        }
        public void SetCBBTLieu()
        {
            if (cbbTaiLieu.Items != null)
            {
                cbbTaiLieu.Items.Clear();
            }
            cbbTaiLieu.Items.Add(new CBBItem { Value = "", Text = "All" });//gián giá trị 0 và kiểu text là All vào CBBTheloai đồng tời add vào combobox
                foreach (Tài_Liệu i in BLL_PhieuMuon.Instance.GetCBBTLieu())
                {
                    cbbTaiLieu.Items.Add(new CBBItem//gán đối tượng thể loại sách vào CbbTheloai đồng thời add vào combox
                    {
                        Value = i.ID_TaiLieu,
                        Text = i.Name_TaiLieu

                    });
                }
                cbbTaiLieu.SelectedIndex = 0;
            
        }
        public void SetCBBPMT()
        {
            if (cbbPhMuon.Items != null)
            {
                cbbPhMuon.Items.Clear();
            }
            cbbPhMuon.Items.Add(new CBBItem { Value = "", Text = "All" });
            foreach (Phieu_Muon_Tra i in BLL_PhieuMuon.Instance.GetCBBPMT())
                {
                    cbbPhMuon.Items.Add(new CBBItem
                    {
                        Value = i.ID_ĐG,
                        Text = i.ID_MuonTra

                    });
                }
                cbbPhMuon.SelectedIndex = 0;
            
        }
        public void SetView()
        {
            //SetCBBNgDung();
            SetCBBTLieu();
            SetCBBPMT();
            txtNgDung.Text = BLL_NguoiDung.Instance.GetNameND(IDND);
        }
        public void ShowDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BLL_PhieuMuon.Instance.ShowALLPM();
            txtNgDung.ReadOnly = true;
            txtNgDung.Text = BLL_NguoiDung.Instance.GetNameND(IDND);
        }

        private void cbbPhMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_DG = ((CBBItem)cbbPhMuon.SelectedItem).Value.ToString();
            txtDG.Text = BLL_DocGia.Instance.GetNameDG(ID_DG).ToString();

        }
        private void cbbTaiLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_TL = ((CBBItem)cbbTaiLieu.SelectedItem).Value.ToString();
            txtTinhTrang.ReadOnly = true;
            txtTinhTrang.Text = BLL_PhieuMuon.Instance.GetTinhTrangTL(ID_TL);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Phieu_Muon pm = new Phieu_Muon();
            
            try
            {
                if (cbbTaiLieu.SelectedIndex == 0)
                    MessageBox.Show("Vui lòng lựa chọn tài liệu.");
                else if(txtsoluong.Text == "")
                    MessageBox.Show("Vui lòng nhập số lượng tài liệu.");
                else if(cbbPhMuon.SelectedIndex == 0)
                    MessageBox.Show("Vui lòng lựa chọn phiếu mượn trả.");
                else if(txtNgDung.Text == "")
                    MessageBox.Show("Vui lòng nhập tên người dùng.");
                else
                {
                    pm.ID_TaiLieu = ((CBBItem)cbbTaiLieu.SelectedItem).Value;
                    pm.ID_PhieuMuon = ((CBBItem)cbbPhMuon.SelectedItem).Text;
                    pm.Count_ = Convert.ToInt32(txtsoluong.Text);
                    pm.ID_NguoiDung = IDND;
                    pm.NgayMuon = Convert.ToDateTime(dateTimeMuon.Value.ToString());
                    pm.NgayPhaiTra = Convert.ToDateTime(dateTimeTra.Value.ToString());
                    pm.Trang_Thai_Muon = txtTinhTrang.Text;
                    if (BLL_PhieuMuonTra.Instance.KiemtrTG(Convert.ToDateTime(dateTimeTra.Value.ToString()), ((CBBItem)cbbPhMuon.SelectedItem).Text) == false)
                    {
                        DialogResult result = MessageBox.Show("Phiếu mượn hết hạn vào ngày "+ BLL_PhieuMuonTra.Instance.GetNgHetHan(((CBBItem)cbbPhMuon.SelectedItem).Text) +". Bạn có muốn gia hạn phiếu mượn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            BLL_PhieuMuon.Instance.GiaHan(((CBBItem)cbbPhMuon.SelectedItem).ToString());
                        }
                    }
                    else if (BLL_PhieuMuon.Instance.KiemSoLuong(((CBBItem)cbbTaiLieu.SelectedItem).Value, Convert.ToInt32(txtsoluong.Text), pm, Convert.ToDateTime(dateTimeTra.Value.ToString()), ((CBBItem)cbbPhMuon.SelectedItem).Text))
                    {
                        MessageBox.Show("Thêm phiếu mượn thành công!");
                        ShowDataGrid();
                        UserControlQLTL.Instance.ShowTL();
                    }
                    else
                    {
                        MessageBox.Show("Mượn không thành công.");
                        MessageBox.Show("Tài liệu còn trong kho :" + BLL_TaiLieu.Instance.GetSoluongTL(((CBBItem)cbbTaiLieu.SelectedItem).Value));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtbID_TaiLieu.ReadOnly = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
