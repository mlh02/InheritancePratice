using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What species is your animal? \n" 
                +
                "1 - Bird \n" +
                "2 - Reptile");
            int specAnswer = int.Parse(Console.ReadLine());
            if(specAnswer == 1)
            {
                Bird birdObj = new Bird();
                Console.WriteLine("What is the Name Of the Animal?");
                var name = Console.ReadLine();
                birdObj.Name = name;
                Console.WriteLine($"Can {name} flys? \n" +
                    $"1 - Yes \n" +
                    $"2 - No" );
                int flyOrNot = int.Parse(Console.ReadLine());
                bool mvnt;
                if (flyOrNot == 1)
                {
                     mvnt = true;
                }else
                {
                     mvnt = false;
                }
                birdObj.CanFly = mvnt;
                Console.WriteLine($"Skin type of {name}?");
                var skin = Console.ReadLine();
                birdObj.SkinType = skin;
                Console.WriteLine($"{birdObj.Name} is a {birdObj.Species}, which has {birdObj.Eyes} eyes, {birdObj.SkinType} for skin. You may ask yourself can {birdObj.Name} fly? {birdObj.CanFly} ");
            }
            if(specAnswer == 2)
            {
                Reptile reptileObj = new Reptile();

                Console.WriteLine("What is the Name Of the Animal?");
                var name = Console.ReadLine();
                reptileObj.Name = name;
                Console.WriteLine($"How Does {name} get around?");
                var mvnt = Console.ReadLine();
                reptileObj.Mobility = mvnt;
                Console.WriteLine($"Skin type of {name}?");
                var skin = Console.ReadLine();
                reptileObj.SkinType = skin;
                Console.WriteLine($"{reptileObj.Name} is a {reptileObj.Species}, which has {reptileObj.Eyes} eyes, {reptileObj.SkinType} for skin, and travels using {reptileObj.Mobility} ");
            }
           
        }
    }
    
}
