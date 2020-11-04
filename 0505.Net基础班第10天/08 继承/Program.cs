using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("学生", 18, '男', 101);

        }
    }
    public class Person
    {
        string _name;
        public string Name { get => _name; set => _name = value; }
        int _age;
        public int Age { get => _age; set => _age = value; }
        char _gender;
        public char Gender { get => _gender; set => _gender = value; }
        public void CHLSS()
        {
            Console.WriteLine("chafhanf");
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person()
        {

        }

    }
    public class Student : Person //把类写在这是为了方便教学，实际应用时类不能写在这
    {
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            this.ID = id;
        }

        int _id;
        public int ID
        {
            get { return _id; }
            set { value = _id; }
        }

    }
    public class Teacher : Person
    {
        public Teacher(string name, int age, char gender, double salary)
            : base(name, age, gender)
        {
            this.Salary = salary;
        }
        double _salary;
        public double Salary
        {
            get { return _salary; }
            set { value = _salary; }
        }

        public void Teach()
        {
            Console.WriteLine("老师会讲课");
        }
    }
    public class Driver : Person
    {
        public Driver(string name, int age, char gender, int drivetime)
            : base(name, age, gender) 
        {
            this.DriveTime = drivetime;
        }
        int _driveTime;
        public int DriveTime { get => _driveTime; set => _driveTime = value; }
        public void Driving()
        {
            Console.WriteLine("司机会开车");
        }


    }


}
