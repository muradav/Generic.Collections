using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Collections.Task.Models
{
    class Student
    {
        private static int _id;
        public int ID { get;}

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public double Point { get; set; }

        public Student(string name,string surname, double point)
        {
            Name = name;
            Surname = surname;
            Point = point;
            _id++;
            ID = _id;

        }
        

        public static bool operator >(Student stu1,Student stu2)
        {
            return stu1.Point > stu2.Point;
        }
        public static bool operator <(Student stu1, Student stu2)
        {
            return stu1.Point < stu2.Point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID} \n" +
                $"Name: {Name} \n" +
                $"Surname: {Surname} \n" +
                $"Age: {Age} \n" +
                $"Point: {Point}");
        }
        public override string ToString()
        {
            return $"ID: {ID} \n" +
                $"Name: {Name} \n" +
                $"Surname: {Surname} \n" +
                $"Age: {Age} \n" +
                $"Point: {Point}";
        }

    }
}
