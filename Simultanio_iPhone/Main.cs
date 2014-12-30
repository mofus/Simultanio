using System;

using UIKit;

namespace SimultanioIPhone
{
	public class Application
	{
		internal static string hej = "Simultanio.MyClass.GetPage()";

		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			//hej = Simultanio.MyClass.GetPage();
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
