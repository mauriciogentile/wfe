using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public class Transition
    {
        State To { get; set; }
        IList<IAction> Actions { get; set; }
    }
}
