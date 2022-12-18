using lab7_Adapter.Ducks;
using lab7_Adapter.Turkeys;

namespace lab7_Adapter.Adapters
{
    class DuckToTurkeyAdapter : IDuck
    {
        private readonly Turkey turkey;

        public DuckToTurkeyAdapter(Turkey turkey)
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
