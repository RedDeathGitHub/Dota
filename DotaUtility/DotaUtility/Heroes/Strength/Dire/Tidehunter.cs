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
                    IconName = "tidehunter_gush",
                    Value = " 80 2 40\n" +
                            "120 3 40\n" +
                            "150 4 40\n" +
                            "190 5 40"
                },
                new Ability
                {
                    IconName = "tidehunter_kraken_shell",

                    Value = "10 600\n" +
                            "20 550\n" +
                            "30 500\n" +
                            "40 450"
                },
                new Ability
                {
                    IconName = "tidehunter_anchor_smash",
                    Value = " 70 45\n" +
                            "120 50\n" +
                            "170 55\n" +
                            "220 60"
                },
                new Ability
                {
                    IconName = "tidehunter_ravage",
                    Value = "150 2.0\n" +
                            "210 2.3\n" +
                            "280 2.7"
                }
            };
        }
    }
}