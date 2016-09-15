using System;
using Telerik.Everlive.Sdk.Core;

using Telerik.Everlive.Sdk.Core.Model.Base;
using Telerik.Everlive.Sdk.Core.Serialization;

namespace WindowsDevUG
{
	[ServerType("Meetups")]
	public class Meetup : DataItem
	{
		private string month;
		public string Month
		{
			get
			{
				return this.month;
			}
			set
			{
				this.month = value;
				this.OnPropertyChanged("Month");
			}
		}

		private string topic;
		public string Topic
		{
			get
			{
				return this.topic;
			}
			set
			{
				this.topic = value;
				this.OnPropertyChanged("Topic");
			}
		}

		private string talkAbstract;
		[ServerProperty("Abstract")]
	    public string TalkAbstract
		{
			get
			{
				return this.talkAbstract;
	        }
			set
	        {
				this.talkAbstract = value;
				this.OnPropertyChanged("TalkAbstract");
			}
		}

		private string specials;
		public string Specials
		{
			get
			{
				return this.specials;
			}
			set
			{
				this.specials = value;
            this.OnPropertyChanged("Specials");
			}
		}

		private DateTime date;
		public DateTime Date
		{
			get
			{
				return this.date;
			}
			set
			{
				this.date = value;
				this.OnPropertyChanged("Date");
			}
		}

		private string imageurl;
		public string ImageURL
		{
			get
			{
				return this.imageurl;
			}
			set
			{
				this.imageurl = value;
				this.OnPropertyChanged("ImageURL");
			}
		}

		private Guid speakerid;
		public Guid SpeakerId
		{
			get
			{
				return this.speakerid;
			}
			set
			{
				this.speakerid = value;
				this.OnPropertyChanged("SpeakerId");
			}
		}
	}
}

