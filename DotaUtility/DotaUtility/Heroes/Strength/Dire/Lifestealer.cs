﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Lifestealer : Hero
    {
        public Lifestealer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "life_stealer_rage",
                    Value = "30 3\n" +
                            "45 4\n" +
                            "60 5\n" +
                            "80 6"
                },
                new Ability
                {
                    IconName = "life_stealer_feast",

                    Value = "4\n" +
                            "5\n" +
                            "6\n" +
                            "7"
                },
                new Ability
                {
                    IconName = "life_stealer_open_wounds",
                    Value = "50"
                },
                new Ability
                {
                    IconName = "life_stealer_infest",
                    Value = "100\n" +
                            "200\n" +
                            "300"
                }
            };
        }
    }
}