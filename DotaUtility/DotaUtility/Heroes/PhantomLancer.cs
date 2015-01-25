using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class PhantomLancer : Hero
	{
		public PhantomLancer()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "phantom_lancer_spirit_lance",

					Value = @" 75 10
										112 20
										150 30
										187 40"
				},
				new Ability
				{
					IconName = "phantom_lancer_doppelwalk",
					Value = @""
				},
				new Ability
				{
					IconName = "phantom_lancer_phantom_edge",

					Value = @""
				},
				new Ability
				{
					IconName = "phantom_lancer_juxtapose",
					Value = @"5 16 20
										7 16 20
										9 16 20"
				}
			};
		}
	}
}