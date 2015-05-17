using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class DragonKnight : Hero
    {
        public DragonKnight()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "dragon_knight_breathe_fire",
                    Value = " 60 20\n" +
                            "120 25\n" +
                            "180 30\n" +
                            "220 35"
                },
                new Ability
                {
                    IconName = "dragon_knight_dragon_tail",
                    Value = "20 2.5\n" +
                            "40 2.7\n" +
                            "60 3.0\n" +
                            "75 3.2"
                },
                new Ability
                {
                    IconName = "dragon_knight_dragon_blood",

                    Value = "2  3\n" +
                            "3  6\n" +
                            "4  9\n" +
                            "5 12"
                },
                new Ability
                {
                    IconName = "dragon_knight_elder_dragon_form",
                    Value = "75 25\n" +
                            "20 30"
                }
            };
        }
    }
}