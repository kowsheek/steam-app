using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace SteamApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

		/// <summary>
		/// The <see cref="Username" /> property's name.
		/// </summary>
		public const string UsernamePropertyName = "Username";

		private string _username;

		/// <summary>
		/// Sets and gets the Username property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string Username
		{
			get
			{
				return _username;
			}

			set
			{
				if (_username == value)
				{
					return;
				}

				RaisePropertyChanging(UsernamePropertyName);
				_username = value;
				RaisePropertyChanged(UsernamePropertyName);
			}
		}

		/// <summary>
		/// The <see cref="Password" /> property's name.
		/// </summary>
		public const string PasswordPropertyName = "Password";

	    private string _password;

		/// <summary>
		/// Sets and gets the Password property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string Password
		{
			get
			{
				return _password;
			}

			set
			{
				if (_password == value)
				{
					return;
				}

				RaisePropertyChanging(PasswordPropertyName);
				_password = value;
				RaisePropertyChanged(PasswordPropertyName);
			}
		}

		private RelayCommand _loginCommand;

		/// <summary>
		/// Gets the LoginCommand.
		/// </summary>
		public RelayCommand LoginCommand
		{
			get
			{
				return _loginCommand
					?? (_loginCommand = new RelayCommand(
										  () =>
										  {
											  MessageBox.Show("Username is " + _username);
											  MessageBox.Show("Password is " + _password);
										  }));
			}
		}
    }
}