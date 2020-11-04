using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己练习
{
    class City
    {
        public string _name;
        public string _history;

        public void XianShi()
        {
            Console.WriteLine("{0}有{1}年的历史了", this._name, this._history);
        }
    }
}
