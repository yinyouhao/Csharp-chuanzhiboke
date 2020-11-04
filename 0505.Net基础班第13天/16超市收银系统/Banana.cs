using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    class Banana:ProductFather
    {
        private string v1;
        private int v2;
        private string v3;

        public Banana(string id,double price,double count) : base(id, price, count)
        {

        }

        public Banana(string v1, int v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
