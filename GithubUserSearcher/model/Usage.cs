using System;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public class Usage
	{
		public IEnumerable<int> day { get; set; }
		public IEnumerable<Event> events { get; set; }
		public IEnumerable<Language> languages { get; set; }
		public int total { get; set; }
		public IEnumerable<int> week { get; set; }
	}
}

