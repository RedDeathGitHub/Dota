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
					Value = @"18 2.50
										37 2.75
										56 3.00
										75 3.25"
				},
				new Ability
				{
					IconName = "dragon_knight_dragon_blood",
					Passive = true,
					Value = @"2  3
										3  6
										4  9
										5 12"
				},
				new Ability
				{
					IconName = "dragon_knight_elder_dragon_form",
					Value = @" 20 5 25 60
										  250 25 60
										20 30 25 60"
				}
			};
		}
	}
}