using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    /// <summary>
    /// Common strategy class that defines execution method providing the strategy implementation
    /// </summary>
    public abstract class Strategy
    {
        /// <summary>
        /// Data about traffic lights
        /// </summary>
        protected Street Street { get; }

        /// <summary>
        /// Distance of the traffic lights
        /// </summary>
        protected int LightDistance = 5;

        public Strategy(Street street)
        {
            Street = street;
        }

        /// <summary>
        /// The execution strategy method
        /// </summary>
        public abstract void ControlTraffic();
    }
}
