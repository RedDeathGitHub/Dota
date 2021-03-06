﻿using System.Collections.Generic;

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
                    IconNames = new List<string> { "brewmaster_thunder_clap" },

                    Value = " 70 25\n" +
                            "130 35\n" +
                            "180 45\n" +
                            "220 55"
                },
                new Ability
                {
                    IconNames = new List<string> { "brewmaster_drunken_haze" },
                    Value = "45 14\n" +
                            "55 18\n" +
                            "65 22\n" +
                            "75 26"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "brewmaster_drunken_brawler",
                        "brewmaster_drunken_brawler_active",
                        "brewmaster_drunken_brawler_crit",
                        "brewmaster_drunken_brawler_miss"
                    },

                    Value = "10 16\n" +
                            "15 14\n" +
                            "20 12\n" +
                            "25 10"
                },
                new Ability
                {
                    IconNames = new List<string> { "brewmaster_primal_split" },
                    Value = "15\n" +
                            "17\n" +
                            "19"
                }
            };
        }
    }
}