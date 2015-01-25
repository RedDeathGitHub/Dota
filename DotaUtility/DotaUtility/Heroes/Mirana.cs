using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Mirana : Hero
	{
		public Mirana()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "mirana_starfall",

					Value = @" 98
										196
										294
										394"
				},
				new Ability
				{
					IconName = "mirana_arrow",
					Value = @" 37
										105
										172
										240"
				},
				new Ability
				{
					IconName = "mirana_leap",

					Value = @" 8  4
										16  8
										24 12
										32 16"
				},
				new Ability
				{
					IconName = "mirana_invis",
					Value = @"2.5 15
										2.0 15
										1.5 15"
				}
			};
		}
	}
}