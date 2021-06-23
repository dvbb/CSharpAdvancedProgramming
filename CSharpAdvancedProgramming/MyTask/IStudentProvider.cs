using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{
    public interface IStudentProvider
    {
        Task<List<Student>> GetStudent(JArray resource);
        List<Student> Sync_Student(JArray resource);
    }
}
