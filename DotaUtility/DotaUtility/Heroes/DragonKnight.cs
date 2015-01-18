using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class DragonKnight : Hero
	{
		public DragonKnight()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "dragon_knight_breathe_fire",
					Value = @" 67
										127
										180
										225"
				},
				new Ability
				{
					IconName = "dragon_knight_dragon_tail",
					Value = @"18 2.5
										37 2.7
										56 3.0
										75 3.2"
				},
				new Ability
				{
					IconName = "dragon_knight_dragon_blood",

					Value = @"2  3
										3  6
										4  9
										5 12"
				},
				new Ability
				{
					IconName = "dragon_knight_elder_dragon_form",
					Value = @"75 25
										20 30"
				}
			};
		}
	}
}