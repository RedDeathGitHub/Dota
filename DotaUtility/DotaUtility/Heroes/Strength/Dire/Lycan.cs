﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Lycan : Hero
    {
        public Lycan()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "lycan_summon_wolves",
                    Value = @"55"
                },
                new Ability
                {
                    IconName = "lycan_howl",
                    Value = "14  5\n" +
                            "26 10\n" +
                            "38 15\n" +
                            "50 20"
                },
                new Ability
                {
                    IconName = "lycan_feral_impulse",

                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconName = "lycan_shapeshift",
                    Value = "21 18"
                }
            };
        }
    }
}