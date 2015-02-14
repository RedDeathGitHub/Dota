using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class NagaSiren : Hero
	{
		public NagaSiren()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "naga_siren_mirror_image",

					Value = @"20 16
										25 20
										30 25
										35 33"
				},
				new Ability
				{
					IconName = "naga_siren_ensnare",
					Value = @"2
										3
										4
										5"
				},
				new Ability
				{
					IconName = "naga_siren_rip_tide",

					Value = @" 97 2
										120 3
										142 4
										165 5"
				},
				new Ability
				{
					IconName = "naga_siren_song_of_the_siren",
					Value = @"7"
				}
			};
		}
	}
}