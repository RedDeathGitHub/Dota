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
                    IconNames = new List<string> { "morphling_waveform" },

                    Value = " 70\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "morphling_adaptive_strike",
                        "morphling_adaptive_strike_ethereal_blade"
                    },
                    Value = "0.3 1.2\n" +
                            "0.7 2.2\n" +
                            "1.1 3.2\n" +
                            "1.5 4.2"
                },
                new Ability
                {
                    IconNames = new List<string> { "morphling_morph_agi" },

                    Value = "3  2\n" +
                            "4  4\n" +
                            "5  6\n" +
                            "6 10"
                },
                new Ability
                {
                    IconNames = new List<string> { "morphling_replicate" },
                    Value = "50 100"
                }
            };
        }
    }
}