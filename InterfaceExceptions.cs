using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class InterfaceException : Exception
    {
        public InterfaceException() { }
        public InterfaceException(string message) : base(message) { }
        public InterfaceException(string message, Exception inner) : base(message, inner) { }
       
    
    }
}
