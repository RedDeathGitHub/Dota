using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class OutworldDevourer : Hero
    {
        public OutworldDevourer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "obsidian_destroyer_arcane_orb",
                    Value = "6 100\n" +
                            "7 200\n" +
                            "8 300\n" +
                            "9 400"
                },
                new Ability
                {
                    IconName = "obsidian_destroyer_astral_imprisonment",
                    Value = " 4 1\n" +
                            " 7 2\n" +
                            "10 3\n" +
                            "13 4"
                },
                new Ability
                {
                    IconName = "obsidian_destroyer_essence_aura",
                    Value = "10  75\n" +
                            "15 150\n" +
                            "20 225\n" +
                            "25 300"
                },
                new Ability
                {
                    IconName = "obsidian_destroyer_sanity_eclipse",
                    Value = " 8 10\n" +
                            " 9 30\n" +
                            "10 50"
                }
            };
        }
    }
}