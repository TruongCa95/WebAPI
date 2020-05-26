using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Core.Exceptions
{
    public class APIException : Exception
    {
        public APIException()
        {

        }
        public APIException(string message): base(message)
        {

        }
        public APIException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
