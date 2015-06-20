using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Viper : Hero
    {
        public Viper()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "viper_poison_attack" },
                    Value = "15 10\n" +
                            "24 20\n" +
                            "33 30\n" +
                            "42 40"
                },
                new Ability
                {
                    IconNames = new List<string> { "viper_nethertoxin" },
                    Value = " 40\n" +
                            " 80\n" +
                            "120\n" +
                            "160"
                },
                new Ability
                {
                    IconNames = new List<string> { "viper_corrosive_skin" },
                    Value = "30 32\n" +
                            "45 36\n" +
                            "60 40\n" +
                            "75 44"
                },
                new Ability
                {
                    IconNames = new List<string> { "viper_viper_strike" },
                    Value = "220\n" +
                            "370\n" +
                            "540"
                }
            };
        }
    }
}