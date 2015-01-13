using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Slardar : Hero
	{
		public Slardar()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "slardar_sprint",

					Value = @"20 15
										28 15
										36 15
										44 15"
				},
				new Ability
				{
					IconName = "slardar_slithereen_crush",
					Value = @" 50 1.6 20 2
										100 1.9 20 2
										150 2.2 20 2
										200 2.5 20 2"
				},
				new Ability
				{
					IconName = "slardar_bash",

					Value = @"10  60 1
										15  80 1
										20 100 1
										25 120 1"
				},
				new Ability
				{
					IconName = "slardar_amplify_damage",
					Value = @"10 25
										15 25
										20 25"
				}
			};
		}
	}
}