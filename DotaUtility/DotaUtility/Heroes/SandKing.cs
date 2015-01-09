using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class SandKing : Hero
	{
		public SandKing()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "sandking_burrowstrike",
					Value = @" 75 2.2
										120 2.2
										165 2.2
										210 2.2"
				},
				new Ability
				{
					IconName = "sandking_sand_storm",
					Value = @"18 20 1.5
										37 40 1.5
										56 60 1.5
										75 80 1.5"
				},
				new Ability
				{
					IconName = "sandking_caustic_finale",
					Passive = true,
					Value = @" 67 8
										 97 8
										127 8
										165 8"
				},
				new Ability
				{
					IconName = "sandking_epicenter",
					Value = @"495 660 30
										660 825 30
										825 990 30"
				}
			};
		}
	}
}