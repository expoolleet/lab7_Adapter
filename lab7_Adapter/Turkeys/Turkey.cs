using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_Adapter.Turkeys
{
    class Turkey
    {
        public void Fly() => Console.WriteLine("Индюк летит");
        public void Swim() => Console.WriteLine("Индюк плавает");
        public void Gaga() => Console.WriteLine("Индюк гагочет");
    }
}
