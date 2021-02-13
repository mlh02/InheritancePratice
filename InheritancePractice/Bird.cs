using System;
namespace InheritancePractice
{
    public class Bird : Animal
    {
        public Bird(string species)
        {
            Species = species;
        }
        public Bird()
        {

            Species = "Birds";
            Eyes = 2;
        }
        public bool CanFly { get; set; }

    }
}
