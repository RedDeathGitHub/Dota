using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Slardar : Hero
    {
        public Slardar()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "slardar_sprint",
                    Value = "20 15\n" +
                            "30 15\n" +
                            "35 15\n" +
                            "45 15"
                },
                new Ability
                {
                    IconName = "slardar_slithereen_crush",
                    Value = " 70 1.6 20\n" +
                            "120 1.9 20\n" +
                            "170 2.2 20\n" +
                            "220 2.5 20"
                },
                new Ability
                {
                    IconName = "slardar_bash",

                    Value = "10  60 1\n" +
                            "15  80 1\n" +
                            "20 100 1\n" +
                            "25 120 1"
                },
                new Ability
                {
                    IconName = "slardar_amplify_damage",
                    Value = "10 25\n" +
                            "15 25\n" +
                            "20 25"
                }
            };
        }
    }
}