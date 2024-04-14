using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterPawnControl.Helpers
{
    public class ExposeDataPolicyListConverter
    {
        public static List<BPCPolicyAnimal> ToAnimalPolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicyAnimal> newPolicyList = new List<BPCPolicyAnimal>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToAnimalPolicy());
            }

            return newPolicyList;
        }

        public static List<BPCPolicyAssign> ToAssignPolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicyAssign> newPolicyList = new List<BPCPolicyAssign>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToAssignPolicy());
            }

            return newPolicyList;
        }

        public static List<BPCPolicyMech> ToMechPolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicyMech> newPolicyList = new List<BPCPolicyMech>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToMechPolicy());
            }

            return newPolicyList;
        }

        public static List<BPCPolicySchedule> ToSchedulePolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicySchedule> newPolicyList = new List<BPCPolicySchedule>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToSchedulePolicy());
            }

            return newPolicyList;
        }

        public static List<BPCPolicyWeapon> ToWeaponPolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicyWeapon> newPolicyList = new List<BPCPolicyWeapon>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToWeaponPolicy());
            }

            return newPolicyList;
        }

        public static List<BPCPolicyWork> ToWorkPolicyList(List<BPCPolicy> policyList)
        {
            List<BPCPolicyWork> newPolicyList = new List<BPCPolicyWork>();

            foreach (BPCPolicy policy in policyList)
            {
                newPolicyList.Add(policy.ToWorkPolicy());
            }

            return newPolicyList;
        }
    }
}
