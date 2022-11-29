using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_Adapter.Ducks
{
    interface IDuck
    {
        static IDuck NullObject()
        {
            return new ObjectDuck();
        }
        void Fly();
        void Swim();
        void Quak();

        private class ObjectDuck : IDuck
        {


            void IDuck.Fly()
            {
            }

            void IDuck.Swim()
            {
            }

            void IDuck.Quak()
            {
            }
        }

    }

}
