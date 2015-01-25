using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Tiny : Hero
	{
		public Tiny()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "tiny_avalanche",
					Value = @" 75 1
										135 1
										195 1
										225 1"
				},
				new Ability
				{
					IconName = "tiny_toss",
					Value = @" 56 101
										112 202
										168 303
										225 405"
				},
				new Ability
				{
					IconName = "tiny_craggy_exterior",

					Value = @"10 1.0 2
										15 1.2 3
										20 1.5 4
										25 1.7 5"
				},
				new Ability
				{
					IconName = "tiny_grow",

					Value = @"20  50 40
										35 100 50
										50 150 60"
				}
			};
		}
	}
}