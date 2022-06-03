using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo
{
    internal class CustomException:Exception
    {
        public CustomException():base("Message Of Custom Exception")
        {

        }
    }
}
