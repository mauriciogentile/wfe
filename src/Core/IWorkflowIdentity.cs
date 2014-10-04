using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace Wfe.Core
{
    public interface IIdentityGroup
    {
        string Name { get; set; }
        IEnumerable<IIdentity> Resolve();
    }
}
