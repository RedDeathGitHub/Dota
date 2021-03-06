﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Razor : Hero
    {
        public Razor()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "razor_plasma_field" },
                    Value = "120\n" +
                            "170\n" +
                            "220\n" +
                            "270"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "razor_static_link",
                        "razor_static_link_alt",
                        "razor_static_link_alt_gold"
                    },
                    Value = " 50\n" +
                            "110\n" +
                            "160\n" +
                            "220"
                },
                new Ability
                {
                    IconNames = new List<string> { "razor_unstable_current" },
                    Value = "30  4\n" +
                            "50  8\n" +
                            "70 12\n" +
                            "90 16"
                },
                new Ability
                {
                    IconNames = new List<string> { "razor_eye_of_the_storm" },
                    Value = "35\n" +
                            "50\n" +
                            "60"
                }
            };
        }
    }
}