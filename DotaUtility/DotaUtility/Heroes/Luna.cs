using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Luna : Hero
	{
		public Luna()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "luna_lucent_beam",

					Value = @" 56 0.6
										112 0.6
										168 0.6
										225 0.6"
				},
				new Ability
				{
					IconName = "luna_moon_glaive",
					Value = @" 65
										107
										135
										172"
				},
				new Ability
				{
					IconName = "luna_lunar_blessing",

					Value = @"14
										22
										30
										38"
				},
				new Ability
				{
					IconName = "luna_eclipse",
					Value = @"900 3150"
				}
			};
		}
	}
}