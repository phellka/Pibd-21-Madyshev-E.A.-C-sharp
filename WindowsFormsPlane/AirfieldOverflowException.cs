using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirfieldOverflowException :Exception
    {
        public AirfieldOverflowException() : base("На аэродроме нет свободных мест") { }
    }
}
