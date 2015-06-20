using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Io : Hero
    {
        public Io()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "wisp_tether" },
                    Value = "100 14\n" +
                            "100 15\n" +
                            "100 16\n" +
                            "100 17"
                },
                new Ability
                {
                    IconNames = new List<string> { "wisp_spirits" },
                    Value = "120\n" +
                            "180\n" +
                            "280\n" +
                            "370"
                },
                new Ability
                {
                    IconNames = new List<string> { "wisp_overcharge" },
                    Value = "40  5 4.5\n" +
                            "50 10 4.5\n" +
                            "60 15 4.5\n" +
                            "70 20 4.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "wisp_relocate" },
                    Value = "2.5 10\n" +
                            "2.2 10\n" +
                            "2.0 10"
                }
            };
        }
    }
}