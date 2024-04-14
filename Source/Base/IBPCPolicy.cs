using RimWorld;

namespace BetterPawnControl
{
    public interface IBPCPolicy
    {
        void CopyFrom(Policy other);
        bool Equals(BPCPolicy other);
        bool Equals(object obj);
        void ExposeData();
        string ToString();
    }
}