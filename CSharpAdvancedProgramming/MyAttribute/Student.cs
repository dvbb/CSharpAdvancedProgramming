using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    public class Student
    {
        //使用attribute，定义id的范围
        [Long(20150000,20209999)]
        public long Id { get; set; }

        public string Name { get; set; }

        public Student() { }

        public Student(long id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Show()
        {
            Console.WriteLine($"i am {this.Id} {this.Name}");
        }
    }
}
