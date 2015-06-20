using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Mirana : Hero
    {
        public Mirana()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "mirana_starfall" },
                    Value = "100\n" +
                            "200\n" +
                            "300\n" +
                            "400"
                },
                new Ability
                {
                    IconNames = new List<string> { "mirana_arrow" },
                    Value = " 30\n" +
                            "100\n" +
                            "170\n" +
                            "240"
                },
                new Ability
                {
                    IconNames = new List<string> { "mirana_leap" },
                    Value = " 8  4\n" +
                            "16  8\n" +
                            "24 12\n" +
                            "32 16"
                },
                new Ability
                {
                    IconNames = new List<string> { "mirana_invis" },
                    Value = "2.5 15\n" +
                            "2.0 15\n" +
                            "1.5 15"
                }
            };
        }
    }
}