using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public class Student
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Student() { }

        public Student(long id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"i am {this.Id} {this.Name}");
        }

        


    }
}
