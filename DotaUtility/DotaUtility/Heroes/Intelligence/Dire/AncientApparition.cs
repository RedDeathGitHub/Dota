﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class AncientApparition : Hero
    {
        public AncientApparition()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "ancient_apparition_cold_feet" },
                    Value = "110 1.2\n" +
                            "150 2.0\n" +
                            "180 2.7\n" +
                            "220 3.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "ancient_apparition_ice_vortex" },
                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconNames = new List<string> { "ancient_apparition_chilling_touch" },
                    Value = "110\n" +
                            "180\n" +
                            "260\n" +
                            "360"
                },
                new Ability
                {
                    IconNames = new List<string> { "ancient_apparition_ice_blast" },
                    Value = "260 340\n" +
                            "400 510\n" +
                            "570 740"
                }
            };
        }
    }
}