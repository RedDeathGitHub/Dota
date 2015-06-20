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
                    IconNames = new List<string>
                    {
                        "phantom_lancer_spirit_lance",
                        "phantom_lancer_sunwarrior_spirit_lance"
                    },
                    Value = " 70 10\n" +
                            "110 20\n" +
                            "150 30\n" +
                            "190 40"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_lancer_doppelwalk",
                        "phantom_lancer_sunwarrior_doppelwalk"
                    },
                    Value = "25\n" +
                            "20\n" +
                            "15\n" +
                            "10"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_lancer_phantom_edge",
                        "phantom_lancer_sunwarrior_phantom_edge"
                    },
                    Value = "16\n" +
                            "12\n" +
                            " 8\n" +
                            " 4"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_lancer_juxtapose",
                        "phantom_lancer_sunwarrior_juxtapose"
                    },
                    Value = "5 15 20\n" +
                            "7 15 20\n" +
                            "9 15 20"
                }
            };
        }
    }
}