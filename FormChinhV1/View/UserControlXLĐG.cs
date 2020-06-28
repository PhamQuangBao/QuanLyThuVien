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
    public partial class UserControlXLĐG : UserControl
    {
        private int _IDND;

        public int IDND { get => _IDND; set => _IDND = value; }
        private BindingList<ViPham> _LIST;
        public BindingList<ViPham> LIST { get => _LIST; set => _LIST = value; }

        private static UserControlXLĐG _instance;
        public static UserControlXLĐG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlXLĐG();
                return _instance;
            }
        }
        public UserControlXLĐG()
        {
            InitializeComponent();
            cbbhinhthuc.SelectedIndex = 0;
        }
        private void UserControlXLĐG_Load(object sender, EventArgs e)
        {

        }
        public void ShowDocGia()
        {
            //if (IDDG == "")
            //    MessageBox.Show("Chưa có độc giả vi phạm.");
            //else
            //{
            dataGridView1.DataSource = LIST;
                //txtTenDG.ReadOnly = true;
                //txtNDung.ReadOnly = true;
                //txtTenDG.Text = dg.Name_ĐG;
            //}

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDocGia();
            txtNDung.Text = BLL_NguoiDung.Instance.GetNameND(IDND);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count == 1)
            {
                txtIDDG.Text = dataGridView1.SelectedRows[0].Cells["Iddg"].Value.ToString();
                txtLydoXP.Text = dataGridView1.SelectedRows[0].Cells["Lydo"].Value.ToString();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txtGhichu.Text == "")
                MessageBox.Show("Vui lòng nhập ghi chú.");
            else
            {
                Độc_Giả_Vi_Phạm vp = new Độc_Giả_Vi_Phạm();
                vp.ID_Độc_Giả = txtIDDG.Text;
                vp.ID_Nguoi_Xu_Phat = IDND;
                vp.Hinh_thuc_xu_phat = cbbhinhthuc.SelectedItem.ToString();
                vp.Li_do_xu_phat = txtLydoXP.Text;
                vp.Ngay_xu_phat = dateTimeXP.Value;
                vp.GhiChu = txtGhichu.Text;
                if (BLL_DGViPham.Instance.AddVipham(vp) == true)
                {
                    MessageBox.Show("Xử lý thành công.");
                    int index = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(index);
                }
                else
                    MessageBox.Show("Xử lý thất bại.");
            }
        }
    }
    //List là một kiểu mảng động, có vài chức năng sort là các kiểu dữ liệu cho trước,
    //BidingList
}
