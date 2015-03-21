using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Doom : Hero
    {
        public Doom()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "doom_bringer_devour",
                    Value = " 25\n" +
                            " 50\n" +
                            " 75\n" +
                            "100"
                },
                new Ability
                {
                    IconName = "doom_bringer_scorched_earth",
                    Value = " 90\n" +
                            "162\n" +
                            "252\n" +
                            "360"
                },
                new Ability
                {
                    IconName = "doom_bringer_lvl_death",
                    Value = " 93\n" +
                            "131\n" +
                            "168\n" +
                            "206"
                },
                new Ability
                {
                    IconName = "doom_bringer_doom",
                    Value = "300\n" +
                            "525\n" +
                            "750"
                }
            };
        }
    }
}