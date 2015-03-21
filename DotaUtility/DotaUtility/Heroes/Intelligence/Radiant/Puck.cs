using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Puck : Hero
    {
        public Puck()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "puck_illusory_orb",
                    Value = " 52\n" +
                            "105\n" +
                            "157\n" +
                            "210"
                },
                new Ability
                {
                    IconName = "puck_waning_rift",
                    Value = " 52 0.7\n" +
                            "105 1.5\n" +
                            "157 2.2\n" +
                            "210 3.0"
                },
                new Ability
                {
                    IconName = "puck_phase_shift",
                    Value = "0.7\n" +
                            "1.5\n" +
                            "2.2\n" +
                            "3.2"
                },
                new Ability
                {
                    IconName = "puck_dream_coil",
                    Value = "1.5 1.5\n" +
                            "2.2 3.0\n" +
                            "3.0 4.5"
                }
            };
        }
    }
}