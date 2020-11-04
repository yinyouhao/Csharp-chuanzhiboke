using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_面向对象
{
    public class Person
    {
        private string _name;
        public string Name
        {
            //当你输出属性的值得时候，会执行get方法
            get { return _name; }
            //当你给属性赋值的时候，首先会执行set方法
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {

                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;//字段？
        public char Gender//属性？
        {
            get {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }
        public  void CHLSS()//方法
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }
    }

}
