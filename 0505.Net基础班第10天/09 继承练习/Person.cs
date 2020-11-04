using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_继承练习
{
    public class Person
    {
        string _name;
        public string Name { get => _name; set => _name = value; }
        char _gender;
        public char Gender { get => _gender; set => _gender = value; }
        int _age;
        public int Age { get => _age; set => _age = value; }
        public Person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
    public class Reporter : Person
    {
        public Reporter(string name,int age,char gender,string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }
        string _hobby;
        public string Hobby { get => _hobby; set => _hobby = value; }
        public void ReporterSayHello()
        {
            Console.WriteLine("我是{0},我的爱好是{1} 我的年龄是{2} 我是一个{3}狗仔",this.Name,this.Hobby,this.Age,this.Gender);
        }
    }

    public class Programmer : Person
    {
        public Programmer(string name,char gender,int age,int workYear):base(name,age,gender)
        {
            this.WorkYear = workYear;
        }
        int _workYear;
        public int WorkYear { get => _workYear; set => _workYear = value; }
        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0} 我的年龄是{1} 我是记者 我的工作年限是{2}年", this.Name, this.Age, this.WorkYear);
        }
    }
    public class Driver:Person
    {
        int _driveYear;
        public int DriveYear { get => _driveYear; set => _driveYear = value; }
        public Driver(string name,char gender,int age,int driveYear) : base(name, age, gender)
        {
            this.DriveYear = driveYear;
        }
        public void DriverSayHello()
        {
            Console.WriteLine("我叫{0} 我的年龄是{1} 我是{2}人 我的驾龄是{3}年", this.Name, this.Age, this.Gender, this.DriveYear);
        }
    }
}
