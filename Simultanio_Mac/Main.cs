using AppKit;

namespace SimultanioMac
{
	static class MainClass
	{
		internal static string hej = "Simultanio.MyClass.GetPage()";

		static void Main (string[] args)
		{
			hej = Simultanio.MyClass.GetPage();
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}
