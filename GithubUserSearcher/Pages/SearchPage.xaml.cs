using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GithubUserSearcher
{	
	public partial class SearchPage : ContentPage
	{	
		private SearchPageViewModel m_searchPageViewModel;  

		public SearchPage ()
		{
			m_searchPageViewModel = new SearchPageViewModel();
			InitializeComponent ();
			BindingContext = m_searchPageViewModel; 
		}
	}
}

