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
					IconName = "brewmaster_thunder_clap",

					Value = @" 75 25
										131 35
										187 45
										225 55"
				},
				new Ability
				{
					IconName = "brewmaster_drunken_haze",
					Value = @"45 14
										55 18
										65 22
										75 26"
				},
				new Ability
				{
					IconName = "brewmaster_drunken_brawler",
					AdditionalIconNames = new List<string>
					{
						"brewmaster_drunken_brawler_active",
						"brewmaster_drunken_brawler_crit",
						"brewmaster_drunken_brawler_miss"
					},

					Value = @"10 16
										15 14
										20 12
										25 10"
				},
				new Ability
				{
					IconName = "brewmaster_primal_split",
					Value = @"15
										17
										19"
				}
			};
		}
	}
}