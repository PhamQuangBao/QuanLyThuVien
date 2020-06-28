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
    public partial class UserControlBC : UserControl
    {
        private static UserControlBC _instance;
        public static UserControlBC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlBC();
                return _instance;
            }
        }
        public UserControlBC()
        {
            InitializeComponent();
        }
        private void UserControlBC_Load(object sender, EventArgs e)
        {

        }
    }
}
