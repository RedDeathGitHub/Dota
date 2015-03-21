using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Kunkka : Hero
    {
        public Kunkka()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "kunkka_torrent",
                    Value = " 90 1.5\n" +
                            "135 1.5\n" +
                            "180 1.5\n" +
                            "225 1.5"
                },
                new Ability
                {
                    IconName = "kunkka_tidebringer",

                    Value = "15\n" +
                            "30\n" +
                            "45\n" +
                            "60"
                },
                new Ability
                {
                    IconName = "kunkka_x_marks_the_spot",
                    Value = "4 8"
                },
                new Ability
                {
                    IconName = "kunkka_ghostship",
                    Value = "300 1.4\n" +
                            "375 1.4\n" +
                            "450 1.4"
                }
            };
        }
    }
}