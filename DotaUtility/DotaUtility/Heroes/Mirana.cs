using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Mirana : Hero
    {
        public Mirana()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "mirana_starfall",

                    Value = " 98\n" +
                            "196\n" +
                            "294\n" +
                            "394"
                },
                new Ability
                {
                    IconName = "mirana_arrow",
                    Value = " 37\n" +
                            "105\n" +
                            "172\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "mirana_leap",

                    Value = " 8  4\n" +
                            "16  8\n" +
                            "24 12\n" +
                            "32 16"
                },
                new Ability
                {
                    IconName = "mirana_invis",
                    Value = "2.5 15\n" +
                            "2.0 15\n" +
                            "1.5 15"
                }
            };
        }
    }
}