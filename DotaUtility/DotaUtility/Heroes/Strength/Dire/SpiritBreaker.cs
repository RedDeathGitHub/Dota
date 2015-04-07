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
                    IconName = "spirit_breaker_charge_of_darkness",
                    Value = "1.2\n" +
                            "1.6\n" +
                            "2.0\n" +
                            "2.4"
                },
                new Ability
                {
                    IconName = "spirit_breaker_empowering_haste",
                    Value = " 6\n" +
                            "10\n" +
                            "14\n" +
                            "18"
                },
                new Ability
                {
                    IconName = "spirit_breaker_greater_bash",

                    Value = "1.0  17\n" +
                            "1.2 156\n" +
                            "1.4\n" +
                            "1.6"
                },
                new Ability
                {
                    IconName = "spirit_breaker_nether_strike",
                    Value = "112\n" +
                            "187\n" +
                            "262"
                }
            };
        }
    }
}