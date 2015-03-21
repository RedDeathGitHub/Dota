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
                    Value = "105\n" +
                            "135\n" +
                            "165\n" +
                            "195"
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
                    Value = "22 50 80\n" +
                            "37 50 80\n" +
                            "52 50 80\n" +
                            "67 50 80"
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