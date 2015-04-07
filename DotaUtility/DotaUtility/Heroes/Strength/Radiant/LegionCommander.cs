using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class LegionCommander : Hero
    {
        public LegionCommander()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "legion_commander_overwhelming_odds",
                    Value = " 30 10 15\n" +
                            " 60 10 25\n" +
                            " 90 10 40\n" +
                            "120 15 50"
                },
                new Ability
                {
                    IconName = "legion_commander_press_the_attack",
                    Value = " 60 150\n" +
                            " 80 200\n" +
                            "100 250\n" +
                            "120 300"
                },
                new Ability
                {
                    IconName = "legion_commander_moment_of_courage",

                    Value = "15 20\n" +
                            "15 40\n" +
                            "20 60\n" +
                            "20 80"
                },
                new Ability
                {
                    IconName = "legion_commander_duel",
                    Value = "10 4.0\n" +
                            "14 4.7\n" +
                            "18 5.5"
                }
            };
        }
    }
}