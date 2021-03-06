﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Bristleback : Hero
    {
        public Bristleback()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "bristleback_viscous_nasal_goo" },
                    Value = "4.0 32\n" +
                            "5.6 44\n" +
                            "7.2 56\n" +
                            "8.8 68"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "bristleback_quill_spray",
                        @"bristleback\piston_impaler\bristleback_quill_spray"
                    },
                    Value = "20 30\n" +
                            "40 32\n" +
                            "60 34\n" +
                            "80 36"
                },
                new Ability
                {
                    IconNames = new List<string> { "bristleback_bristleback" },

                    Value = "16  8\n" +
                            "24 12\n" +
                            "32 16\n" +
                            "40 20"
                },
                new Ability
                {
                    IconNames = new List<string> { "bristleback_warpath" },

                    Value = "5 100 15\n" +
                            "6 150 25\n" +
                            "7 210 35"
                }
            };
        }
    }
}