using Generic.Collections.Task.Models;
using System;

namespace Generic.Collections.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            Student stu = new Student("Murad", "Valiyev", 50);
            Student stu1 = new Student("Azad", "Valiyev", 46);
            Student stu2 = new Student("Ceyhun", "Valiyev", 55);


            Group group1 = new Group();
            Group group2 = new Group();
            Group group3 = new Group();

            Console.WriteLine(group.NO);
            Console.WriteLine(group1.NO);
            Console.WriteLine(group2.NO);
            Console.WriteLine(group3.NO);

            group.AddStudents(stu);
            group.AddStudents(stu1);
            group.AddStudents(stu2);

            group.GetAllStudents();
            

            group.Sort();


        }
    }
}
