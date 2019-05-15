using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    public class TrafficLight : IContext
    {

        public StateBase State { get; set; } //= new Stop(this); UNCOMMENT ME WHEN RDY

        public void SetState(StateBase state)
        {
            State = state;
        }

        public Color GetLightColor()
        {
            return State.Color;
        }

        /// <summary>
        /// Begin a sequence of ORANGE - GREEN - ORANGE - RED
        /// </summary>
        public void StartGoSequnce()
        {
            // UNCOMMENT ME WHEN RDY
            //SetState(new AttentionPrepare(this));
        }

        public void TimeLapseTick()
        {
            State.TimeLapseTick();
        }
    }
}
