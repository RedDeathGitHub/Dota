using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Alchemist : Hero
	{
		public Alchemist()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "alchemist_acid_spray",
					Value = @"12 4
										16 5
										20 6
										24 7"
				},
				new Ability
				{
					IconName = "alchemist_unstable_concoction",
					Value = @"150
										220
										290
										360"
				},
				new Ability
				{
					IconName = "alchemist_goblins_greed",

					Value = @" 6 12 3
										 8 20 3
										10 28 3
										12 36 3"
				},
				new Ability
				{
					IconName = "alchemist_chemical_rage",
					Value = @"4  50  25 30
										2  75  87 40
										0 100 150 60"
				}
			};
		}
	}
}