using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManyHandle
{
    public class AccountHandler : CommandHandlerBase<string,string>
    {
        public override Task<string> Handle(string request)
        {
            Console.WriteLine("user ");
            return Task.FromResult("ss");
        }
    }
}
