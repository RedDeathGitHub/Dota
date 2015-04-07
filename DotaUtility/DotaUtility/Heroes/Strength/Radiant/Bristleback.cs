using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Bristleback : Hero
    {
        public Bristleback()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "bristleback_viscous_nasal_goo",
                    Value = "4 30\n" +
                            "4 45\n" +
                            "8 55\n" +
                            "8 70"
                },
                new Ability
                {
                    IconName = "bristleback_quill_spray",
                    Value = "20 30\n" +
                            "40 30\n" +
                            "60 35\n" +
                            "80 35"
                },
                new Ability
                {
                    IconName = "bristleback_bristleback",

                    Value = "15  5\n" +
                            "25 10\n" +
                            "30 15\n" +
                            "40 20"
                },
                new Ability
                {
                    IconName = "bristleback_warpath",

                    Value = "5 100 15\n" +
                            "6 150 25\n" +
                            "7 210 35"
                }
            };
        }
    }
}