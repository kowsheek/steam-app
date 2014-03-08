using System.IO.IsolatedStorage;
using GalaSoft.MvvmLight;
using PortableSteam;

namespace SteamApp.ViewModel
{
	public class DashboardViewModel : ViewModelBase
	{
		public DashboardViewModel()
		{
			//We'll need the key before doing anything
			//SteamWebAPI.SetGlobalKey("[key-here]");
		}

		private readonly SteamIdentity _steamIdentity = SteamWebAPI.General()
															.ISteamUser()
															.ResolveVanityURL((string)IsolatedStorageSettings.ApplicationSettings["username"])
															.GetResponse()
															.Data.Identity;

		/// <summary>
		/// The <see cref="SteamId" /> property's name.
		/// </summary>
		public const string SteamIdPropertyName = "SteamId";

		/// <summary>
		/// Sets and gets the SteamId property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public long SteamId
		{
			get { return _steamIdentity.SteamID; }
		}

		/// <summary>
		/// The <see cref="SteamUsername" /> property's name.
		/// </summary>
		public const string SteamUsernamePropertyName = "SteamUsername";

		/// <summary>
		/// Sets and gets the SteamUsername property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string SteamUsername
		{
			get
			{
				return (string)IsolatedStorageSettings.ApplicationSettings["username"];
			}
		}

		/// <summary>
		/// The <see cref="AccountId" /> property's name.
		/// </summary>
		public const string AccountIdPropertyName = "AccountId";

		/// <summary>
		/// Sets and gets the AccountId property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public long AccountId
		{
			get { return _steamIdentity.AccountID; }
		}
	}
}