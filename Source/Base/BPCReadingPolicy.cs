using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;

namespace BetterPawnControl.Base
{
    internal class BPCReadingPolicy : ReadingPolicy
    {
        protected override string LoadKey => "BPCReadingPolicy" + ToString() + Guid.NewGuid();

        public BPCReadingPolicy() : base()
        {

        }
        public BPCReadingPolicy(int id, string label) : base(id, label)
        {
        }

        public static BPCReadingPolicy ConvertFromVanilla(ReadingPolicy policy)
        {
            return new BPCReadingPolicy(policy.id, policy.label);
        }
    }
}
