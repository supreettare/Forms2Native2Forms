using System;
using Xamarin.Forms;

namespace Native2Forms
{
    public class App : Application
	{
		//
		// This page is displayed from within 'native' pages on iOS and Android
		//

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new MyFirstPage());
        }

		public static Page GetSecondPage ()
		{
			var formsPage = new NavigationPage (new MyThirdPage ()); 

			return formsPage;
		}
	}
}