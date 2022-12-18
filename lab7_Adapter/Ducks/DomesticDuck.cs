using System;

namespace lab7_Adapter.Ducks
{
    class DomesticDuck : IDuck
    {
        public string Name { get; }

        public DomesticDuck()
        {
            Name = "Домашняя утка";
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летит");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плывет");
        }

        public void Quak()
        {
            Console.WriteLine($"{Name} крякает");
        }
    }
}
