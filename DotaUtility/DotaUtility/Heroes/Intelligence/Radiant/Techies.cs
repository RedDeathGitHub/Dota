using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Techies : Hero
    {
        public Techies()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "techies_land_mines",
                    Value = "300\n" +
                            "375\n" +
                            "450\n" +
                            "525"
                },
                new Ability
                {
                    IconName = "techies_stasis_trap",
                    Value = "2.5\n" +
                            "3.0\n" +
                            "3.5\n" +
                            "4.0"
                },
                new Ability
                {
                    IconName = "techies_suicide",
                    Value = " 500\n" +
                            " 650\n" +
                            " 850\n" +
                            "1150"
                },
                new Ability
                {
                    IconName = "techies_remote_mines",
                    Value = "225 337\n" +
                            "337 450\n" +
                            "450 562"
                }
            };
        }
    }
}