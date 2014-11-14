using System;
using Xamarin.Forms;

namespace GithubUserSearcher
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new GithubUserPage (); 
		}
	}
}

