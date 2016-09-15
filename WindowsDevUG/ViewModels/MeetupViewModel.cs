using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Telerik.Everlive.Sdk.Core;

namespace WindowsDevUG
{
	public class MeetupViewModel
	{
		private static readonly MeetupViewModel SingletonMVM = new MeetupViewModel();
		private Meetup IndividualMeetup;

		private string BSAppId = "hwujvrbviyl5c7vb";
		private static EverliveApp ELHandle;

		private MeetupViewModel()
		{
			// No outside initialization.

			EverliveAppSettings appSettings = new EverliveAppSettings() { AppId = BSAppId, UseHttps = true };
			ELHandle = new EverliveApp(appSettings);
		}

		public static void SetMeetupViewModel(Meetup SelectedMeetup)
		{
			SingletonMVM.IndividualMeetup = SelectedMeetup;
		}

		public static Meetup GetMeetupDetails()
		{
			return SingletonMVM.IndividualMeetup;
		}

		public async static void GetSpeakerDetails()
		{
			Guid speakerID = SingletonMVM.IndividualMeetup.SpeakerId;

			var speakerManager = ELHandle.WorkWith().Data<Speaker>();
			var selectedSpeaker = await speakerManager.GetById(speakerID).ExecuteAsync();
		}
	}
}

