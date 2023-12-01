using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class HocSinh
    {
        //auto-implemented properlies
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        //phuong thuc tostring
        public override string ToString()
        {
            return this.Name+"\t"+this.Mail+"\t"+this.Phone;

        }
    }
}
