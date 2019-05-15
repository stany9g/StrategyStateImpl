using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Street street = new Street(5, 10, DateTime.Now);
            street.RunTrafficLights();
        }
    }
}
