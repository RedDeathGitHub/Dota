using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class PhantomLancer : Hero
    {
        public PhantomLancer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "phantom_lancer_spirit_lance",

                    Value = " 75 10\n" +
                            "112 20\n" +
                            "150 30\n" +
                            "187 40"
                },
                new Ability
                {
                    IconName = "phantom_lancer_doppelwalk",
                    Value = "25\n" +
                            "20\n" +
                            "15\n" +
                            "10"
                },
                new Ability
                {
                    IconName = "phantom_lancer_phantom_edge",

                    Value = "16\n" +
                            "12\n" +
                            " 8\n" +
                            " 4"
                },
                new Ability
                {
                    IconName = "phantom_lancer_juxtapose",
                    Value = "5 16 20\n" +
                            "7 16 20\n" +
                            "9 16 20"
                }
            };
        }
    }
}