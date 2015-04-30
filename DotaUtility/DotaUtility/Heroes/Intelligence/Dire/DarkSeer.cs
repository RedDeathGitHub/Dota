using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class DarkSeer : Hero
    {
        public DarkSeer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "dark_seer_vacuum",
                    Value = " 30 0.5\n" +
                            " 60 0.5\n" +
                            " 90 0.5\n" +
                            "120 0.5"
                },
                new Ability
                {
                    IconName = "dark_seer_ion_shell",
                    Value = "20\n" +
                            "35\n" +
                            "50\n" +
                            "65"
                },
                new Ability
                {
                    IconName = "dark_seer_surge",
                    Value = "3.0\n" +
                            "4.5\n" +
                            "6.0\n" +
                            "7.5"
                },
                new Ability
                {
                    IconName = "dark_seer_wall_of_replica",
                    Value = "60 100\n" +
                            "75 120\n" +
                            "90 140"
                }
            };
        }
    }
}