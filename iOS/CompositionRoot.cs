using System;
using Hjerpbakk.FermiContainer;

namespace GithubUserSearcher.iOS
{
	public class CompositionRoot
	{
		public CompositionRoot ()
		{
			var container = Container.Instance = new FermiContainer (); 
			container.Register<IGithubUserService, FilebasedGithubUserService>(); 
			container.Register<IDataStorage, GithubUsersCache> (); 
		}
	}
}

