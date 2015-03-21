using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Juggernaut : Hero
    {
        public Juggernaut()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "juggernaut_blade_fury",
                    Value = " 60\n" +
                            " 75\n" +
                            " 90\n" +
                            "105"
                },
                new Ability
                {
                    IconName = "juggernaut_healing_ward",
                    Value = "2\n" +
                            "3\n" +
                            "4\n" +
                            "5"
                },
                new Ability
                {
                    IconName = "juggernaut_blade_dance",

                    Value = "20\n" +
                            "25\n" +
                            "30\n" +
                            "35"
                },
                new Ability
                {
                    IconName = "juggernaut_omni_slash",
                    Value = " 637 1275\n" +
                            "1275 1912\n" +
                            "1912 2550"
                }
            };
        }
    }
}