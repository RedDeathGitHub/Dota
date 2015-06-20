using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class DrowRanger : Hero
    {
        public DrowRanger()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "drow_ranger_frost_arrows",
                        @"drow_ranger\dragons_touch_ability_icons\drow_ranger_frost_arrows"
                    },
                    Value = "15 1.5\n" +
                            "30 1.5\n" +
                            "45 1.5\n" +
                            "60 1.5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "drow_ranger_wave_of_silence",
                        @"drow_ranger\dragons_touch_ability_icons\drow_ranger_wave_of_silence"
                    },
                    Value = "0.6 3\n" +
                            "0.7 4\n" +
                            "0.8 5\n" +
                            "0.9 6"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "drow_ranger_trueshot",
                        @"drow_ranger\dragons_touch_ability_icons\drow_ranger_trueshot"
                    },
                    Value = "18\n" +
                            "24\n" +
                            "30\n" +
                            "36"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "drow_ranger_marksmanship",
                        @"drow_ranger\dragons_touch_ability_icons\drow_ranger_marksmanship"
                    },
                    Value = "40 15\n" +
                            "60 20\n" +
                            "80 30"
                }
            };
        }
    }
}