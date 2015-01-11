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
					Value = @" 60 5
										 75 5
										 90 5
										105 5"
				},
				new Ability
				{
					IconName = "juggernaut_healing_ward",
					Value = @"2 25
										3 25
										4 25
										5 25"
				},
				new Ability
				{
					IconName = "juggernaut_blade_dance",
					Passive = true,
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