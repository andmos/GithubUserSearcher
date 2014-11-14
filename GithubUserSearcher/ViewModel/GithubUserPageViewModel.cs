using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GithubUserSearcher
{
	public class GithubUserPageViewModel : ObservableBase

	{
		GithubUser m_githubUser; 
		string m_name;
		string m_avatar; 
		ObservableCollection<string> m_observable; 

		public GithubUserPageViewModel (GithubUser githubUser)
		{
			m_githubUser = githubUser; 
			m_name = githubUser.name;
		}

		public string Name
		{
			get { return m_name; }
			set { this.SetPropertyValue(ref m_name, value); }
		}

		public string Avatar
		{
			get { return m_avatar; }
			set { this.SetPropertyValue(ref m_avatar, value); }
		}

	}
}

