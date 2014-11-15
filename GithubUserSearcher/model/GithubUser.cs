using System;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public class GithubUser
	{
		public string avatar { get; set; }
		public List<ConnectedUser> connected_users { get; set; }
		public string Name { get; set; }
		public List<Repository> repositories { get; set; }
		public List<SimilarUser> similar_users { get; set; }
		public int timezone { get; set; }
		public Usage usage { get; set; }
		public string UserName { get; set; }
	}
}

