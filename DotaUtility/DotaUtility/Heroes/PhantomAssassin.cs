﻿using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class PhantomAssassin : Hero
	{
		public PhantomAssassin()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "phantom_assassin_stifling_dagger",
					Value = @"30 2 50 1
										50 2 50 2
										70 2 50 3
										90 2 50 4"
				},
				new Ability
				{
					IconName = "phantom_assassin_phantom_strike",
					Value = @"130 4"
				},
				new Ability
				{
					IconName = "phantom_assassin_blur",
					Passive = true,
					Value = @"20
										30
										40
										50"
				},
				new Ability
				{
					IconName = "phantom_assassin_coup_de_grace",
					Passive = true,
					Value = @"20
										36
										52"
				}
			};
		}
	}
}