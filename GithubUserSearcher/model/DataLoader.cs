using System;
using System.Threading.Tasks;

namespace GithubUserSearcher
{
	public class DataLoader
	{
		private IDataStorage m_dataStorage; 
		private IGithubUserService m_githubUserService; 

		public DataLoader (IDataStorage dataStorage, IGithubUserService userService)
		{
			m_dataStorage = dataStorage; 
			m_githubUserService = userService; 
		}

		public async Task<GithubUser> GetGithubUser(string username)
		{
			if(m_dataStorage.GetGithubUserFromStorage(username) == null)
			{
				var user = await m_githubUserService.GetGithubUser (username);
				m_dataStorage.AddGithubUserToStorage (user);
				return user; 
			}
			return m_dataStorage.GetGithubUserFromStorage (username);
		}
	}
}

