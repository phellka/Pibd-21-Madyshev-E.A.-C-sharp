using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirfieldAlreadyHaveException :Exception
    {
        public AirfieldAlreadyHaveException() : base("На аэродроме уже есть такой самолет") { }
    }
}
