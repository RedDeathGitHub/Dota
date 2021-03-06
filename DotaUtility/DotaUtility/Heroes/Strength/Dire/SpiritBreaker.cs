﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class SpiritBreaker : Hero
    {
        public SpiritBreaker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "spirit_breaker_charge_of_darkness",
                        "spirit_breaker_charge_of_darkness_alt"
                    },
                    Value = "1.2\n" +
                            "1.6\n" +
                            "2.0\n" +
                            "2.4"
                },
                new Ability
                {
                    IconNames = new List<string> { "spirit_breaker_empowering_haste" },
                    Value = " 6\n" +
                            "10\n" +
                            "14\n" +
                            "18"
                },
                new Ability
                {
                    IconNames = new List<string> { "spirit_breaker_greater_bash" },
                    Value = "1.0  15\n" +
                            "1.2 150\n" +
                            "1.4\n" +
                            "1.6"
                },
                new Ability
                {
                    IconNames = new List<string> { "spirit_breaker_nether_strike" },
                    Value = "110\n" +
                            "180\n" +
                            "260"
                }
            };
        }
    }
}