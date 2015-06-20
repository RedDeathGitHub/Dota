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
                    IconNames = new List<string> { "jakiro_dual_breath" },
                    Value = " 60 25\n" +
                            "130 30\n" +
                            "210 35\n" +
                            "280 40"
                },
                new Ability
                {
                    IconNames = new List<string> { "jakiro_ice_path" },
                    Value = "1.0\n" +
                            "1.4\n" +
                            "1.8\n" +
                            "2.2"
                },
                new Ability
                {
                    IconNames = new List<string> { "jakiro_liquid_fire" },
                    Value = "40 20\n" +
                            "60 30\n" +
                            "70 40\n" +
                            "90 50"
                },
                new Ability
                {
                    IconNames = new List<string> { "jakiro_macropyre" },
                    Value = "500 1300\n" +
                            "700 1800\n" +
                            "900 2400"
                }
            };
        }
    }
}