using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Gyrocopter : Hero
    {
        public Gyrocopter()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "gyrocopter_rocket_barrage",

                    Value = "247\n" +
                            "337\n" +
                            "427\n" +
                            "517"
                },
                new Ability
                {
                    IconName = "gyrocopter_homing_missile",
                    Value = " 93 2.2\n" +
                            "187 2.4\n" +
                            "281 2.6\n" +
                            "375 2.8"
                },
                new Ability
                {
                    IconName = "gyrocopter_flak_cannon",

                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "gyrocopter_call_down",
                    Value = "262 318\n" +
                            "337 393\n" +
                            "412 468"
                }
            };
        }
    }
}