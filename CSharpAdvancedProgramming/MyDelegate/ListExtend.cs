using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public class ListExtend
    {

        //自定义委托，比较年龄、id
        public delegate bool ThanDelegate(Student student);
        private bool Than1(Student student)
        {
            return student.Age > 20;
        }
        private bool Than2(Student student)
        {
            return student.Name.Length > 5;
        }

        private List<Student> GetList(List<Student> source, ThanDelegate method)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in source)
            {
                //执行委托的方法，返回bool类型
                //及传入判断条件，返回List<>
                //实现了逻辑解耦，减少重复代码
                if (method.Invoke(student))
                {
                    result.Add(student);
                }
            }
            return result;
        }

        public void Show1(List<Student> stuList)
        {
            //ThanDelegate是一个委托，委托实例化必须要传递一个方法
            //此时传入判断条件 student.Age > 20
            //调用GetList方法，或许条件判断通过的列表
            ThanDelegate method = new ThanDelegate(this.Than1);
            List<Student> result1 = this.GetList(stuList, method);
            foreach (Student student in result1)
            {
                student.Show();
            }
        }

        public void Show2(List<Student> stuList)
        {
            ThanDelegate method = new ThanDelegate(this.Than2);
            List<Student> result1 = this.GetList(stuList, method);
            foreach (Student student in result1)
            {
                student.Show();
            }
        }

    }
}
