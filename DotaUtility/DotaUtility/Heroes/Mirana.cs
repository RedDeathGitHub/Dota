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
					Value = @"12
										 9
										 7
										 5"
				},
				new Ability
				{
					IconName = "mirana_leap",

					Value = @"44
										50
										56
										62"
				},
				new Ability
				{
					IconName = "mirana_invis",
					Value = @"45
										63
										82"
				}
			};
		}
	}
}