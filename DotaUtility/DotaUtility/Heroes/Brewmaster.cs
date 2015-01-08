using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Brewmaster : Hero
	{
		public Brewmaster()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					Name = "brewmaster_thunder_clap",
					Passive = true,
					Value = @" 75 25 4
										131 35 4
										187 45 4
										225 55 4"
				},
				new Ability
				{
					Name = "brewmaster_drunken_haze",
					Value = @"45 14 8
										55 18 8
										65 22 8
										75 26 8"
				},
				new Ability
				{
					Name = "brewmaster_drunken_brawler",
					AlternativeNames = new List<string>
					{
						"brewmaster_drunken_brawler_active",
						"brewmaster_drunken_brawler_crit",
						"brewmaster_drunken_brawler_miss"
					},
					Passive = true,
					Value = @"10 16
										15 14
										20 12
										25 10"
				},
				new Ability
				{
					Name = "brewmaster_primal_split",
					Value = @"75  2 15
										 6 20 17
										11 33 19"
				}
			};
		}
	}
}