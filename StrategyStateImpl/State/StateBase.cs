using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    /// <summary>
    /// A common state ancestor for all traffic light states
    /// </summary>
    public abstract class StateBase
    {
        /// <summary>
        /// Allows change state of the context from another state
        /// </summary>
        public IContext Context { get; set; }

        /// <summary>
        /// Time of life of the state. It allows survive some predefined period before it changes to next state
        /// </summary>
        public int Period { get; set; }

        /// <summary>
        /// Color of the traffic light for the state
        /// </summary>
        public Color Color { get; }


        public StateBase(IContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Simulates a control clock to change states of traffic light
        /// </summary>
        public void TimeLapseTick()
        {
            Period--;
            if (Period == 0)
                ChangeToNextState();
        }

        /// <summary>
        /// Set the next state to the context
        /// </summary>
        protected abstract void ChangeToNextState();
    }
}
