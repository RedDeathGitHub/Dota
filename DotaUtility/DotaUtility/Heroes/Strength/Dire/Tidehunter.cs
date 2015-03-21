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
                    Value = " 82 2 40\n" +
                            "120 3 40\n" +
                            "157 4 40\n" +
                            "195 5 40"
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
                    Value = " 75 45\n" +
                            "125 50\n" +
                            "175 55\n" +
                            "225 60"
                },
                new Ability
                {
                    IconName = "tidehunter_ravage",
                    Value = "150 2.0\n" +
                            "217 2.3\n" +
                            "285 2.7"
                }
            };
        }
    }
}