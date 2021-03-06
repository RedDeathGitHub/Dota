﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Leshrac : Hero
    {
        public Leshrac()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "leshrac_split_earth",
                        @"leshrac\tormented_staff\leshrac_split_earth"
                    },
                    Value = " 90 2\n" +
                            "130 2\n" +
                            "180 2\n" +
                            "220 2"
                },
                new Ability
                {
                    IconNames = new List<string> { "leshrac_diabolic_edict" },
                    Value = " 350\n" +
                            " 700\n" +
                            "1000\n" +
                            "1400"
                },
                new Ability
                {
                    IconNames = new List<string> { "leshrac_lightning_storm" },
                    Value = " 60 0.7\n" +
                            "100 0.8\n" +
                            "150 0.9\n" +
                            "200 1.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "leshrac_pulse_nova" },
                    Value = " 70 120\n" +
                            "100 140\n" +
                            "120 160"
                }
            };
        }
    }
}