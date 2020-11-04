using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象练习
{
    public class Student
    {
        //字段 属性 方法 构造函数

        //析构函数 构造函数

        //当程序结束的时候，析构函数才会执行 作用：帮助我们释放资源
        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }

        public Student(string name,char gender,int age,int chinese,int math,int english)//构造函数
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Student(string name,int chinese,int math,int english):this(name,'j',0,chinese,math,english)
        {
            //this.Name = name;
            //this.Chinese = chinese;
            //this.Math = math;
            //this.English = english;
        }

        public Student(string name, char gender, int age)//构造函数
        {
            //this.Name = name;
            //this.Gender = gender;
            //this.Age = age;
        }



        private string _name;//字段
        public string Name   //属性
        {
            get { return _name; }
            set { _name = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set {
                
                if (value != '男' && value != '女')
                {
                    value = '男';
                }
                _gender = value;
            }
        }
        private int _age;
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
        int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set {
                if (value > 100 || value < 0)
                {
                    value = 0;
                } 
                _chinese = value; }
        }
        int _math;
        public int Math
        {
            get { return _math; }
            set {
                if(value>100||value<0)
                {
                    value = 0;
                }
                _math = value; }
        }
        int _English;
        public int English
        {
            get { return _English; }
            set
            {
                if (value > 100 || value < 0)
                {
                    value = 0;
                }
                _English = value; }
        }
        public void ChengJi()
        {
            Console.WriteLine("我叫{0}，性别{1}，今年{2}岁，我的语文成绩为{3}，数学成绩为{4}，英语成绩为{5}。", this.Name, this.Gender, this.Age, this.Chinese, this.Math, this.English);
        }
    }
}
