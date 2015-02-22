using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Spectre : Hero
	{
		public Spectre()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "spectre_spectral_dagger",

					Value = @" 37  8
										 75 12
										112 16
										150 20"
				},
				new Ability
				{
					IconName = "spectre_desolate",
					Value = @"20
										35
										50
										65"
				},
				new Ability
				{
					IconName = "spectre_dispersion",

					Value = @"10
										14
										18
										22"
				},
				new Ability
				{
					IconName = "spectre_haunt",
					Value = @"30 50"
				}
			};
		}
	}
}