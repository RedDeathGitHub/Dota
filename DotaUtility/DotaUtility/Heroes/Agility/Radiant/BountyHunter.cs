﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class BountyHunter : Hero
    {
        public BountyHunter()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "bounty_hunter_shuriken_toss",
                        "bounty_hunter_twinblade_shuriken_toss"
                    },
                    Value = "110\n" +
                            "170\n" +
                            "220\n" +
                            "280"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "bounty_hunter_jinada",
                        "bounty_hunter_twinblade_jinada"
                    },
                    Value = "150 25\n" +
                            "170 25\n" +
                            "200 25\n" +
                            "220 25"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "bounty_hunter_wind_walk",
                        "bounty_hunter_twinblade_wind_walk"
                    },
                    Value = " 30 1.0\n" +
                            " 60 0.7\n" +
                            " 90 0.5\n" +
                            "120 0.3"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "bounty_hunter_track",
                        "bounty_hunter_twinblade_track"
                    },
                    Value = "200  50\n" +
                            "270 100\n" +
                            "350 150"
                }
            };
        }
    }
}