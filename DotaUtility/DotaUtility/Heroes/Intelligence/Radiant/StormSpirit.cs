using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class StormSpirit : Hero
    {
        public StormSpirit()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "storm_spirit_static_remnant",
                    Value = "100\n" +
                            "130\n" +
                            "160\n" +
                            "200"
                },
                new Ability
                {
                    IconName = "storm_spirit_electric_vortex",
                    Value = "1.0\n" +
                            "1.5\n" +
                            "2.0\n" +
                            "2.5"
                },
                new Ability
                {
                    IconName = "storm_spirit_overload",
                    Value = "20 50 80\n" +
                            "40 50 80\n" +
                            "50 50 80\n" +
                            "60 50 80"
                },
                new Ability
                {
                    IconName = "storm_spirit_ball_lightning",
                    Value = ""
                }
            };
        }
    }
}