using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Diablo_Battle_Chest_Installer {
	public class CDMounter {
		public static void InstallService() {
			Console.WriteLine("Installing PortableWinCDEmu service...");

			var installProcess = new Process();
			installProcess.StartInfo.FileName = "PortableWinCDEmu-4.0.exe";
			installProcess.StartInfo.Arguments = "/install";
			installProcess.StartInfo.UseShellExecute = false;
			installProcess.StartInfo.RedirectStandardOutput = true;
			installProcess.Start();

			installProcess.WaitForExit();
		}

		public static void MountImage(string path) {
			var mountProcess = new Process();
			mountProcess.StartInfo.FileName = "PortableWinCDEmu-4.0.exe";
			mountProcess.StartInfo.Arguments = string.Format("/mount \"{0}\"", path);
			mountProcess.StartInfo.UseShellExecute = false;
			mountProcess.StartInfo.RedirectStandardOutput = true;
			mountProcess.Start();

			mountProcess.WaitForExit();
		}

		public static void UnmountImage(string path) {
			var unmountProcess = new Process();
			unmountProcess.StartInfo.FileName = "PortableWinCDEmu-4.0.exe";
			unmountProcess.StartInfo.Arguments = string.Format("/unmount \"{0}\"", path); ;
			unmountProcess.StartInfo.UseShellExecute = false;
			unmountProcess.StartInfo.RedirectStandardOutput = true;
			unmountProcess.Start();

			unmountProcess.WaitForExit();
		}
	}
}
