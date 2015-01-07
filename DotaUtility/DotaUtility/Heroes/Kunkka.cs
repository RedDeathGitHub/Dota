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
					Name = "kunkka_torrent",
					Value = @" 90 1.5 35 1
										135 1.5 35 2
										180 1.5 35 3
										225 1.5 35 4"
				},
				new Ability
				{
					Name = "kunkka_tidebringer",
					Passive = true,
					Value = @"15 500 100
										30 500 100
										45 500 100
										60 600 100"
				},
				new Ability
				{
					Name = "kunkka_x_marks_the_spot",
					Value = @"4 8
										4 8
										4 8
										4 8"
				},
				new Ability
				{
					Name = "kunkka_ghostship",
					Value = @"300 1.4 10
										375 1.4 10
										450 1.4 10"
				}
			};
		}
	}
}