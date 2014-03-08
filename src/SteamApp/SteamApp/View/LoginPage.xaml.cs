using GalaSoft.MvvmLight.Messaging;

namespace SteamApp.View
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();

			Messenger.Default.Register<PageNavigationData>(this, action => 
				NavigationService.Navigate(new System.Uri("/View/" + action.PageName + ".xaml",System.UriKind.Relative)));
		}
	}
}