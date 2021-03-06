﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class TrollWarlord : Hero
    {
        public TrollWarlord()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "troll_warlord_berserkers_rage",
                        "troll_warlord_berserkers_rage_active"
                    },
                    Value = "0.8 10\n" +
                            "1.2 20\n" +
                            "1.6 30\n" +
                            "2.0 40"
                },
                new Ability
                {
                    IconNames = new List<string> { "troll_warlord_whirling_axes_ranged" },
                    Value = @"50 30"
                },
                new Ability
                {
                    IconNames = new List<string> { "troll_warlord_whirling_axes_melee" },
                    Value = " 50 60\n" +
                            " 90 60\n" +
                            "130 60\n" +
                            "170 60"
                },
                new Ability
                {
                    IconNames = new List<string> { "troll_warlord_fervor" },
                    Value = "16\n" +
                            "22\n" +
                            "28\n" +
                            "34"
                },
                new Ability
                {
                    IconNames = new List<string> { "troll_warlord_battle_trance" },
                    Value = " 60\n" +
                            "120\n" +
                            "180"
                }
            };
        }
    }
}