using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Doom : Hero
    {
        public Doom()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "doom_bringer_devour" },
                    Value = " 25\n" +
                            " 50\n" +
                            " 75\n" +
                            "100"
                },
                new Ability
                {
                    IconNames = new List<string> { "doom_bringer_scorched_earth" },
                    Value = " 90\n" +
                            "160\n" +
                            "250\n" +
                            "360"
                },
                new Ability
                {
                    IconNames = new List<string> { "doom_bringer_lvl_death" },
                    Value = " 90\n" +
                            "130\n" +
                            "160\n" +
                            "200"
                },
                new Ability
                {
                    IconNames = new List<string> { "doom_bringer_doom" },
                    Value = "300\n" +
                            "525\n" +
                            "750"
                }
            };
        }
    }
}