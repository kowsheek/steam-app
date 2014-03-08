using GalaSoft.MvvmLight.Messaging;

namespace SteamApp
{
	static class PageNavigation
	{
		public static void Navigate(string pageName)
		{
			var data = new PageNavigationData(pageName);
			Messenger.Default.Send(data);
		}
	}

	class PageNavigationData
	{
		public string PageName { get; set; }

		public PageNavigationData(string pageName)
		{
			PageName = pageName;
		}
	}
}
