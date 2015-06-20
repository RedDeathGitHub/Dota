using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Riki : Hero
    {
        public Riki()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "riki_smoke_screen" },
                    Value = "40 30 25\n" +
                            "50 30 25\n" +
                            "60 30 25\n" +
                            "70 30 25"
                },
                new Ability
                {
                    IconNames = new List<string> { "riki_permanent_invisibility" },
                    Value = "8 4\n" +
                            "6 5\n" +
                            "4 6\n" +
                            "2 7"
                },
                new Ability
                {
                    IconNames = new List<string> { "riki_backstab" },
                    Value = " 50\n" +
                            " 75\n" +
                            "100\n" +
                            "125"
                },
                new Ability
                {
                    IconNames = new List<string> { "riki_blink_strike" },
                    Value = "30\n" +
                            "50\n" +
                            "75"
                }
            };
        }
    }
}