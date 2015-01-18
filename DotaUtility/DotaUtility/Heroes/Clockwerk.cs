using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Clockwerk : Hero
	{
		public Clockwerk()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "rattletrap_battery_assault",
					Value = @"240 15
										480 30
										720 45
										960 60"
				},
				new Ability
				{
					IconName = "rattletrap_power_cogs",
					Value = @" 80  60
										120  90
										160 120
										200 150"
				},
				new Ability
				{
					IconName = "rattletrap_rocket_flare",
					Value = @" 60
										 90
										120
										150"
				},
				new Ability
				{
					IconName = "rattletrap_hookshot",
					Value = @" 75 1.0
										150 1.5
										225 2.0"
				}
			};
		}
	}
}