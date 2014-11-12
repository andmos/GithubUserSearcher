using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GithubUserSearcher
{
	public interface IGithubUserService
	{
		Task<IEnumerable<GithubUser>> GetGithubUser (string username);
	}
}