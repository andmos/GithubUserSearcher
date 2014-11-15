using NUnit.Framework;
using System;
using System.Threading.Tasks;
using GithubUserSearcher;

namespace TestGithubUserSearcher {
	[TestFixture()]
	public class GithubUserWebServiceTests {
		private GithubUserWebService githubUserWebService;

		[TestFixtureSetUp]
		public void Init() {
			githubUserWebService = new GithubUserWebService();
		}

		[Test()]
		public async Task GetGithubUser_ValidGithubUserName_GitHubUserIsFetched() {
			const string UserName = "Sankra";

			var user = await githubUserWebService.GetGithubUser(UserName);

			Assert.AreEqual(UserName, user.UserName);
		}
	}
}

