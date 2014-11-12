using System;
using Hjerpbakk.FermiContainer;

namespace GithubUserSearcher
{
	public static class Container
	{
		public static IFermiContainer Instance { private get; set; }
		public static TInterface Resolve<TInterface>() where TInterface : class
		{
			return Instance.Resolve<TInterface>();
		}
		public static TInterface Singleton<TInterface>() where TInterface : class
		{
			return Instance.Singleton<TInterface>();
		}
	}
}

