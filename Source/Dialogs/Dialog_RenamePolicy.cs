using System.Linq;
using Verse;

namespace BetterPawnControl
{

    public class Dialog_RenamePolicy : Verse.Dialog_Rename<BPCPolicy>
    {
        //private string curName = null;//From 1.5 its in lib class now.
        private BPCPolicy policy = null;
        private readonly int maxLength = 12;
        private Resources.Type type = Resources.Type.animal;

        public Dialog_RenamePolicy(BPCPolicy policy, Resources.Type type) : base(policy)
        {
            this.policy = policy;
            this.curName = policy.label;
            this.type = type;
        }

        /// <summary>
        /// Copy paste from vanilla
        /// </summary>
        protected override AcceptanceReport NameIsValid(string name)
        {
            AcceptanceReport result = base.NameIsValid(name);
            if (!result.Accepted)
            {
                return result;
            }

            string str = null;

            switch (this.type)
            {
                case Resources.Type.animal:
                    if (AnimalManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
                case Resources.Type.assign:
                    if (AssignManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
                case Resources.Type.restrict:
                    if (ScheduleManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
                case Resources.Type.work:
                    if (WorkManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
                case Resources.Type.mech:
                    if (MechManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
                case Resources.Type.weapons:
                    if (WeaponsManager.policies.Any((BPCPolicy d) => d.label == name))
                    {
                        str = "NameIsInUse".Translate();
                    }
                    break;
            }
            if (!str.NullOrEmpty())
            {
                return str;
            }
            return true;
        }

        /// <summary>
        /// Sanitize AnimalPolicy label name and set refresh label on (grand)parent window
        /// </summary>
        protected override void OnRenamed(string name)
        {
            bool updateAlertPolicyLabel = false;
            if (AlertManager.GetAlertPolicy(1, this.type).Equals(this.policy))
            {
                updateAlertPolicyLabel = true;
            }
            
            this.policy.label = this.curName.Length <= maxLength ? this.curName : this.curName.Substring(0, maxLength) + "...";

            if (updateAlertPolicyLabel)
            {
                AlertManager.SaveState(1, this.type, this.policy);
            }
        }
    }
}
