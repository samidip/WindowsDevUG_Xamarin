using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Telerik.Everlive.Sdk.Core;

namespace WindowsDevUG
{
	public class HomeViewModel
	{
		private string BSAppId = "hwujvrbviyl5c7vb";
		private EverliveApp ELHandle;

		public ObservableCollection<Meetup> MeetupsCollection { get; set; }

		public HomeViewModel()
		{
			EverliveAppSettings appSettings = new EverliveAppSettings() { AppId = BSAppId, UseHttps = true };
			ELHandle = new EverliveApp(appSettings);
		}

		public async Task<ObservableCollection<Meetup>> GetAllMeetups()
		{
			var meetupsManager = ELHandle.WorkWith().Data<Meetup>();
			var allMeetups = await meetupsManager.GetAll().ExecuteAsync();

			MeetupsCollection = new ObservableCollection<Meetup>();
			foreach (Meetup serializedMeetup in allMeetups)
			{
				MeetupsCollection.Add(serializedMeetup);
			}

			return MeetupsCollection;
		}
	}
}

