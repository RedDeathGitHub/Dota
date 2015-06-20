using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Chen : Hero
    {
        public Chen()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "chen_penitence" },
                    Value = "14\n" +
                            "18\n" +
                            "22\n" +
                            "26"
                },
                new Ability
                {
                    IconNames = new List<string> { "chen_test_of_faith" },
                    Value = " 50 100\n" +
                            "100 200\n" +
                            "150 300\n" +
                            "200 400"
                },
                 new Ability
                {
                    IconNames = new List<string> { "chen_test_of_faith_teleport" },
                    Value = "6\n" +
                            "5\n" +
                            "4\n" +
                            "3"
                },
                new Ability
                {
                    IconNames = new List<string> { "chen_holy_persuasion" },
                    Value = "1  700\n" +
                            "2  800\n" +
                            "3  900\n" +
                            "4 1000"
                },
                new Ability
                {
                    IconNames = new List<string> { "chen_hand_of_god" },
                    Value = "200\n" +
                            "300\n" +
                            "400"
                }
            };
        }
    }
}