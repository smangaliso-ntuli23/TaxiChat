using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InvalidValueProvided : Exception
    {
        public InvalidValueProvided() { }
        public InvalidValueProvided(string message) : base(message) { }
        public InvalidValueProvided(string message, Exception inner) : base(message, inner) { }
  
    }
}
