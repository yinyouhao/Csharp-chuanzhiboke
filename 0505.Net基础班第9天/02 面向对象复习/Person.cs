using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_面向对象复习
{
    public class Person//建好类之后 现在class之前加个public
    {
        //字段 属性 方法
        private string _name;//默认private
        public string Name
        {
            get { 
                if(_name!="孙权")
                {
                    _name = "孙权";
                }
                return _name; }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                //if (_gender != '男' && _gender != '女')
                //{
                //    _gender = '男';
                //}
                return _gender; }//get里面判断字段的值
            set {
                if (value != '男' && value != '女')
                {
                    value = '男';
                }
                _gender = value; }//set判断value的值
        }
        public void Hello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，性别{2}",this._name,this.Age,this.Gender);
        }
    }
}
