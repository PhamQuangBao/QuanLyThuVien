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
    public partial class UserControlQLĐG : UserControl
    {
        private int _IDND;
        public int IDND { get => _IDND; set => _IDND = value; }

        private static UserControlQLĐG _instance;
        public static UserControlQLĐG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlQLĐG();
                return _instance;
            }
        }
        public UserControlQLĐG()
        {
            InitializeComponent();
            //SetCBBNgDung();
            cbbluachon.SelectedIndex = 0;
        }
        private void UserControlQLĐG_Load(object sender, EventArgs e)
        {

        }

        //public void SetCBBNgDung()
        //{
        //    if (cbbNgDung.Items == null)
        //    {
        //        cbbNgDung.Items.Clear();
        //    }
        //    else
        //    {

        //        foreach (Nguoi_Dung i in BLL_PhieuMuon.Instance.GetCBBNgDung())
        //        {
        //            cbbNgDung.Items.Add(new CBBItem//gán đối tượng thể loại sách vào CbbTheloai đồng thời add vào combox
        //            {
        //                Value = i.ID_NguoiDung.ToString(),
        //                Text = i.Name_NguoiDung

        //            });
        //        }
        //        cbbNgDung.SelectedIndex = 0;// lựa chọn item có giá trị = 0 tương ứng với kiểu dữ liệu text "All"
        //    }
        //}
        public void ShowDG()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BLL_DocGia.Instance.ShowALLDocGia();
            txtNgDung.Text = BLL_NguoiDung.Instance.GetNameND(IDND);
        }
        public void ShowPmt()
        {
            dataGridView1.DataSource = BLL_DocGia.Instance.ShowALLPMT();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbbluachon.SelectedIndex == 0)
                ShowDG();
            else
                ShowPmt();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Độc_giả dg = new Độc_giả();
            Phieu_Muon_Tra pmt = new Phieu_Muon_Tra();
            //Thông tin độc giả
            if(txtIdDG.Text == "")
                MessageBox.Show("Vui lòng nhập mã độc giả.");
            else if(txtNameDG.Text == "")
                MessageBox.Show("Vui lòng nhập tên độc giả.");
            else if(txtDiachi.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ độc giả.");
            else if(txtSdtDG.Text == "")
                MessageBox.Show("Vui lòng nhập số điện thoại độc giả.");
            else if(txtIdPMT.Text == "")
                MessageBox.Show("Vui lòng nhập mã phiếu mượn trả.");
            else
            {
                dg.ID_ĐG = pmt.ID_ĐG = txtIdDG.Text;
                dg.Name_ĐG = txtNameDG.Text;
                dg.Birth = dateTimeNSinh.Value;
                if (radioBNam.Checked)
                    dg.Gender = true;
                else
                    dg.Gender = false;
                dg.DiaChi = txtDiachi.Text;
                dg.PhoneNumber = txtSdtDG.Text;
                //Phiếu mượn trả
                pmt.ID_MuonTra = txtIdPMT.Text;
                pmt.ID_NguoiLapPhieu = IDND;
                pmt.NgayTao = dateTimeNgayTao.Value;
                pmt.NgayHetHan = dateTimeNgayHuy.Value;

                if (BLL.BLL_DocGia.Instance.KiemtrTG(dateTimeNgayTao.Value, dateTimeNgayHuy.Value) == false)
                {
                    MessageBox.Show("Ngày tạo nhỏ hơn ngảy hết hạn -- Vui lòng nhập lại ngày hết hạn.");
                }
                else
                {
                    if (BLL_DocGia.Instance.AddDocGia(dg) == false)
                        MessageBox.Show("Thêm độc giả không thành công.");
                    else
                    {
                        MessageBox.Show("Thêm độc giả thành công.");
                        if (BLL_PhieuMuonTra.Instance.AddPhMuonTra(pmt) == false)
                            MessageBox.Show("Thêm phiếu mượn trả không thành công.");
                        else
                            MessageBox.Show("Thêm phiếu mượn trả thành công.");
                    }
                    ShowDG();
                    UserControlMuon.Instance.SetCBBPMT();
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            List<string> iddg = new List<string>();
            if (r.Count == 0)
                MessageBox.Show("Vui lòng lựa chọn độc giả.");
            else
            {
                foreach (DataGridViewRow i in r)
                {
                    iddg.Add(i.Cells["ID_ĐG"].Value.ToString());
                    BLL_DocGia.Instance.DelDocGia(iddg);
                }
                ShowDG();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(cbbluachon.SelectedIndex == 0)
            {
                DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
                if (r.Count == 1)
                {
                    txtIdDG.ReadOnly = true;
                    txtIdPMT.ReadOnly = true;
                    txtIdDG.Text = dataGridView1.SelectedRows[0].Cells["ID_ĐG"].Value.ToString();
                    txtNameDG.Text = dataGridView1.SelectedRows[0].Cells["Name_ĐG"].Value.ToString();
                    if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Gender"].Value) == true)
                    {
                        radioBNam.Checked = true;
                    }
                    else
                    {
                        radioBNu.Checked = true;
                    }
                    dateTimeNSinh.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Birth"].Value);
                    //bool gt = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Gender"].Value);
                    txtDiachi.Text = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                    txtSdtDG.Text = dataGridView1.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                }
            }
            else
            {

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtIdDG.ReadOnly = false;
            txtIdPMT.ReadOnly = false;
            txtIdDG.Text = "";
            txtNameDG.Text = "";


            txtDiachi.Text = "";
            txtSdtDG.Text = "";


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Độc_giả dg = new Độc_giả();
            //Thông tin độc giả
            if (txtIdDG.Text == "")
                MessageBox.Show("Vui lòng nhập mã độc giả.");
            else if (txtNameDG.Text == "")
                MessageBox.Show("Vui lòng nhập tên độc giả.");
            else if (txtDiachi.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ độc giả.");
            else if (txtSdtDG.Text == "")
                MessageBox.Show("Vui lòng nhập số điện thoại độc giả.");
            else
            {

                string Iddg = txtIdDG.Text;
                string Namedg = txtNameDG.Text;
                DateTime NgSinh = dateTimeNSinh.Value;
                bool gt;
                if (radioBNam.Checked)
                    gt = true;
                else
                    gt = false;
                string Diachi = txtDiachi.Text;
                string SDT = txtSdtDG.Text;
                if (BLL_DocGia.Instance.UpdateDocGia(Iddg, Namedg, NgSinh, gt, Diachi, SDT) == true)
                    MessageBox.Show("Sửa độc giả thành công.");
                else
                    MessageBox.Show("Thêm độc giả không thành công.");
                ShowDG();
            }
        }
    }
}
