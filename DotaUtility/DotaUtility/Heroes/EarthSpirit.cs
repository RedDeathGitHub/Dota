using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class EarthSpirit : Hero
	{
		public EarthSpirit()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "earth_spirit_boulder_smash",
					Value = @"93 0.7
										93 1.2
										93 1.7
										93 2.2"
				},
				new Ability
				{
					IconName = "earth_spirit_rolling_boulder",
					Value = @"75 80"
				},
				new Ability
				{
					IconName = "earth_spirit_geomagnetic_grip",
					Value = @" 37 2.5
										 93 3.0
										150 3.5
										206 4.0"
				},
				new Ability
				{
					IconName = "earth_spirit_magnetize",
					Value = @"225 225
										337 225
										450 225"
				}
			};
		}
	}
}