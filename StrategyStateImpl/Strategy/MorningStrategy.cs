using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    /* HINT:
    /* UNCOMMENT ME WHEN RDY
    /// <summary>
    /// The strategy used for traffic control during morning hours
    /// </summary>
    public class MorningStrategy : Strategy
    {
        private int _time = 0;

        public MorningStrategy(Street street) : base(street)
        {
           // Calling base constructor
        }
        public override void ControlTraffic()
        {
            int counter = 0;

            foreach(TrafficLight light in Street.Lights)
            {
                if(_time - counter * LightDistance == 0)
                {
                    light.StartGoSequence();
                }
                else
                {
                    light.TimeLapseTick();
                }
                counter++;
            }
            _time++;
        }
    }
    */
}
