﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class CentaurWarrunner : Hero
    {
        public CentaurWarrunner()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "centaur_hoof_stomp",
                        @"centaur\berserkers_edge\centaur_hoof_stomp"
                    },
                    Value = " 70 2.0\n" +
                            "110 2.2\n" +
                            "150 2.5\n" +
                            "180 2.7"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "centaur_double_edge",
                        @"centaur\berserkers_edge\centaur_double_edge"
                    },
                    Value = "130\n" +
                            "180\n" +
                            "240\n" +
                            "300"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "centaur_return",
                        @"centaur\berserkers_edge\centaur_return"
                    },
                    Value = "16 26\n" +
                            "18 34\n" +
                            "20 42\n" +
                            "22 50"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "centaur_stampede",
                        @"centaur\berserkers_edge\centaur_stampede"
                    },
                    Value = "1 60\n" +
                            "2 60\n" +
                            "3 60"
                }
            };
        }
    }
}