using System;

namespace CatsAndDogsOOP
{
    class Program
    {

        class Pet
        {
            public string name;
            public string color;
            public int levelOfHapiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Level of hapiness: {levelOfHapiness}\n");
            }
        }

        class Dog : Pet
        {
            public Dog (string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHapiness = 0;
            }

            public void WaveTail()
            {
                levelOfHapiness++;
            }

            public bool Bark()

            {
                Console.WriteLine("Woof-woof!");
                return true;
            }

           
        }
        class Cat : Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHapiness = 10;
            }

            public void HearTheDog()
            {
                levelOfHapiness = 0;
            }

            public void Hiss()
            {
                Console.WriteLine("Hssssss");
            }
        }
        static void Main(string[] args)
        {
            Dog koer = new Dog("Bolt", "white");
            koer.PrintPetInfo();
            Cat kass = new Cat("Blacky","black");
            kass.PrintPetInfo();

            for (int i = 0; i < 10; i++)
            {
                koer.WaveTail();
            }

            if (koer.Bark())
            {
                kass.HearTheDog();
            }

            if (kass.levelOfHapiness ==0)
            {
                kass.Hiss();
            }
           
        }
    }
}
