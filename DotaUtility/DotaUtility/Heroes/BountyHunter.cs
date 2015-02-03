using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class BountyHunter : Hero
	{
		public BountyHunter()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "bounty_hunter_shuriken_toss",

					Value = @" 75
										150
										187
										243"
				},
				new Ability
				{
					IconName = "bounty_hunter_jinada",
					Value = @"150 25
										175 25
										200 25
										225 25"
				},
				new Ability
				{
					IconName = "bounty_hunter_wind_walk",

					Value = @" 30 1.0
										 60 0.7
										 90 0.5
										120 0.3"
				},
				new Ability
				{
					IconName = "bounty_hunter_track",
					Value = @"200  50
										275 100
										350 150"
				}
			};
		}
	}
}