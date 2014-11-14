using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using ModernHttpClient;

namespace GithubUserSearcher
{
	public class GithubUserWebService : IGithubUserService
	{
		public async Task<GithubUser> GetGithubUser (string username)
		{
			try
			{
				var githubUserFromService = await DownloadByteArrayAsync("https://osrc.dfm.io/andmos.json");
				return await Task.Factory.StartNew(() =>ParseJSONToGithubUser(DecodeByteArrayToString(githubUserFromService)));
			}
			catch (Exception e) 
			{
				throw(e); 
			}
		}

		private async Task<byte[]> DownloadByteArrayAsync(string url)
		{
			using (var response = await DownloadAsync(url))
			{
				return await response.Content.ReadAsByteArrayAsync (); 
			}
		}

		private static async Task<HttpResponseMessage> DownloadAsync(string url)
		{
			using (var client = new HttpClient(new NativeMessageHandler()))
			{
				return await client.GetAsync (url); 
			}
		}

		private static string DecodeByteArrayToString (byte[] githubUserByteArray)
		{
			return Encoding.GetEncoding ("utf-8").GetString (githubUserByteArray, 0, githubUserByteArray.Length);

		}
		private static GithubUser ParseJSONToGithubUser(string response)
		{
			return JsonConvert.DeserializeObject<GithubUser> (response); 
		}
	}
}

