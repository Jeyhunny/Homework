using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree_Convert.Models
{
    public class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Degree - 273);
        }
    }
}
