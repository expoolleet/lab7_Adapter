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
            //  IDuck real_duck = new DomesticDuck();

            //fake_duck.Fly();
            //fake_duck.Swim();
            //fake_duck.Quak();

            //real_duck.Fly();
            //real_duck.Swim();
            //real_duck.Quak();
            IDuck objDuck = IDuck.NullObject();
            objDuck.Fly();

            //IDuck[] ducks = new IDuck[2];
            //ducks[0] = fake_duck;
            //ducks[1] = real_duck;
            //foreach (var duck in ducks)
            //{
            //    duck.Fly();
            //    duck.Swim();
            //    duck.Quak();
            //}
        }
    }
}
