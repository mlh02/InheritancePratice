using System;
namespace InheritancePractice
{
    public class Reptile : Animal
    {
        public Reptile(string species)
        {
            Species = species;
        }
        public Reptile()
        {

            Species = "Reptile";
            Eyes = 2;
        }
      
        public string Mobility { get; set; }

    }
}
