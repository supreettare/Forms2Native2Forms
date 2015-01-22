using System;
using Xamarin.Forms;

namespace Native2Forms
{
	/// <summary>
	/// This Xamarin.Forms page will be opened from within a 'native' app on iOS and Android
	/// </summary>
	public class MySecondPage : ContentPage
    {
        public string Heading; 
		public MySecondPage ()
		{
            //Rendered natively in IOS
            Heading = "This is the second Xamarin.Forms page";
		}
	}
}
