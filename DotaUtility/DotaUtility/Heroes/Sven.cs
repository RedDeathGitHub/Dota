using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Sven : Hero
	{
		public Sven()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					Name = "sven_storm_bolt",
					Value = @" 75 2
										131 2
										187 2
										243 2"
				},
				new Ability
				{
					Name = "sven_great_cleave",
					Passive = true,
					Value = @"20
										35
										50
										65"
				},
				new Ability
				{
					Name = "sven_warcry",
					Value = @" 4 12 8
										 8 12 8
										12 12 8
										16 12 8"
				},
				new Ability
				{
					Name = "sven_gods_strength",
					Value = @"100  50 25
										150  75 25
										200 100 25"
				}
			};
		}
	}
}