using System.Collections.Generic;

namespace DotaUtility
{
	public class Ability
	{
		public string Name { get; set; }

		public List<string> AlternativeNames { get; set; }

		public string Value { get; set; }

		public bool Passive { get; set; }
	}
}