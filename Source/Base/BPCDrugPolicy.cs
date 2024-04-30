using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;

namespace BetterPawnControl.Base
{
    internal class BPCDrugPolicy : DrugPolicy
    {
        protected override string LoadKey => "BPCDrugPolicy" + ToString() + Guid.NewGuid();

        public BPCDrugPolicy() : base()
        {

        }
        public BPCDrugPolicy(int id, string label) : base(id, label)
        {
        }

        public static BPCDrugPolicy ConvertFromVanilla(DrugPolicy policy)
        {
            return new BPCDrugPolicy(policy.id, policy.label);
        }
    }
}
