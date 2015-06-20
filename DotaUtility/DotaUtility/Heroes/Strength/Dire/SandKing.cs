using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class SandKing : Hero
    {
        public SandKing()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sandking_burrowstrike",
                        "sandking_burrowstrike_alt"
                    },
                    Value = " 70 2.2\n" +
                            "120 2.2\n" +
                            "160 2.2\n" +
                            "210 2.2"
                },
                new Ability
                {
                    IconNames = new List<string> { "sandking_sand_storm" },
                    Value = "20 1.5\n" +
                            "40 1.5\n" +
                            "60 1.5\n" +
                            "80 1.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "sandking_caustic_finale" },
                    Value = " 60 20\n" +
                            "100 30\n" +
                            "120 35\n" +
                            "160 50"
                },
                new Ability
                {
                    IconNames = new List<string> { "sandking_epicenter" },
                    Value = "500  650\n" +
                            "650  800\n" +
                            "800 1000"
                }
            };
        }
    }
}