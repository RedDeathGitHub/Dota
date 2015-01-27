using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class TemplarAssassin : Hero
	{
		public TemplarAssassin()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "templar_assassin_refraction",

					Value = @"3 20
										4 40
										5 60
										6 80"
				},
				new Ability
				{
					IconName = "templar_assassin_meld",
					Value = @" 50 2
										100 4
										150 6
										200 8"
				},
				new Ability
				{
					IconName = "templar_assassin_psi_blades",

					Value = @""
				},
				new Ability
				{
					IconName = "templar_assassin_psionic_trap",
					Value = @"5  50
										8  50
										11 50"
				}
			};
		}
	}
}