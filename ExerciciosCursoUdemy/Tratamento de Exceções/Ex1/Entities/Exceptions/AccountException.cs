using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Entities.Exceptions
{
    public class AccountException: ApplicationException
    {
        public AccountException(string message): base(message)
        {
            
        }
    }
}