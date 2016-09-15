using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WindowsDevUG
{
	public partial class HomeView : ContentPage
	{
		public HomeView()
		{
			InitializeComponent();

			this.FetchViewData();
		}

		private async void FetchViewData()
		{
			HomeViewModel HVM = new HomeViewModel();
			await HVM.GetAllMeetups();
			this.MeetupsList.ItemsSource = HVM.MeetupsCollection;
		}

		async void Meetup_Selected(object sender, Telerik.XamarinForms.DataControls.ListView.ItemTapEventArgs e)
		{
			Meetup selectedMeetup = (Meetup)e.Item;

			await Navigation.PushAsync(new MeetupView(selectedMeetup));
		}
	}
}

