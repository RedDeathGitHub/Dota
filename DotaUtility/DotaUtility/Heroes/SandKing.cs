using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class SandKing : Hero
    {
        public SandKing()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "sandking_burrowstrike",
                    Value = " 75 2.2\n" +
                            "120 2.2\n" +
                            "165 2.2\n" +
                            "210 2.2"
                },
                new Ability
                {
                    IconName = "sandking_sand_storm",
                    Value = "18 1.5\n" +
                            "37 1.5\n" +
                            "56 1.5\n" +
                            "75 1.5"
                },
                new Ability
                {
                    IconName = "sandking_caustic_finale",

                    Value = " 67\n" +
                            " 97\n" +
                            "127\n" +
                            "165"
                },
                new Ability
                {
                    IconName = "sandking_epicenter",
                    Value = "495 660 30\n" +
                            "660 825 30\n" +
                            "825 990 30"
                }
            };
        }
    }
}