using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class MaxiException : Exception
    {
        public MaxiException(string message) : base(message)
        {
        }
    }
}
