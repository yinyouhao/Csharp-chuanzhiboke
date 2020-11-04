using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //概念：让一个对象能够表现出多种状态（类型）
            //实现多态的3种手段：1、虚方法 2、抽象类 3、接口
            Chinese ch1 = new Chinese("zhangas");
            Chinese ch2 = new Chinese("haifhfa");
            Janpanse jp1 = new Janpanse("fjaif");
            Janpanse jp2 = new Janpanse("fahfna");
            Korea ke1 = new Korea("jafhfhau");
            Korea ke2 = new Korea("jifh");
            American an1 = new American("fjaif");
            American an2 = new American("ofppd");
            Person[] per = { ch1, ch2,jp1,jp2,ke1,ke2,an1,an2 };
            for (int i = 0; i < per.Length; i++)
            {
                per[i].SayHello();
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese:Person
    {
        public Chinese(string name)
            : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }

    public class Janpanse : Person
    {
        public Janpanse(string name) : base(name)
        {

        }
        public override void  SayHello()
        {
            Console.WriteLine("我是日本人，我的名字叫{0}", this.Name);
        }
    }

    public class Korea : Person
    {
        public Korea(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}", this.Name);
        }
    }

    public class American : Person
    {
        public American(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我叫{0}", this.Name);
        }
    }
}
