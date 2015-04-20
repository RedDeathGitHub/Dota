using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Lich : Hero
    {
        public Lich()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "lich_frost_nova",
                    Value = " 90\n" +
                            "150\n" +
                            "200\n" +
                            "260"
                },
                new Ability
                {
                    IconName = "lich_frost_armor",
                    Value = "3\n" +
                            "5\n" +
                            "7\n" +
                            "9"
                },
                new Ability
                {
                    IconName = "lich_dark_ritual",
                    Value = "25\n" +
                            "40\n" +
                            "55\n" +
                            "70"
                },
                new Ability
                {
                    IconName = "lich_chain_frost",
                    Value = "1200\n" +
                            "1600\n" +
                            "2000"
                }
            };
        }
    }
}