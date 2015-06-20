using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class TreantProtector : Hero
    {
        public TreantProtector()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "treant_natures_guise",
                        @"treant\fungal_protector_icons\treant_natures_guise"
                    },
                    Value = "2 10 15\n" +
                            "2 10 30\n" +
                            "2 10 45\n" +
                            "2 10 60"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "treant_leech_seed",
                        @"treant\fungal_protector_icons\treant_leech_seed"
                    },
                    Value = " 60 28\n" +
                            "130 28\n" +
                            "200 28\n" +
                            "270 28"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "treant_living_armor",
                        @"treant\fungal_protector_icons\treant_living_armor"
                    },
                    Value = " 80  60\n" +
                            "200 100\n" +
                            "360 150\n" +
                            "560 200"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "treant_overgrowth",
                        @"treant\fungal_protector_icons\treant_overgrowth"
                    },
                    Value = "3.0 390\n" +
                            "3.7 520\n" +
                            "4.5 650"
                }
            };
        }
    }
}