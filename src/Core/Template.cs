using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace Wfe.Core
{
    public class Template
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
        TemplateStatus Status { get; set; }
        IEnumerable<State> States { get; set; }
        IIdentity Owner { get; set; }
        DateTime LastTimeUpdated { get; set; }
        Version Version { get; set; }
    }
}
