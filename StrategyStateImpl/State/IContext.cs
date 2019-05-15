using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    public interface IContext
    {
        /// <summary>
        /// Set state to its context
        /// </summary>
        /// <param name="state"></param>
        void SetState(StateBase state);
    }
}
