using System;
using Xamarin.Forms;

namespace Native2Forms
{
	/// <summary>
	/// This Xamarin.Forms page will be opened from within a 'native' app on iOS and Android
	/// </summary>
	public class MyThirdPage : ContentPage
	{  
        public MyThirdPage()
		{
			var label = new Label {
				Text = "This is the Third Xamarin.Forms page",
				Font = Font.SystemFontOfSize (36),
			};

			Content = new StackLayout {
				Spacing = 30,
				VerticalOptions = LayoutOptions.Start,
				Children = {
					label,
				}
			};
		}
	}
}
