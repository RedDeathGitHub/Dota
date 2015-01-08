using System.Collections.Generic;

namespace DotaUtility
{
	public class Ability
	{
		public string IconName { get; set; }

		public List<string> AdditionalIconNames { get; set; }

		public string Value { get; set; }

		public bool Passive { get; set; }
	}
}