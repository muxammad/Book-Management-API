using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Managment.Application.Exceptions
{
    public class CustomException : Exception
    {
        public int StatusCode { get; }

        public CustomException(int code, string message) : base(message)
        {
            StatusCode = code;
        }

        public CustomException(string message) : base(message)
        {
            
        }
    }


}
