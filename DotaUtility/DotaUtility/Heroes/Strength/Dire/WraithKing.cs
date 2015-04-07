using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class WraithKing : Hero
    {
        public WraithKing()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "skeleton_king_hellfire_blast",
                    Value = " 60 2 20\n" +
                            "120 2 20\n" +
                            "170 2 20\n" +
                            "220 2 20"
                },
                new Ability
                {
                    IconName = "skeleton_king_vampiric_aura",
                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconName = "skeleton_king_mortal_strike",
                    Value = " 5\n" +
                            "15\n" +
                            "20\n" +
                            "30"
                },
                new Ability
                {
                    IconName = "skeleton_king_reincarnation",
                    Value = "70"
                }
            };
        }
    }
}