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
                    IconName = "viper_poison_attack",

                    Value = "15 10\n" +
                            "25 20\n" +
                            "30 30\n" +
                            "40 40"
                },
                new Ability
                {
                    IconName = "viper_nethertoxin",
                    Value = " 40\n" +
                            " 80\n" +
                            "120\n" +
                            "160"
                },
                new Ability
                {
                    IconName = "viper_corrosive_skin",

                    Value = "30 30\n" +
                            "40 35\n" +
                            "60 40\n" +
                            "70 45"
                },
                new Ability
                {
                    IconName = "viper_viper_strike",
                    Value = "220\n" +
                            "370\n" +
                            "540"
                }
            };
        }
    }
}