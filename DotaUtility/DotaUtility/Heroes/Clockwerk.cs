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
					Name = "rattletrap_battery_assault",
					Value = @"240 15 16
										480 30 16
										720 45 16
										960 60 16"
				},
				new Ability
				{
					Name = "rattletrap_power_cogs",
					Value = @" 80 2 5
										120 2 6
										160 2 7
										200 3 8"
				},
				new Ability
				{
					Name = "rattletrap_rocket_flare",
					Value = @" 60
										 90
										120
										150"
				},
				new Ability
				{
					Name = "rattletrap_hookshot",
					Value = @" 75 1.0
										150 1.5
										225 2.0"
				}
			};
		}
	}
}