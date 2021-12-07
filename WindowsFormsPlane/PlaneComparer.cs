using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class PlaneComparer :IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y) {
            if (x.GetType() != y.GetType()) {
                return y.GetType().Name.CompareTo(x.GetType().Name);
            }
            if (x.maxSpeed != y.maxSpeed) {
                return x.maxSpeed.CompareTo(y.maxSpeed);
            }
            if (x.weight != y.weight) {
                return x.weight.CompareTo(y.weight);
            }
            if (x.mainColor != y.mainColor) {
                return x.mainColor.Name.CompareTo(y.mainColor.Name);
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y) {
            if (x.maxSpeed != y.maxSpeed) {
                return x.maxSpeed.CompareTo(y.maxSpeed);
            }
            if (x.weight != y.weight) {
                return x.weight.CompareTo(y.weight);
            }
            if (x.mainColor != y.mainColor) {
                return x.mainColor.Name.CompareTo(y.mainColor.Name);
            }
            return 0;
        }
        private int ComparerPlaneRadar(PlaneRadar x, PlaneRadar y) {
            var res = ComparerPlane(x, y);
            if (res != 0) {
                return res;
            }
            if (x.dopColor != y.dopColor) {
                return x.dopColor.Name.CompareTo(y.dopColor.Name);
            }
            if (x.hvEngine != y.hvEngine) {
                return x.hvEngine.CompareTo(y.hvEngine);
            }
            if (x.hvRadar != y.hvRadar) {
                return x.hvRadar.CompareTo(y.hvRadar);
            }
            return 0;
        }
    }
}
