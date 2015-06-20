using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Bane : Hero
    {
        public Bane()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "bane_enfeeble" },
                    Value = " 30\n" +
                            " 60\n" +
                            " 90\n" +
                            "120"
                },
                new Ability
                {
                    IconNames = new List<string> { "bane_brain_sap" },
                    Value = " 90\n" +
                            "160\n" +
                            "230\n" +
                            "300"
                },
                new Ability
                {
                    IconNames = new List<string> { "bane_nightmare" },
                    Value = " 80 4\n" +
                            "100 5\n" +
                            "120 6\n" +
                            "140 7"
                },
                new Ability
                {
                    IconNames = new List<string> { "bane_fiends_grip" },
                    Value = "370  800\n" +
                            "580 1100\n" +
                            "800 1400"
                }
            };
        }
    }
}