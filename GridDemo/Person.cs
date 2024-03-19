using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridDemo
{
    public class Person
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Geslacht { get; set; }
        public string Land { get; set; }

        public Person(string naam, int leeftijd, string geslacht, string land) 
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Geslacht = geslacht;
            Land = land;
        }
    }
}
