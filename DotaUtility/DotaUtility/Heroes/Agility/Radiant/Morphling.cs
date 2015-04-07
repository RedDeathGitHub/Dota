using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Morphling : Hero
    {
        public Morphling()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "morphling_waveform",

                    Value = " 70\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "morphling_adaptive_strike",
                    AdditionalIconNames = new List<string>
                    {
                        "morphling_adaptive_strike_ethereal_blade"
                    },
                    Value = "15 0.3 1.2\n" +
                            "30 0.7 2.2\n" +
                            "45 1.1 3.2\n" +
                            "60 1.5 4.2"
                },
                new Ability
                {
                    IconName = "morphling_morph_agi",

                    Value = "3  2\n" +
                            "4  4\n" +
                            "5  6\n" +
                            "6 10"
                },
                new Ability
                {
                    IconName = "morphling_replicate",
                    Value = "50 100"
                }
            };
        }
    }
}