using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Magnus : Hero
	{
		public Magnus()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "magnataur_shockwave",
					Value = @" 56
										112
										168
										225"
				},
				new Ability
				{
					IconName = "magnataur_empower",
					Value = @"20 40
										30 40
										40 40
										50 40"
				},
				new Ability
				{
					IconName = "magnataur_skewer",
					Value = @" 52 40 2.5
										105 40 2.5
										157 40 2.5
										210 40 2.5"
				},
				new Ability
				{
					IconName = "magnataur_reverse_polarity",
					Value = @" 37 2.2
										 93 3.0
										150 3.7"
				}
			};
		}
	}
}