using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterPawnControl.Helpers
{
    internal class Utils
    {
        public static int NextLabelId()
        {
            return 1 + WorkManager.policies.Count
                + ScheduleManager.policies.Count
                + AssignManager.policies.Count
                + AnimalManager.policies.Count
                + MechManager.policies.Count
                + WeaponsManager.policies.Count;
        }
    }
}
