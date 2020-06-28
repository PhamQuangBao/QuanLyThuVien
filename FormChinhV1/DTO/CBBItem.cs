using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinhV1.DTO
{
    public class CBBItem
    {
        private string _Value;
        private string _Text;

        public string Value { get => _Value; set => _Value = value; }
        public string Text { get => _Text; set => _Text = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}
