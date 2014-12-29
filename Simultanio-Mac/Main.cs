using System;

using AppKit;

namespace SimultanioMac
{
	static class MainClass
	{
		static void Main (string[] args)
		{
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}
