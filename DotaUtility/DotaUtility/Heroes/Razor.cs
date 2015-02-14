using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Razor : Hero
	{
		public Razor()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "razor_plasma_field",

					Value = @"120
										172
										225
										277"
				},
				new Ability
				{
					IconName = "razor_static_link_alt",
					Value = @" 56
										112
										168
										224"
				},
				new Ability
				{
					IconName = "razor_unstable_current",

					Value = @"30  4
										52  8
										75 12
										97 16"
				},
				new Ability
				{
					IconName = "razor_eye_of_the_storm",
					Value = @"37
										50
										62"
				}
			};
		}
	}
}