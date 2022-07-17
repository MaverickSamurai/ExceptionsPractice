using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsPractice.Exceptions
{
    public class DivideExceptions : Exception
    {
        public DivideExceptions(string mesage):base(mesage)
        {

        }
    }
}
