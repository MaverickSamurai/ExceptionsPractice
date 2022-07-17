using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsPractice.Exceptions
{
    public class FindNameException: Exception
    {
        public FindNameException(string mesage) : base(mesage)
        {

        }
    }
}
