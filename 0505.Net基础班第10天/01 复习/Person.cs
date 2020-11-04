using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_复习
{
    public class Person  //类名之前必须加上public才能被其他项目访问
    {
        //字段 属性 方法 构造函数
        //字段：存储数据
        //属性：保护字段，对字段的取值和设值进行限定
        //方法：简述对象的行为
        //构造函数：初始化对象（给对象的每个属性依次赋值）
        //类中的成员，只要不加访问修饰符，默认都是private
        string _name;

        /// <summary>
        /// 属性的本质就是两个方法
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        //this:代表当前类的对象
        //     调用当前类的构造函数
        public void SayHello()//方法
        {
            Console.WriteLine("{0},{1},{2}", this.Name, this.Age, this.Gender);
        }
        
        //构造函数：1没有返回值，连void都没有 2构造函数的名称和类名一样
        public Person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person(string name,int age) : this(name,age,'c')//避免冗余代码，没用的数字设为0，没用的字符设为c，别忘了加（）
        {
        }
        public Person()
        {

        }
        public static void SayHelloTwo()
        {
            Console.WriteLine("Hello 我是静态的");
        }

    }
}
