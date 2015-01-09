using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Phoenix : Hero
	{
		public Phoenix()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "phoenix_icarus_dive",
					Value = @" 30 25 4 15
										 90 25 4 15
										150 25 4 15
										210 25 4 15"
				},
				new Ability
				{
					IconName = "phoenix_fire_spirits",
					Value = @" 30  80 4 20
										 90 100 4 20
										150 120 4 20
										210 140 4 20"
				},
				new Ability
				{
					IconName = "phoenix_sun_ray",
					Value = @"135  9 6 36
										180 18 6 36
										225 27 6 36
										270 36 6 36"
				},
				new Ability
				{
					IconName = "phoenix_supernova",
					Value = @"270 1.5  5
										360 2.0  8
										450 2.5 11"
				}
			};
		}
	}
}