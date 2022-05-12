using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ActorAgeCalculator
{
    public class MovieStar
    {
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
    }
}
