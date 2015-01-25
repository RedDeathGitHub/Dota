﻿using System.Collections.Generic;

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
					Value = @" 30 25 4
										 90 25 4
										150 25 4
										210 25 4"
				},
				new Ability
				{
					IconName = "phoenix_fire_spirits",
					Value = @" 30  80 4
										 90 100 4
										150 120 4
										210 140 4"
				},
				new Ability
				{
					IconName = "phoenix_sun_ray",
					Value = @"135  9
										180 18
										225 27
										270 36"
				},
				new Ability
				{
					IconName = "phoenix_supernova",
					Value = @"270 1.5
										360 2.0
										450 2.5"
				}
			};
		}
	}
}