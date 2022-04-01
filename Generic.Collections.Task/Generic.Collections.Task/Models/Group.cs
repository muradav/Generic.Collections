using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Collections.Task.Models
{
    class Group
    {
        private static int _no=100;
        public string NO { get; }

        public Group()
        {
            //NO = no;

            //char last = NO[NO.Length - 1];
            //int lastnumber = (int)Char.GetNumericValue(last);
            //if (lastnumber <= 9)
            //{
            //    lastnumber = lastnumber + 1;
            //    last = (char)lastnumber;
            //}
            //Console.WriteLine(last);
            
            _no++;
            NO = "AP" + _no;

            students = new Student[0];



        }

        private Student[] students;

        public void AddStudents(Student stu)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = stu;
        }

        

        public void GetAllStudents()
        {
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
                Console.WriteLine("***************************");
            }

        }

        public void Sort()
        {
            Student minValue = students[0];
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i] > students[j])
                    {
                        minValue = students[j];
                        students[j] = students[i];
                        students[i] = minValue;
                    }
                }
            }
            foreach (Student item in students)
            {
                
                Console.WriteLine(item);
                Console.WriteLine("***************************");
            }
        }
    }
}
