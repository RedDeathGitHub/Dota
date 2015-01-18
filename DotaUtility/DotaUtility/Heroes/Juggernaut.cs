using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Juggernaut : Hero
	{
		public Juggernaut()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "juggernaut_blade_fury",
					Value = @" 60
										 75
										 90
										105"
				},
				new Ability
				{
					IconName = "juggernaut_healing_ward",
					Value = @"2
										3
										4
										5"
				},
				new Ability
				{
					IconName = "juggernaut_blade_dance",

					Value = @"20
										25
										30
										35"
				},
				new Ability
				{
					IconName = "juggernaut_omni_slash",
					Value = @" 637 1275
										1275 1912
										1912 2550"
				}
			};
		}
	}
}