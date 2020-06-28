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
    public partial class UserControlHome : UserControl
    {
        private static UserControlHome _instance;
        public static UserControlHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlHome();
                return _instance;
            }
        }
        public UserControlHome()
        {
            InitializeComponent();
        }
        private void UserControlHome_Load(object sender, EventArgs e)
        {

        }
    }
}
