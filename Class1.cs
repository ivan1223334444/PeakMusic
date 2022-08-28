using System.ComponentModel;
namespace LogInControl
{
	public class User : INotifyPropertyChanged
	{
		#region

		private string userName;
		public string UserName
		{
			get
			{
				return userName;
			}
			set
			{
				userName = value;
				OnPropertyChanged("UserName");
			}
		}

		private string password;
		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
				OnPropertyChanged("Password");
			}
		}

		private bool isAdmin;
		public bool IsAdmin
		{
			get
			{
				return isAdmin;
			}
			set
			{
				isAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}

		#endregion

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion

	}
}