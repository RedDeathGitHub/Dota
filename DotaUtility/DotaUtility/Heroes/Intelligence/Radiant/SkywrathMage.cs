﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class SkywrathMage : Hero
    {
        public SkywrathMage()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "skywrath_mage_arcane_bolt" },
                    Value = "45 1.2\n" +
                            "60 1.2\n" +
                            "75 1.2\n" +
                            "90 1.2"
                },
                new Ability
                {
                    IconNames = new List<string> { "skywrath_mage_concussive_shot" },
                    Value = " 45 30\n" +
                            " 90 35\n" +
                            "130 40\n" +
                            "180 45"
                },
                new Ability
                {
                    IconNames = new List<string> { "skywrath_mage_ancient_seal" },
                    Value = "30 3\n" +
                            "35 4\n" +
                            "40 5\n" +
                            "45 6"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "skywrath_mage_mystic_flare",
                        "skywrath_mage_mystic_flare_alt",
                        "skywrath_mage_mystic_flare_alt_gold"
                    },
                    Value = " 450\n" +
                            " 750\n" +
                            "1000"
                }
            };
        }
    }
}