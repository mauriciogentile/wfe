using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public enum LogType
    {
        WorkflowCreated,
        TransitionRequested,
        TransitionExecuted,
        WorkflowAborted,
        ActionExecuted,
        ActionAttempted
    }
}
