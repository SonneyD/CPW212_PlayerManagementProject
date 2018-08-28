using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule.Exceptions
{
    public class InvalidObjectPointer : Exception
    {
        public InvalidObjectPointer() { }
        public InvalidObjectPointer(string message) : base(message){ }
        public InvalidObjectPointer(string msg, Exception inner) : base(msg, inner) { }
    }
    public class InvalidUsername : Exception
    {
        public InvalidUsername() { }
        public InvalidUsername(string message) : base(message){}
        public InvalidUsername(string msg, Exception inner) : base(msg, inner) { }
    }
    public class InvalidPassword : Exception
    {
        public InvalidPassword() { }
        public InvalidPassword(string message) : base(message) { }
        public InvalidPassword(string msg, Exception inner) : base(msg, inner) { }
    }
}
