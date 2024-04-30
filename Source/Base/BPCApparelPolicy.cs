using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;

namespace BetterPawnControl.Base
{
    internal class BPCApparelPolicy : ApparelPolicy
    {
        protected override string LoadKey => "BPCApparelPolicy" + ToString() + Guid.NewGuid();

        public BPCApparelPolicy() : base()
        {

        }
        public BPCApparelPolicy(int id, string label) : base(id, label)
        {
        }

        public static BPCApparelPolicy ConvertFromVanilla(ApparelPolicy policy)
        {
            return new BPCApparelPolicy(policy.id, policy.label);
        }
    }
}
