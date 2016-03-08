﻿using Xamarin.Forms;

namespace EffectsDemo
{
	public class HomePageCS : ContentPage
	{
		public HomePageCS ()
		{
			var entry = new Entry {
				Text = "Effect attached to an Entry",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				WidthRequest = Device.OnPlatform<double> (220, 220, 250)
			};
			entry.Effects.Add (Effect.Resolve ("MyCompany.FocusEffect"));

			Content = new StackLayout { 
				Padding = new Thickness (0, 20, 0, 0),
				Children = {
					new Label {
						Text = "Effects Demo - Focus Effect",
						FontAttributes = FontAttributes.Bold,
						HorizontalOptions = LayoutOptions.Center
					},
					entry
				}
			};
		}
	}
}