using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace GithubUserSearcher
{	
	public partial class GithubUserPage : ContentPage
	{	
		private GithubUserPageViewModel m_viewModel;

		public GithubUserPage ()
		{
			InitializeComponent ();
			SetUpViewModel ();
			BindingContext = m_viewModel;

		}

		private async void SetUpViewModel()
		{
			m_viewModel = await GithubUserPageViewModel.InitializeViewModelAsync ("andmos");
		}

	}
}

