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
					Value = @" 75 1 2
										135 1 2
										195 1 2
										225 1 2"
				},
				new Ability
				{
					IconName = "tiny_toss",
					Value = @" 56 101 1.3
										112 202 1.3
										168 303 1.3
										225 405 1.3"
				},
				new Ability
				{
					IconName = "tiny_craggy_exterior",
					Passive = true,
					Value = @"10 18 00 2
										15 26 25 3
										20 33 50 4
										25 41 75 5"
				},
				new Ability
				{
					IconName = "tiny_grow",
					Passive = true,
					Value = @"20  50 40
										35 100 50
										50 150 60"
				}
			};
		}
	}
}