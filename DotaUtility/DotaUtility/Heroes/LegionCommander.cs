using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                    Value = " 30\n" +
                            " 60\n" +
                            " 90\n" +
                            "120"
                },
                new Ability
                {
                    IconName = "legion_commander_press_the_attack",
                    Value = " 60 30\n" +
                            " 80 40\n" +
                            "100 50\n" +
                            "120 60"
                },
                new Ability
                {
                    IconName = "legion_commander_moment_of_courage",

                    Value = "16 20\n" +
                            "18 40\n" +
                            "20 60\n" +
                            "22 80"
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