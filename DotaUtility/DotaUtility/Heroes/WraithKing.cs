using System.Collections.Generic;

namespace DotaUtility.Heroes
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
					Value = @" 60 2 20 2
										120 2 20 2
										172 2 20 2
										225 2 20 2"
				},
				new Ability
				{
					IconName = "skeleton_king_vampiric_aura",
					Passive = true,
					Value = @"15
										20
										25
										30"
				},
				new Ability
				{
					IconName = "skeleton_king_mortal_strike",
					Passive = true,
					Value = @" 7
										15
										22
										30"
				},
				new Ability
				{
					IconName = "skeleton_king_reincarnation",
					Passive = true,
					Value = @"3 75 5"
				}
			};
		}
	}
}