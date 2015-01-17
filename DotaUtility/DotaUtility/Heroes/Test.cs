using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Test : Hero
	{
		public Test()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "abaddon_death_coil",
					Value = @" 75 112
										150 187"
				},
				new Ability
				{
					IconName = "abaddon_aphotic_shield",
					Value = @" 82 105
										127 150"
				},
				new Ability
				{
					IconName = "abaddon_frostmourne",

					Value = @" 5 10
										15 20"
				},
				new Ability
				{
					IconName = "abaddon_borrowed_time",
					Value = @"4 5
										6"
				}
			};
		}
	}
}