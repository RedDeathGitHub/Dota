using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                            "24 20\n" +
                            "33 30\n" +
                            "42 40"
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

                    Value = "30 32\n" +
                            "45 36\n" +
                            "60 40\n" +
                            "75 44"
                },
                new Ability
                {
                    IconName = "viper_viper_strike",
                    Value = "225\n" +
                            "375\n" +
                            "543"
                }
            };
        }
    }
}