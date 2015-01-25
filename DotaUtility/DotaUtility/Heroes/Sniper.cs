using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Sniper : Hero
	{
		public Sniper()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "sniper_shrapnel",

					Value = @" 9 15
										18 20
										27 25
										36 30"
				},
				new Ability
				{
					IconName = "sniper_headshot",
					Value = @" 6
										16
										26
										36"
				},
				new Ability
				{
					IconName = "sniper_take_aim",

					Value = @""
				},
				new Ability
				{
					IconName = "sniper_assassinate",
					Value = @"266
										378
										491"
				}
			};
		}
	}
}