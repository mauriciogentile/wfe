using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfe.Core
{
    public interface IActionExecutor
    {
        Task<ActionExecutionResult> ExecuteActions(params IAction[] actions);
    }
}
