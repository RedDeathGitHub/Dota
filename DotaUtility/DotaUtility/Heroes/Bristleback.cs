using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Bristleback : Hero
	{
		public Bristleback()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "bristleback_viscous_nasal_goo",
					Value = @"1 20  3 4
										1 20  6 4
										2 20  9 4
										2 20 12 4"
				},
				new Ability
				{
					IconName = "bristleback_quill_spray",
					Value = @"20 30 14
										40 32 14
										60 34 14
										80 36 14"
				},
				new Ability
				{
					IconName = "bristleback_bristleback",

					Value = @"16  8 250
										24 12 250
										32 16 250
										40 20 250"
				},
				new Ability
				{
					IconName = "bristleback_warpath",

					Value = @"5 100 15
										6 150 24
										7 210 35"
				}
			};
		}
	}
}