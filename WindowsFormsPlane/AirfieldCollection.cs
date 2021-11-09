using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separator = ':';
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
        public bool saveData(string fileName) {
            if (File.Exists(fileName)) {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName)) {
                sw.Write($"AirfieldCollection{Environment.NewLine}");
                foreach (var level in airfieldStages) {
                    sw.Write($"Airfield{separator}{level.Key}{Environment.NewLine}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value[i]) != null; i++) {
                        if (plane != null) {
                            if (plane.GetType().Name == "Plane") {
                                sw.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "PlaneRadar") {
                                sw.Write($"PlaneRadar{separator}");
                            }
                            sw.Write(plane + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
        public bool loadData(string fileName) {
            if (!File.Exists(fileName)) {
                return false;
            }
            using (StreamReader sr = new StreamReader(fileName)) {
                string line = sr.ReadLine();
                if (line.Contains("AirfieldCollection")) {
                    airfieldStages.Clear();
                }
                else {
                    return false;
                }
                Vehicle plane = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null) {
                    if (line.Contains("Airfield")) {
                        key = line.Substring(line.IndexOf(separator) + 1);
                        airfieldStages.Add(key, new Airfield<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line)) {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Plane") {
                        plane = new Plane(line.Split(separator)[1]);
                    }
                    else {
                        if (line.Split(separator)[0] == "PlaneRadar") {
                            plane = new PlaneRadar(line.Split(separator)[1]);
                        }
                    }
                    if (!airfieldStages.ContainsKey(key)) {
                        return false;
                    }
                    var result = airfieldStages[key] + plane;
                    if (result == -1) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
