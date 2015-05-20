using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Enigma : Hero
    {
        public Enigma()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "enigma_malefice",
                    Value = " 50 0.2\n" +
                            " 90 0.5\n" +
                            "120 0.7\n" +
                            "150 1.0"
                },
                new Ability
                {
                    IconName = "enigma_demonic_conversion",
                    AdditionalIconNames = new List<string>
                    {
                        "enigma_demonic_conversion_alt"
                    },
                    Value = "6"
                },
                new Ability
                {
                    IconName = "enigma_midnight_pulse",
                    Value = "30\n" +
                            "40\n" +
                            "50\n" +
                            "60"
                },
                new Ability
                {
                    IconName = "enigma_black_hole",
                    Value = "150 20\n" +
                            "300 20\n" +
                            "500 20"
                }
            };
        }
    }
}