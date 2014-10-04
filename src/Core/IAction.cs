using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public interface IAction
    {
        string Name { get; set; }
        ActionType Type { get; set; }
        int Order { get; set; }
        void Execute();
    }
}
