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
					Value = @"4 32
										4 44
										8 56
										8 68"
				},
				new Ability
				{
					IconName = "bristleback_quill_spray",
					Value = @"20 30
										40 32
										60 34
										80 36"
				},
				new Ability
				{
					IconName = "bristleback_bristleback",

					Value = @"16  8
										24 12
										32 16
										40 20"
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