using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_枚举练习
{
    public enum Name
    {
        孔子,
        孟子
    }
    public enum Regio
    {
        韩国,
        日本
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name name = Name.孔子;
            Regio regio = Regio.日本;

        }
    }
}
