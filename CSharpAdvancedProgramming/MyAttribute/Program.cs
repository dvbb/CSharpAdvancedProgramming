using MyAttribute.Extension;
using System;
using System.Collections.Generic;

namespace MyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //attribute的用法①：给一个对象赋予额外信息
            Console.WriteLine(UserState.Normal.GetRemark());
            Console.WriteLine(UserState.Frozen.GetRemark());
            Console.WriteLine(UserState.Deleted.GetRemark());

            //attribute的用法②：验证数据的合法性
            Student stu1 = new Student(20171316, "ninomiya");
            Student stu2 = new Student(19985214, "shadow");
            Student stu3 = new Student(20182214, "kino");
            Student stu4 = new Student(20501994, "shitami");
            List<Student> stuList = new List<Student>();
            stuList.Add(stu1);
            stuList.Add(stu2);
            stuList.Add(stu3);
            stuList.Add(stu4);
            Console.WriteLine("\n\n");
            foreach (var stu in stuList)
            {
                //调用Student的扩展方法Validate(),验证id是否正确
                if (stu.Validate())
                {
                    stu.Show();
                }
            }
        }
    }
}
