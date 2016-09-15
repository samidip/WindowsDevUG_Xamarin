using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WindowsDevUG
{
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage()
		{
			InitializeComponent();

			Meetup SelectedMeetup = MeetupViewModel.GetMeetupDetails();

			this.TopicLabel.Text = SelectedMeetup.Topic;
			this.AbstractLabel.Text = SelectedMeetup.TalkAbstract;
			this.SpecialsLabel.Text = SelectedMeetup.Specials;
		}
	}
}

