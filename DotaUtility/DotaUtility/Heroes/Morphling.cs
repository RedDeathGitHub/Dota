using System.Collections.Generic;

namespace DotaUtility.Heroes
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

                    Value = " 75\n" +
                            "131\n" +
                            "187\n" +
                            "243"
                },
                new Ability
                {
                    IconName = "morphling_adaptive_strike",
                    AdditionalIconNames = new List<string>
                    {
                        "morphling_adaptive_strike_ethereal_blade"
                    },
                    Value = "15 0.3\n" +
                            "30 0.7\n" +
                            "45 1.1\n" +
                            "60 1.5"
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