﻿using System.Collections.Generic;
using Verse;

namespace BetterPawnControl
{
    public class AlertLevel: IExposable
    {
        internal Dictionary<Resources.Type, BPCPolicy> settings = null;
        internal int level = 0;

        public AlertLevel() { }

        public AlertLevel(int level, Dictionary<Resources.Type, BPCPolicy> settings)
        {
            this.level = level;
            this.settings = settings;
        }

        public override string ToString()
        {
            return
                "Level: " + level + " \n" +
                "  Settings: "+ settings.ToStringFullContents();

        }

        public void ExposeData()
        {
            Scribe_Values.Look<int>(ref level, "level", 0, true);
            List<Resources.Type> keys = new List<Resources.Type>();
            List<BPCPolicy> values = new List<BPCPolicy>();

            if (Scribe.mode == LoadSaveMode.Saving)
            {
                foreach (KeyValuePair<Resources.Type, BPCPolicy> entry in settings)
                {
                    keys.Add(entry.Key);
                    values.Add(entry.Value);
                }
                Scribe_Collections.Look(ref settings, "settings", LookMode.Value, LookMode.Deep, ref keys, ref values);
            }

            if (Scribe.mode == LoadSaveMode.LoadingVars)
            {
                Scribe_Collections.Look(ref settings, "settings", LookMode.Value, LookMode.Deep, ref keys, ref values);
            }
        }
    }
}
