using System;
using System.Collections.Generic;
using static MyDelegate.ListExtend;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student(20171316, "ninomiya", 22);
            Student stu2 = new Student(19985214, "shadow", 25);
            Student stu3 = new Student(20182214, "kino", 16);
            Student stu4 = new Student(20501994, "shitami", 18);
            List<Student> stuList = new List<Student>();
            stuList.Add(stu1);
            stuList.Add(stu2);
            stuList.Add(stu3);
            stuList.Add(stu4);

            Console.WriteLine("than 1 ：");
            ListExtend listExtend1 = new ListExtend();
            listExtend1.Show1(stuList);

            Console.WriteLine("\n\nthan 2 ：");
            ListExtend listExtend2 = new ListExtend();
            listExtend2.Show2(stuList);
        }
    }
}
