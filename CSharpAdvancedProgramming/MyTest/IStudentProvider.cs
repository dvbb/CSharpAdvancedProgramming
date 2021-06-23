using MyTest.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
   public interface IStudentProvider
    {
        Task<GetStudentTop20Response> GetStudentsTop20(GetStudentRequest request);

    }
}
