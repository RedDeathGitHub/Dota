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
                    AdditionalIconNames = new List<string>
                    {
                        "kunkka_divine_anchor_torrent"
                    },
                    Value = " 90 1.5\n" +
                            "130 1.5\n" +
                            "180 1.5\n" +
                            "220 1.5"
                },
                new Ability
                {
                    IconName = "kunkka_tidebringer",
                    AdditionalIconNames = new List<string>
                    {
                        "kunkka_divine_anchor_tidebringer"
                    },
                    Value = "15\n" +
                            "30\n" +
                            "45\n" +
                            "60"
                },
                new Ability
                {
                    IconName = "kunkka_x_marks_the_spot",
                    AdditionalIconNames = new List<string>
                    {
                        "kunkka_divine_anchor_x_marks"
                    },
                    Value = "4 8"
                },
                new Ability
                {
                    IconName = "kunkka_ghostship",
                    AdditionalIconNames = new List<string>
                    {
                        "kunkka_divine_anchor_ghostship"
                    },
                    Value = "300 1.4\n" +
                            "370 1.4\n" +
                            "450 1.4"
                }
            };
        }
    }
}