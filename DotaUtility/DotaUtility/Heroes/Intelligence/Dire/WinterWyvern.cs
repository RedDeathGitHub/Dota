using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class WinterWyvern : Hero
    {
        public WinterWyvern()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "winter_wyvern_arctic_burn" },
                    Value = "30 25\n" +
                            "30 30\n" +
                            "30 35\n" +
                            "30 40"
                },
                new Ability
                {
                    IconNames = new List<string> { "winter_wyvern_splinter_blast" },
                    Value = " 70\n" +
                            "130\n" +
                            "200\n" +
                            "250"
                },
                new Ability
                {
                    IconNames = new List<string> { "winter_wyvern_cold_embrace" },
                    Value = "80 12\n" +
                            "80 16\n" +
                            "80 20\n" +
                            "80 24"
                },
                new Ability
                {
                    IconNames = new List<string> { "winter_wyvern_winters_curse" },
                    Value = "2.5 70\n" +
                            "3.0 70\n" +
                            "3.5 70"
                }
            };
        }
    }
}