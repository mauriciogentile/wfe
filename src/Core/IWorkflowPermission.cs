using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public class WorkflowPermission
    {
        IEnumerable<IIdentityGroup> Holders { get; set; }
        Securable Target { get; set; }
        AccessType Access { get; set; }
    }
}
