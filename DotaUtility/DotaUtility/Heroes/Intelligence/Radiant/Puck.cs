﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Puck : Hero
    {
        public Puck()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "puck_illusory_orb",
                    Value = " 50\n" +
                            "100\n" +
                            "150\n" +
                            "210"
                },
                new Ability
                {
                    IconName = "puck_waning_rift",
                    Value = " 70 0.7\n" +
                            "120 1.5\n" +
                            "160 2.2\n" +
                            "210 3.0"
                },
                new Ability
                {
                    IconName = "puck_phase_shift",
                    Value = "0.7\n" +
                            "1.5\n" +
                            "2.2\n" +
                            "3.2"
                },
                new Ability
                {
                    IconName = "puck_dream_coil",
                    Value = "1.5 1.5\n" +
                            "2.2 3.0\n" +
                            "3.0 4.5"
                }
            };
        }
    }
}