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
    public partial class UserControlTra : UserControl
    {
        private int _IDND;
        public int IDND { get => _IDND; set => _IDND = value; }

        private static UserControlTra _instance;
        BindingList<ViPham> vp = new BindingList<ViPham>();
        public static UserControlTra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlTra();
                return _instance;
            }
        }
        public UserControlTra()
        {
            InitializeComponent();
            SetView();
        }
        private void UserControlTra_Load(object sender, EventArgs e)
        {

        }
        public void SetCBBTLieu()
        {
            if (cbbTailieu.Items != null)
            {
                cbbTailieu.Items.Clear();
            }
            //duyệt từng tài liệu trong list các tài liệu
            foreach (Tài_Liệu i in BLL_PhieuTra.Instance.GetCBBTLieu(cbbPhTra.SelectedItem.ToString()))
            {
                cbbTailieu.Items.Add(new CBBItem
                {
                    Value = i.ID_TaiLieu,
                    Text = i.Name_TaiLieu
                });
            }
            
            cbbTailieu.SelectedItem = 1;
        }
        public void SetCBBPMT()
        {
            if (cbbPhTra.Items == null)
            {
                cbbPhTra.Items.Clear();
            }
            else
            {
                cbbPhTra.Items.Add(new CBBItem { Value = "", Text = "All" });//gián giá trị 0 và kiểu text là All vào CBBTheloai đồng tời add vào combobox
                foreach (Phieu_Muon_Tra i in BLL_PhieuTra.Instance.GetCBBPMT())
                {
                    cbbPhTra.Items.Add(new CBBItem//gán đối tượng thể loại sách vào CbbTheloai đồng thời add vào combox
                    {
                        Value = i.ID_ĐG,
                        Text = i.ID_MuonTra

                    });
                }
                cbbPhTra.SelectedIndex = 0;// lựa chọn item có giá trị = 0 tương ứng với kiểu dữ liệu text "All"
            }
        }
        public void SetView()
        {
            //SetCBBNgDung();
            SetCBBPMT();
            SetCBBTLieu();
            
        }
        public void Showpt()
        {
            dataGridView1.DataSource = BLL_PhieuTra.Instance.ShowALLPT();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Showpt();
            txtNgDung.ReadOnly = true;
            txtNgDung.Text = BLL_NguoiDung.Instance.GetNameND(IDND);
        }

        private void cbbPhTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_DG = ((CBBItem)cbbPhTra.SelectedItem).Value.ToString();
            txtDocGia.Text = BLL_DocGia.Instance.GetNameDG(ID_DG).ToString();
            if(cbbTailieu.Items != null)
            {
                cbbTailieu.Items.Clear();
                SetCBBTLieu();
               
            }
           // cbbTailieu.SelectedIndex = 1;

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Tài_Liệu tl = new Tài_Liệu();
            Phieu_Muon pm = new Phieu_Muon();
            Phieu_Tra pt = new Phieu_Tra();
            
            if (cbbPhTra.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng lựa chọn phiếu mượn.");
            }
            else if(cbbTailieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tài liệu muốn trả.");
            }
            else if(txtbsoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tài liệu.");
            }
            else if(cbbTTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng của tài liệu.");
            }
            else
            {
                string IDTLieu = ((CBBItem)cbbTailieu.SelectedItem).Value;
                int Soluong = Convert.ToInt32(txtbsoluong.Text);
                DateTime d1 = dateTimeTra.Value;
                tl.ID_TaiLieu = ((CBBItem)cbbTailieu.SelectedItem).Value;
                tl.SoLuong = Convert.ToInt32(txtbsoluong.Text);
                pm.ID_TaiLieu = ((CBBItem)cbbTailieu.SelectedItem).Value;
                pm.Count_ = Convert.ToInt32(txtbsoluong.Text);
                pt.ID_TaiLieu = ((CBBItem)cbbTailieu.SelectedItem).Value;
                pt.ID_PhieuTra = ((CBBItem)cbbPhTra.SelectedItem).Text;
                pt.ID_NguoiNhan = IDND;
                pt.Count_ = Convert.ToInt32(txtbsoluong.Text);
                pt.NgayTra = d1;
                pt.Trang_Thai_Tra = cbbTTrang.SelectedItem.ToString();
                if (cbbTTrang.SelectedIndex == 2)
                {
                    MessageBox.Show("Xử lý độc giả làm hỏng hoặc mất tài liệu");
                    vp.Add(new ViPham { Iddg = ((CBBItem)cbbPhTra.SelectedItem).Value, Lydo = "Hỏng hoặc làm mất" });
                    UserControlXLĐG.Instance.LIST = vp;
                    BLL_PhieuMuon.Instance.UpdatePhieuMuon(((CBBItem)cbbTailieu.SelectedItem).Value, Convert.ToInt32(txtbsoluong.Text));
                    BLL_PhieuMuon.Instance.DeletePhMuon(((CBBItem)cbbTailieu.SelectedItem).Value);
                    Showpt();
                    UserControlMuon.Instance.ShowDataGrid();
                }
                else
                {
                    int check = BLL_PhieuTra.Instance.KiemSoLuong(IDTLieu, Soluong, pm, tl, pt, d1);
                    if (check != 0)
                    {
                        if (check == 1)
                        {
                                MessageBox.Show("Độc giả trả đúng hạn!");
                                BLL_TaiLieu.Instance.UpdateTLieuTangSL(IDTLieu, Soluong);
                                Showpt();
                                UserControlMuon.Instance.ShowDataGrid();
                                UserControlQLTL.Instance.ShowTL();
                        }
                        else if(check == 2)
                        {
                            MessageBox.Show("Độc giả trả quá hạn. ");
                            vp.Add(new ViPham { Iddg = ((CBBItem)cbbPhTra.SelectedItem).Value, Lydo = "Trả quá hạn. " });
                            UserControlXLĐG.Instance.LIST = vp;
                            Showpt();
                            UserControlMuon.Instance.ShowDataGrid();
                            UserControlQLTL.Instance.ShowTL();
                        }
                    }

                    else
                        MessageBox.Show("Thực hiện không thành công!!!!!!!!!");
                }
            }
        }
    }
}
