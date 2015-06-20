using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Timbersaw : Hero
    {
        public Timbersaw()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "shredder_whirling_death" },
                    Value = "100 15\n" +
                            "150 15\n" +
                            "200 15\n" +
                            "250 15"
                },
                new Ability
                {
                    IconNames = new List<string> { "shredder_timber_chain" },
                    Value = "100\n" +
                            "140\n" +
                            "180\n" +
                            "220"
                },
                new Ability
                {
                    IconNames = new List<string> { "shredder_reactive_armor" },
                    Value = " 5\n" +
                            "10\n" +
                            "15\n" +
                            "20"
                },
                new Ability
                {
                    IconNames = new List<string> { "shredder_chakram" },
                    Value = "100  50\n" +
                            "140  75\n" +
                            "180 100"
                }
            };
        }
    }
}