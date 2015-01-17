using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Abaddon : Hero
	{
		public Abaddon()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "abaddon_death_coil",
					Value = @" 75  75
										112 100
										150 125
										187 150"
				},
				new Ability
				{
					IconName = "abaddon_aphotic_shield",
					Value = @" 82 110
										105 140
										127 170
										150 200"
				},
				new Ability
				{
					IconName = "abaddon_frostmourne",

					Value = @" 5 10
										10 20
										15 30
										20 40"
				},
				new Ability
				{
					IconName = "abaddon_borrowed_time",
					Value = @"4 400 5
										5 400 6
										6 400 7"
				}
			};
		}
	}
}