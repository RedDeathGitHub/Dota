using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                    Value = "4 32\n" +
                            "4 44\n" +
                            "8 56\n" +
                            "8 68"
                },
                new Ability
                {
                    IconName = "bristleback_quill_spray",
                    Value = "20 30\n" +
                            "40 32\n" +
                            "60 34\n" +
                            "80 36"
                },
                new Ability
                {
                    IconName = "bristleback_bristleback",

                    Value = "16  8\n" +
                            "24 12\n" +
                            "32 16\n" +
                            "40 20"
                },
                new Ability
                {
                    IconName = "bristleback_warpath",

                    Value = "5 100 15\n" +
                            "6 150 24\n" +
                            "7 210 35"
                }
            };
        }
    }
}