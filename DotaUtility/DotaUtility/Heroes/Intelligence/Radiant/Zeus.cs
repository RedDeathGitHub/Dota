using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Zeus : Hero
    {
        public Zeus()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "zuus_arc_lightning" },
                    Value = " 60\n" +
                            " 70\n" +
                            " 80\n" +
                            "100"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "zuus_lightning_bolt",
                        "zuus_lightning_bolt_immortal"
                    },
                    Value = " 70\n" +
                            "130\n" +
                            "200\n" +
                            "260"
                },
                new Ability
                {
                    IconNames = new List<string> { "zuus_static_field" },
                    Value = " 5\n" +
                            " 7\n" +
                            " 9\n" +
                            "11"
                },
                new Ability
                {
                    IconNames = new List<string> { "zuus_thundergods_wrath" },
                    Value = "160 330\n" +
                            "260 400\n" +
                            "350 480"
                }
            };
        }
    }
}