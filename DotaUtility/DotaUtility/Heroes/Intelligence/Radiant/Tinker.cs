using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Tinker : Hero
    {
        public Tinker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "tinker_laser",
                    Value = " 80\n" +
                            "160\n" +
                            "240\n" +
                            "320"
                },
                new Ability
                {
                    IconName = "tinker_heat_seeking_missile",
                    Value = " 94\n" +
                            "150\n" +
                            "206\n" +
                            "262"
                },
                new Ability
                {
                    IconName = "tinker_march_of_the_machines",
                    Value = "211\n" +
                            "316\n" +
                            "422\n" +
                            "528"
                },
                new Ability
                {
                    IconName = "tinker_rearm",
                    Value = "3\n" +
                            "2\n" +
                            "1"
                }
            };
        }
    }
}


