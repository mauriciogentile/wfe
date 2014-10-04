using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public class ActionExecutionResult
    {
        bool AllActionsExecuted { get; set; }
        AggregateException Exceptions { get; set; }
    }
}
