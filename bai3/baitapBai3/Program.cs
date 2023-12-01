using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapBai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = -0.5f;
            int re = i1 + (i2 * i3);
            int re2 = i1 * (i2 + i3);
            float re3 = (float)i1 / (i2 + i3);
            float re4 = (float)i1 / i2 + i3;
            float re5 = 3 + (float)4 / 3;
            float re6 = (float)(3 + 4 + 5) / 3;
            float re7 = d1 + (d2 * d3);
            float re8 = d1 + d2 * d3;
            float re9 = d1 / d2 - d3;
            float re10 = d1 / (d2 - d3);
            float re11 = d1 + d2 + d3 / 3;
            float re12 = d1 + d2 + (d3 / 3);
            float re13 = 3 * (d1 + d2) * (d1 - d3);
            Console.WriteLine("dap an 1:{0},dap an 1:{1},dap an 1:{2},dap an 1:{3},dap an 1:{4},dap an 1:{5},dap an 1:{6}" +
                "dap an 1:{7},dap an 1:{8},dap an 1:{9},dap an 1:{10},dap an 1:{11},dap an 1:{12}", re,re2,re3,re4,re5,re6,re7,re8,re9,re10,re11,re12,re13);
            
            Console.ReadLine();

        }
    }
}
