using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Broodmother : Hero
    {
        public Broodmother()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "broodmother_spawn_spiderlings",

                    Value = " 56 1\n" +
                            "112 2\n" +
                            "168 3\n" +
                            "225 4"
                },
                new Ability
                {
                    IconName = "broodmother_spin_web",
                    Value = "2 40\n" +
                            "4 50\n" +
                            "6 60\n" +
                            "8 70"
                },
                new Ability
                {
                    IconName = "broodmother_incapacitating_bite",

                    Value = "30 10\n" +
                            "40 20\n" +
                            "50 30\n" +
                            "60 40"
                },
                new Ability
                {
                    IconName = "broodmother_insatiable_hunger",
                    Value = " 60\n" +
                            " 80\n" +
                            "100"
                }
            };
        }
    }
}