using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.DTO
{
    public class ViPham
    {
        private string _Iddg;
        private string _Lydo;

        public string Iddg { get => _Iddg; set => _Iddg = value; }
        public string Lydo { get => _Lydo; set => _Lydo = value; }
    }
}
