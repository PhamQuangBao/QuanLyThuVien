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
    public partial class UserControlPass : UserControl
    {
        private static UserControlPass _instance;
        public static UserControlPass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlPass();
                return _instance;
            }
        }
        public UserControlPass()
        {
            InitializeComponent();
        }
        private void UserControlPass_Load(object sender, EventArgs e)
        {

        }
    }
}
