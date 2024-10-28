using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
//    Planet Class
//===================
//PlanetId
//Name
//Area

    public class Planet
    {
        public Planet(int planetId, string name, string area)
        {
            PlanetId = ++planetId;
            Name = name;
            Area = area;
        }

        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string    Area { get; set; }

        public override string ToString()
        {
            return $"Name {Name}  Area {Area}";
          
        }
    }
}
