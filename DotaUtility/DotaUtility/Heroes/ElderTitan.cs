using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class ElderTitan : Hero
	{
		public ElderTitan()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "elder_titan_echo_stomp",
					Value = @"60 2
										67 3
										75 4
										82 5"
				},
				new Ability
				{
					IconName = "elder_titan_ancestral_spirit",
					Value = @" 45 10  3
										 67 20  6
										 90 30  9
										112 40 12"
				},
				new Ability
				{
					IconName = "elder_titan_natural_order",

					Value = @" 40 12
										 60 19
										 80 26
										100 33"
				},
				new Ability
				{
					IconName = "elder_titan_earth_splitter",
					Value = @"30 30
										30 40
										30 50"
				}
			};
		}
	}
}