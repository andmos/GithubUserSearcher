using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GithubUserSearcher
{
	public class FilebasedGithubUserService : IGithubUserService
	{

		public Task<GithubUser> GetGithubUser (string username)
		{
			return Task.Factory.StartNew(() => JsonConvert.DeserializeObject<GithubUser>("andmos.json"));  
		}


	}
}

