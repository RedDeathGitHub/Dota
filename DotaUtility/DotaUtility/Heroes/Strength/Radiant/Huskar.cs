using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Huskar : Hero
    {
        public Huskar()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "huskar_inner_vitality",

                    Value = "40"
                },
                new Ability
                {
                    IconName = "huskar_burning_spear",
                    Value = " 30 15\n" +
                            " 60 15\n" +
                            " 90 15\n" +
                            "120 15"
                },
                new Ability
                {
                    IconName = "huskar_berserkers_blood",

                    Value = "200 56\n" +
                            "220 70\n" +
                            "250 84\n" +
                            "280 98"
                },
                new Ability
                {
                    IconName = "huskar_life_break",
                    AdditionalIconNames = new List<string>
                    {
                        "huskar_life_break_alt"
                    },
                    Value = "25 40 50\n" +
                            "25 50 50\n" +
                            "25 60 50"
                }
            };
        }
    }
}