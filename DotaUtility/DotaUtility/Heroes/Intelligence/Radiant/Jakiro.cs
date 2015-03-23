using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Jakiro : Hero
    {
        public Jakiro()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "jakiro_dual_breath",
                    Value = " 60 28\n" +
                            "135 32\n" +
                            "210 36\n" +
                            "285 40"
                },
                new Ability
                {
                    IconName = "jakiro_ice_path",
                    Value = "1.0\n" +
                            "1.4\n" +
                            "1.8\n" +
                            "2.2"
                },
                new Ability
                {
                    IconName = "jakiro_liquid_fire",
                    Value = "45 20\n" +
                            "60 30\n" +
                            "75 40\n" +
                            "90 50"
                },
                new Ability
                {
                    IconName = "jakiro_macropyre",
                    Value = "525 1312\n" +
                            "735 1837\n" +
                            "945 2362"
                }
            };
        }
    }
}


