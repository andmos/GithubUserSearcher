using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using ModernHttpClient;

namespace GithubUserSearcher
{
	public class GithubUserWebService
	{
		public async Task<IEnumerable<GithubUser>> GetGithubUser (string username)
		{
			try
			{
				var githubUserFromService = await DownloadByteArrayAsync("https://osrc.dfm.io/" + username);
				return await Task.Factory.StartNew(() =>ParseJSONToGithubUser(DecodeByteArrayToString(githubUserFromService)));
			}
			catch (Exception e) 
			{
				throw(e); 
			}
		}

		private static async Task<byte[]> DownloadByteArrayAsync(string url)
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

		private static string DecodeByteArrayToString (byte[] liquorStoreProductByteArray)
		{
			return Encoding.GetEncoding ("iso-8859-1").GetString (liquorStoreProductByteArray, 0, liquorStoreProductByteArray.Length);

		}
		private static IEnumerable<GithubUser> ParseJSONToGithubUser(string response)
		{
			return JsonConvert.DeserializeObject<IEnumerable<GithubUser>> (response); 
		}
	}
}

