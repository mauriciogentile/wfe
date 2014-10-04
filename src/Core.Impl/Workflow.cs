using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace Wfe.Core.Impl
{
    public class Workflow : Workflow
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public InstantiationType CreationType { get; set; }
        public IState CurrentState { get; set; }
        public WorkflowStatus Status { get; set; }
        public string CorelationId { get; set; }
        public object CutomData { get; set; }
        public IEnumerable<Log> Log { get; set; }
        public IIdentity Owner { get; set; }
    }
}
