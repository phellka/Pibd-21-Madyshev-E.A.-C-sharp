using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirfieldVehicleNotFoundException :Exception
    {
        public AirfieldVehicleNotFoundException(int index) : base("Не найден самолет по месту " + index) { }

    }
}
