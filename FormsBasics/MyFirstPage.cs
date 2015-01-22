using System;
using Xamarin.Forms;

namespace Native2Forms
{
	/// <summary>
	/// This Xamarin.Forms page will be opened from within a 'native' app on iOS and Android
	/// </summary>
	public class MyFirstPage : ContentPage
	{
        public MyFirstPage()
		{
			var label = new Label {
				Text = "This is the first Xamarin.Forms page",
				Font = Font.SystemFontOfSize (36),
			};

            var button = new Button
            {
                Text = "Click to go to native page"
            };

            button.Clicked+=(s,e )=>
            {
                //Navigate to Second page 
                  Navigation.PushAsync(new MySecondPage());
            };

			Content = new StackLayout {
				Spacing = 30,
				VerticalOptions = LayoutOptions.Start,
				Children = {
					label, button
				}
			};
		}
	}
}
