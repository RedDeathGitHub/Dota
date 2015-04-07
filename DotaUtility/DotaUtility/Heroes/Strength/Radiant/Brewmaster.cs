using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Brewmaster : Hero
    {
        public Brewmaster()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "brewmaster_thunder_clap",

                    Value = " 70 25\n" +
                            "130 35\n" +
                            "180 45\n" +
                            "220 55"
                },
                new Ability
                {
                    IconName = "brewmaster_drunken_haze",
                    Value = "45 15\n" +
                            "55 20\n" +
                            "65 20\n" +
                            "75 25"
                },
                new Ability
                {
                    IconName = "brewmaster_drunken_brawler",
                    AdditionalIconNames = new List<string>
                    {
                        "brewmaster_drunken_brawler_active",
                        "brewmaster_drunken_brawler_crit",
                        "brewmaster_drunken_brawler_miss"
                    },

                    Value = "10 15\n" +
                            "15 15\n" +
                            "20 10\n" +
                            "25 10"
                },
                new Ability
                {
                    IconName = "brewmaster_primal_split",
                    Value = "15\n" +
                            "17\n" +
                            "19"
                }
            };
        }
    }
}