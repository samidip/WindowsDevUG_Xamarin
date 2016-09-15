using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WindowsDevUG
{
	public partial class SpeakerPage : ContentPage
	{
		public SpeakerPage()
		{
			InitializeComponent();

			MeetupViewModel.GetSpeakerDetails();
		}
	}
}

