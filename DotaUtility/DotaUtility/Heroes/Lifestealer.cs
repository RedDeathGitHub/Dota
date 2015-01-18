using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Lifestealer : Hero
	{
		public Lifestealer()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "life_stealer_rage",
					Value = @"30 3
										45 4
										60 5
										80 6"
				},
				new Ability
				{
					IconName = "life_stealer_feast",

					Value = @"4
										5
										6
										7"
				},
				new Ability
				{
					IconName = "life_stealer_open_wounds",
					Value = @"15
										20
										25
										30"
				},
				new Ability
				{
					IconName = "life_stealer_infest",
					Value = @"112
										206
										300"
				}
			};
		}
	}
}