using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public interface IGithubUserService
	{
		Task<GithubUser> GetGithubUser (string username);
	}
}