using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirfieldCollection
    {
        readonly Dictionary<string, Airfield<Vehicle>> airfieldStages;
        public List<string> Keys => airfieldStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public AirfieldCollection(int pictureWidth, int pictureHeight) {
            airfieldStages = new Dictionary<string, Airfield<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddAirfield(string name) {
            if (!airfieldStages.ContainsKey(name)) {
                airfieldStages.Add(name, new Airfield<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        public void DelAirfield(string name) {
            if (airfieldStages.ContainsKey(name)) {
                airfieldStages.Remove(name);
            }
        }
        public Airfield<Vehicle> this[string index]
        {
            get
            {
                if (airfieldStages.ContainsKey(index)) return airfieldStages[index];
                else return null;
            }
        }
    }
}
