using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace Wfe.Core
{
    public class Log
    {
        IIdentity User { get; set; }
        LogType LogType { get; set; }
        bool IsInternal { get; set; }
        string Description { get; set; }
        DateTime CreatedOn { get; set; }
    }
}
