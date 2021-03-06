﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class CrystalMaiden : Hero
    {
        public CrystalMaiden()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "crystal_maiden_crystal_nova",
                        "crystal_maiden_crystal_nova_icecowl"
                    },
                    Value = " 70 20\n" +
                            "110 30\n" +
                            "150 40\n" +
                            "180 50"
                },
                new Ability
                {
                    IconNames = new List<string> { "crystal_maiden_frostbite" },
                    Value = "110 1.5\n" +
                            "150 2.0\n" +
                            "180 2.5\n" +
                            "220 3.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "crystal_maiden_brilliance_aura" },
                    Value = "1.0 2\n" +
                            "1.5 3\n" +
                            "2.0 4\n" +
                            "2.5 5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "crystal_maiden_freezing_field",
                        "crystal_maiden_freezing_field_alt1"
                    },
                    Value = "1500 2500\n" +
                            "2500 3600\n" +
                            "3600 4500"
                }
            };
        }
    }
}