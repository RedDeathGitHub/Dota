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
					Value = @" 80 60 2
										 90 67 3
										100 75 4
										110 82 5"
				},
				new Ability
				{
					IconName = "elder_titan_ancestral_spirit",
					Value = @" 45 10 5  3
										 67 20 5  6
										 90 30 5  9
										112 40 5 12"
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
					Value = @"35 30 3 4
										35 40 4 5
										35 50 5 6"
				}
			};
		}
	}
}