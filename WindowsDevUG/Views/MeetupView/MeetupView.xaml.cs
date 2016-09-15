using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WindowsDevUG
{
	public partial class MeetupView : TabbedPage
	{
		public MeetupView()
		{
			InitializeComponent();
		}

		public MeetupView(Meetup SelectedMeetup)
		{
			MeetupViewModel.SetMeetupViewModel(SelectedMeetup);

			InitializeComponent();
		}
	}
}

