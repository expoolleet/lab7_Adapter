using lab7_Adapter.Ducks;
using lab7_Adapter.Turkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_Adapter.Adapters
{
    class Duck_To_Turkey_Adapter : IDuck
    {

        private readonly Turkey turkey;
        public Duck_To_Turkey_Adapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
        }
        public void Swim()
        {
            turkey.Swim();
        }
        public void Quak()
        {
            turkey.Gaga();
        }
    }
}
