using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Lion : Hero
    {
        public Lion()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "lion_impale",
                    Value = " 60 1.0\n" +
                            "100 1.5\n" +
                            "150 2.0\n" +
                            "200 2.5"
                },
                new Ability
                {
                    IconName = "lion_voodoo_fish",
                    Value = "2.5\n" +
                            "3.0\n" +
                            "3.5\n" +
                            "4.0"
                },
                new Ability
                {
                    IconName = "lion_mana_drain",
                    Value = "100\n" +
                            "200\n" +
                            "300\n" +
                            "600"
                },
                new Ability
                {
                    IconName = "lion_finger_of_death",
                    Value = "450 550\n" +
                            "550 650\n" +
                            "650 750"
                }
            };
        }
    }
}