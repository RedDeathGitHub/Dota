using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Riki : Hero
	{
		public Riki()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "riki_smoke_screen",

					Value = @"40 25
										50 25
										60 25
										70 25"
				},
				new Ability
				{
					IconName = "riki_permanent_invisibility",
					Value = @"8 4
										6 5
										4 6
										2 7"
				},
				new Ability
				{
					IconName = "riki_backstab",

					Value = @" 50
										 75
										100
										125"
				},
				new Ability
				{
					IconName = "riki_blink_strike",
					Value = @"30
										52
										75"
				}
			};
		}
	}
}