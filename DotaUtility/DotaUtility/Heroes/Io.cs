using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Io : Hero
	{
		public Io()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "wisp_tether",
					Value = @"0.75 100 17
										1.25 100 17
										1.75 100 17
										2.25 100 17"
				},
				new Ability
				{
					IconName = "wisp_spirits",
					Value = @"125
										187
										281
										375"
				},
				new Ability
				{
					IconName = "wisp_overcharge",
					Value = @"40  5 4.5
										50 10 4.5
										60 15 4.5
										70 20 4.5"
				},
				new Ability
				{
					IconName = "wisp_relocate",
					Value = @"2.5 12
										2.2 12
										2.0 12"
				}
			};
		}
	}
}