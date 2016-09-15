using System;
using Telerik.Everlive.Sdk.Core;

using Telerik.Everlive.Sdk.Core.Model.Base;
using Telerik.Everlive.Sdk.Core.Serialization;

namespace WindowsDevUG
{
	[ServerType("Speakers")]
	public class Speaker : DataItem
	{
		private string name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.OnPropertyChanged("Name");
			}
		}

		private string bio;
		public string Bio
		{
			get
			{
				return this.bio;
			}
			set
			{
				this.bio = value;
				this.OnPropertyChanged("Bio");
			}
		}

		private string twitter;
		public string Twitter
		{
			get
			{
				return this.twitter;
			}
			set
			{
				this.twitter = value;
				this.OnPropertyChanged("Twitter");
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
	}
}

