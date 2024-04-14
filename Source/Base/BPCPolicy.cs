using Verse;
using RimWorld;
using BetterPawnControl.Helpers;

namespace BetterPawnControl
{
    public class BPCPolicy 
        : Policy
        //: IExposable, ILoadReferenceable, IRenameable
    {
        /*internal int id = 0;
        public string label = "BPC.Auto".Translate();

        private string _renamableLabel;
        public string RenamableLabel
        {
            get => _renamableLabel;
            set => _renamableLabel = value;
        }

        public string BaseLabel => label;

        public string InspectLabel => label;*/

        protected override string LoadKey => "BPC_" + ToString();

        public BPCPolicy() {
            id = 0;
            label = "BPC.Auto".Translate();
        }

        public BPCPolicy(int id, string label)
        {
            this.id = id;
            this.label = label;
        }

        public override string ToString()
        {
            return "Id:" + id + "  Label: " + label;
        }

        public virtual bool Equals(BPCPolicy other)
        {
            return this.id == other.id && this.label == other.label;
        }

        /// <summary>
        /// Data for saving/loading
        /// </summary>
        public override void ExposeData()
        {
            //base.ExposeData();
            Scribe_Values.Look<string>(ref label, "label", "Default", true);
            Scribe_Values.Look<int>(ref id, "id", 0, true);
        }

        public override void CopyFrom(RimWorld.Policy other)
        {
            id = other.id;
            label = other.label;
        }

        public BPCPolicyAnimal ToAnimalPolicy()
        {
            return new BPCPolicyAnimal(id, label);
        }

        public BPCPolicyAssign ToAssignPolicy()
        {
            return new BPCPolicyAssign(id, label);
        }

        public BPCPolicyMech ToMechPolicy()
        {
            return new BPCPolicyMech(id, label);
        }

        public BPCPolicySchedule ToSchedulePolicy()
        {
            return new BPCPolicySchedule(id, label);
        }

        public BPCPolicyWeapon ToWeaponPolicy()
        {
            return new BPCPolicyWeapon(id, label);
        }

        public BPCPolicyWork ToWorkPolicy()
        {
            return new BPCPolicyWork(id, label);
        }

        /*public override string GetUniqueLoadID()
        {
            return "BPC_Policy_" + id;
        }*/
    }
}