using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManyHandle
{
    public abstract class CommandHandlerBase<TRequest, TResponse>
    {
        public abstract Task<TResponse> Handle(TRequest request);

        public void HandleAsync(TRequest request)
        {
            Handle(request);
        }


    }
}
