using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public class State : IComparable<State>
    {
        string Name { get; set; }
        IEnumerable<Transition> Transitions { get; set; }

        public int CompareTo(State other)
        {
            return other.Name.CompareTo(Name);
        }
    }
}
