using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace Wfe.Core
{
    public class Workflow
    {
        long Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        InstantiationType CreationType { get; set; }
        State CurrentState { get; set; }
        IEnumerable<State> States { get; set; }
        WorkflowStatus Status { get; set; }
        string CorelationId { get; set; }
        Dictionary<string, object> CutomData { get; set; }
        IEnumerable<Log> Log { get; set; }
        IIdentityGroup Owner { get; set; }
        IEnumerable<WorkflowPermission> Permissions { get; set; }
        int TemplateId { get; set; }
        Version TemplateVersion { get; set; }
        string Timestamp { get; set; }
    }
}
