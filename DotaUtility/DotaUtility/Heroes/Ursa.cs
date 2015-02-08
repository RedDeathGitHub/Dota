using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Ursa : Hero
	{
		public Ursa()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "ursa_earthshock",

					Value = @" 67 25
										105 35
										142 45
										180 55"
				},
				new Ability
				{
					IconName = "ursa_overpower",
					Value = @"3
										4
										5
										6"
				},
				new Ability
				{
					IconName = "ursa_fury_swipes",

					Value = @"15
										20
										25
										30"
				},
				new Ability
				{
					IconName = "ursa_enrage",
					Value = @"5
										6
										7"
				}
			};
		}
	}
}