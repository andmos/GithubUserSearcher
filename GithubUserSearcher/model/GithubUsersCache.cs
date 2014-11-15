using System;

using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public class GithubUsersCache : IDataStorage 
	{
		//ConcurrentDictionary gives me reference-trouble??  
		private readonly Dictionary<string, GithubUser> m_githubUsersCache; 

		public GithubUsersCache () 
		{
			m_githubUsersCache = new Dictionary<string, GithubUser> (); 
		}

		public IEnumerable<GithubUser> GetAllUsersFromStorage ()
		{
			return m_githubUsersCache.Values; 
		}

		public GithubUser GetGithubUserFromStorage (string username)
		{
			GithubUser user; 
			return m_githubUsersCache.TryGetValue (username, out user) ? user : null;
		}

		public void AddGithubUserToStorage (GithubUser user)
		{
			m_githubUsersCache.Add (user.UserName, user); 
		}


	}
}

