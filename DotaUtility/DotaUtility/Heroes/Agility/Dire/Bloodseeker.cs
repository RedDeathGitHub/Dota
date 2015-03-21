using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Bloodseeker : Hero
    {
        public Bloodseeker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "bloodseeker_bloodrage",

                    Value = "25\n" +
                            "30\n" +
                            "35\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "bloodseeker_blood_bath",
                    Value = "120 3\n" +
                            "160 4\n" +
                            "200 5\n" +
                            "240 6"
                },
                new Ability
                {
                    IconName = "bloodseeker_thirst",

                    Value = "10\n" +
                            "20\n" +
                            "30\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "bloodseeker_rupture",
                    Value = "20\n" +
                            "40\n" +
                            "60"
                }
            };
        }
    }
}