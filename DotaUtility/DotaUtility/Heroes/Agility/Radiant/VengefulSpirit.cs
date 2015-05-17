using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class VengefulSpirit : Hero
    {
        public VengefulSpirit()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "vengefulspirit_magic_missile",

                    Value = " 70 1.4\n" +
                            "130 1.5\n" +
                            "180 1.6\n" +
                            "240 1.7"
                },
                new Ability
                {
                    IconName = "vengefulspirit_wave_of_terror",
                    Value = "30 3\n" +
                            "50 4\n" +
                            "70 5\n" +
                            "90 6"
                },
                new Ability
                {
                    IconName = "vengefulspirit_command_aura",

                    Value = "12\n" +
                            "20\n" +
                            "28\n" +
                            "36"
                },
                new Ability
                {
                    IconName = "vengefulspirit_nether_swap",
                    Value = ""
                }
            };
        }
    }
}