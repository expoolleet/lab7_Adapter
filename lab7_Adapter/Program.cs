using lab7_Adapter.Adapters;
using lab7_Adapter.Ducks;
using lab7_Adapter.Turkeys;
using System;

namespace lab7_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey turkey = new Turkey();
            IDuck fake_duck = new Duck_To_Turkey_Adapter(turkey);
            IDuck real_duck1 = new DomesticDuck();
            IDuck real_duck2 = new WildDuck();

            IDuck[] ducks = new IDuck[3];
            ducks[0] = fake_duck;
            ducks[1] = real_duck1;
            ducks[2] = real_duck2;

            foreach (var duck in ducks)
            {
                duck.Fly();
                duck.Swim();
                duck.Quak();
            }
        }
    }
}
