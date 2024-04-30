using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;

namespace BetterPawnControl.Base
{
    internal class BPCFoodPolicy : FoodPolicy
    {
        protected override string LoadKey => "BPCFoodPolicy" + ToString() + Guid.NewGuid();

        public BPCFoodPolicy() : base()
        {

        }
        public BPCFoodPolicy(int id, string label) : base(id, label)
        {
        }

        public static BPCFoodPolicy ConvertFromVanilla(FoodPolicy policy)
        {
            return new BPCFoodPolicy(policy.id, policy.label);
        }
    }
}
