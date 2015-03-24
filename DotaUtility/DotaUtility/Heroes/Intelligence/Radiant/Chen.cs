﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Chen : Hero
    {
        public Chen()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "chen_penitence",
                    Value = "14\n" +
                            "18\n" +
                            "22\n" +
                            "26"
                },
                new Ability
                {
                    IconName = "chen_test_of_faith",
                    Value = " 50 100\n" +
                            "100 200\n" +
                            "150 300\n" +
                            "200 400"
                },
                 new Ability
                {
                    IconName = "chen_test_of_faith_teleport",
                    Value = "6\n" +
                            "5\n" +
                            "4\n" +
                            "3"
                },
                new Ability
                {
                    IconName = "chen_holy_persuasion",
                    Value = "1  75\n" +
                            "2 150\n" +
                            "3 225\n" +
                            "4 300"
                },
                new Ability
                {
                    IconName = "chen_hand_of_god",
                    Value = "200\n" +
                            "300\n" +
                            "400"
                }
            };
        }
    }
}

