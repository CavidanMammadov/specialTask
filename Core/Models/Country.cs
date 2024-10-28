using Core.Helper.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    //    //
    //    Country Class
    //=================
    //CountryId
    //CountryName
    //Area
    //Anthem
    //Region(ENUM)

    internal class Country
    {
        public Region Region { get; set; }
        public Country(string countryName, double area, string anthem)
        {
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
        }
        double _area;

        public string CountryName { get; set; }
        public double Area
        {
            get { return _area; }
            set
            {
                if(value>0)
                {
                    _area = value;
                }
                    }
        }
        public string Anthem { get; set; }
        




    }
}
