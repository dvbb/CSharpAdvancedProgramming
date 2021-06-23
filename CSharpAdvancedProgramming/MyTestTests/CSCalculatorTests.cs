using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace MyTest.Tests
{
    public class CSCalculatorTests
    {
        private IStudentProvider _provider;
        private Mock<IStudentRepository> _studentRepository;
        
        
        [SetUp]
        public void SetUp()
        {
            _studentRepository = new Mock<IStudentRepository>();
            _provider = new StudentProvider(_studentRepository.Object);
        }

        [Test]
        public async Task Test_MymoqTest_Success_With_None()
        {
            var request = new GetStudentRequest { 
                ProgramCode = "cbr",
                Sno = "20171316",
                RequestHeader = new RequestHeader {
                    RequestId = Guid.Empty,
                }
            };
            _studentRepository.Setup(x => x.GetStudent())
                .Returns(GetStudentList());
            var result =await _provider.GetStudentsTop20(request);
            Assert.IsNotNull(result);
        }

        public List<Student> GetStudentList()
        {
            List<Student> result = new List<Student>();
            result.Add(new Student
            {
                Sno = "20171316",
                Sname = "dvbb",
            });
            result.Add(new Student
            {
                Sno = "20170001",
                Sname = "hibi",
            });
            return result;
        }
    }
}