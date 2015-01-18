using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Kunkka : Hero
	{
		public Kunkka()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "kunkka_torrent",
					Value = @" 90 1.5
										135 1.5
										180 1.5
										225 1.5"
				},
				new Ability
				{
					IconName = "kunkka_tidebringer",

					Value = @"15
										30
										45
										60"
				},
				new Ability
				{
					IconName = "kunkka_x_marks_the_spot",
					Value = @"4 8"
				},
				new Ability
				{
					IconName = "kunkka_ghostship",
					Value = @"300 1.4
										375 1.4
										450 1.4"
				}
			};
		}
	}
}