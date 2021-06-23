using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest
{
    public interface IStudentRepository
    {
        Student GetStudentBySno(string Sno);
        IEnumerable<Student> GetStudent();
        void InsertStudent(string Sno, string Sname);
    }
}
