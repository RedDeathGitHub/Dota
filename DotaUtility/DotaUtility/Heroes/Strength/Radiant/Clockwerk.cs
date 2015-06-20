using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Clockwerk : Hero
    {
        public Clockwerk()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "rattletrap_battery_assault" },
                    Value = "240 15\n" +
                            "480 30\n" +
                            "720 45\n" +
                            "960 60"
                },
                new Ability
                {
                    IconNames = new List<string> { "rattletrap_power_cogs" },
                    Value = " 80  60\n" +
                            "120  90\n" +
                            "160 120\n" +
                            "200 150"
                },
                new Ability
                {
                    IconNames = new List<string> { "rattletrap_rocket_flare" },
                    Value = " 60\n" +
                            " 90\n" +
                            "120\n" +
                            "150"
                },
                new Ability
                {
                    IconNames = new List<string> { "rattletrap_hookshot" },
                    Value = " 70 1.0\n" +
                            "150 1.5\n" +
                            "220 2.0"
                }
            };
        }
    }
}