using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public interface IWorkflowController
    {
        void ExecuteTransition(string transitionName);
        void MoveTo(string stateName);
        void Abort();
        void Pause();
    }
}
