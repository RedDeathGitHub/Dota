﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class NyxAssassin : Hero
    {
        public NyxAssassin()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "nyx_assassin_impale" },
                    Value = " 60 1.3\n" +
                            "100 1.8\n" +
                            "150 2.3\n" +
                            "200 2.8"
                },
                new Ability
                {
                    IconNames = new List<string> { "nyx_assassin_mana_burn" },
                    Value = "3.5\n" +
                            "4.0\n" +
                            "4.5\n" +
                            "5.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "nyx_assassin_spiked_carapace" },
                    Value = "0.6\n" +
                            "1.2\n" +
                            "1.8\n" +
                            "2.4"
                },
                new Ability
                {
                    IconNames = new List<string> { "nyx_assassin_vendetta" },
                    Value = "250\n" +
                            "400\n" +
                            "550"
                }
            };
        }
    }
}