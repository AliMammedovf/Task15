using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Exceptions
{
    public class ClassFoundNotException: Exception
    {
        public ClassFoundNotException(string message) : base(message) 
        {
            message = message;
        }
    }
}
