using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;

namespace GithubUserSearcher
{
	public class GithubUserPageViewModel : ObservableBase
	{
		private GithubUser m_githubUser; 
		private string m_name;
		private string m_avatar; 
		private ObservableCollection<ConnectedUser> m_connectedUsers;
		private ObservableCollection<Repository> m_repository; 

		async public static Task<GithubUserPageViewModel> InitializeViewModelAsync(string userName)
		{
			var m_dataLoader = new DataLoader (Container.Singleton<IDataStorage> (), Container.Singleton<IGithubUserService>());
			var user = await m_dataLoader.GetGithubUser (userName);
			return new GithubUserPageViewModel (user);
		}

		private GithubUserPageViewModel (GithubUser user)
		{
			m_githubUser = user;
			Name = m_githubUser.Name;
			Avatar = m_githubUser.avatar;
			m_connectedUsers = new ObservableCollection<ConnectedUser> (m_githubUser.connected_users);
			m_repository = new ObservableCollection<Repository> (m_githubUser.repositories);
		}

		public string Name
		{
			get { return m_name; }
			set { this.SetPropertyValue (ref m_name, value); NotifyPropertyChanged ("Name"); }
		}

		public string Avatar
		{
			get { return m_avatar; }
			set { this.SetPropertyValue(ref m_avatar, value); NotifyPropertyChanged ("Avatar"); }
		}

	}
}

