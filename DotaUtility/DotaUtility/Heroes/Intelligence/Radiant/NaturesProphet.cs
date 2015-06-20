using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class NaturesProphet : Hero
    {
        public NaturesProphet()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "furion_sprout" },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string> { "furion_teleportation" },
                    Value = "50\n" +
                            "40\n" +
                            "30\n" +
                            "20"
                },
                new Ability
                {
                    IconNames = new List<string> { "furion_force_of_nature" },
                    Value = "2\n" +
                            "3\n" +
                            "4\n" +
                            "5"
                },
                new Ability
                {
                    IconNames = new List<string> { "furion_wrath_of_nature" },
                    Value = "300 370\n" +
                            "370 500\n" +
                            "460 650"
                }
            };
        }
    }
}