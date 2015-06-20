using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Tidehunter : Hero
    {
        public Tidehunter()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "tidehunter_gush" },
                    Value = " 80 2 40\n" +
                            "120 3 40\n" +
                            "150 4 40\n" +
                            "190 5 40"
                },
                new Ability
                {
                    IconNames = new List<string> { "tidehunter_kraken_shell" },

                    Value = "12 600\n" +
                            "24 550\n" +
                            "36 500\n" +
                            "48 450"
                },
                new Ability
                {
                    IconNames = new List<string> { "tidehunter_anchor_smash" },
                    Value = " 70 45\n" +
                            "120 50\n" +
                            "170 55\n" +
                            "220 60"
                },
                new Ability
                {
                    IconNames = new List<string> { "tidehunter_ravage" },
                    Value = "150 2.0\n" +
                            "210 2.3\n" +
                            "280 2.7"
                }
            };
        }
    }
}