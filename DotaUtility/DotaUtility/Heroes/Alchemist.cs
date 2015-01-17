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
					Value = @"150 1.7
										220 2.5
										290 3.2
										360 4.0"
				},
				new Ability
				{
					IconName = "alchemist_goblins_greed",

					Value = @" 6 12
										 8 20
										10 28
										12 36"
				},
				new Ability
				{
					IconName = "alchemist_chemical_rage",
					Value = @" 50  25
										 75  87
										100 150"
				}
			};
		}
	}
}