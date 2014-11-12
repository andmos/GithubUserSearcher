using System;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public interface IDataStorage
	{
		IEnumerable<GithubUser> GetAllUsersFromStorage ();
		GithubUser GetGithubUserFromStorage(string username); 
		void AddGithubUserToStorage (GithubUser user); 
	}
}

