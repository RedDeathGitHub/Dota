using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Tusk : Hero
	{
		public Tusk()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "tusk_ice_shards",
					Value = @" 52
										105
										157
										210"
				},
				new Ability
				{
					IconName = "tusk_snowball",
					Value = @" 60 15 0.5
										 90 22 0.7
										120 30 1.0
										150 37 1.2"
				},
				new Ability
				{
					IconName = "tusk_frozen_sigil",
					Value = @"30 10
										40 15
										50 20
										60 25"
				},
				new Ability
				{
					IconName = "tusk_walrus_punch",
					Value = @"350 1 40
										350 1 40
										350 1 40"
				}
			};
		}
	}
}