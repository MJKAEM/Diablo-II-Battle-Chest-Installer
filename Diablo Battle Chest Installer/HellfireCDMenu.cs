namespace Diablo_Battle_Chest_Installer {
	#region Using Statements
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Drawing;
	using System.Data;
	using System.Text;
	using System.Windows.Forms;
	using Microsoft.Win32;
	using System.Diagnostics;
	using System.IO;
	#endregion Using Statements
	public partial class HellfireCDMenu : UserControl, CDMenu {
		public const string GAME_NAME = "Hellfire";
		public const string HELLFIRE_MAIN_PATH = "Hellfire";
		public const string HELLFIRE_CD_PATH = HELLFIRE_MAIN_PATH + "/Hellfire.bin";

		public const string PATCH_PATH = HELLFIRE_MAIN_PATH + @"\Patches\1.01";

		public static string[] installLocationRegKeys = {
			@"HKEY_LOCAL_MACHINE\SOFTWARE\Sierra OnLine\Setup\HELLFIRE",
			@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Sierra OnLine\Setup\HELLFIRE",
			@"HKEY_CURRENT_USER\Software\Sierra OnLine\Setup\HELLFIRE",
			@"HKEY_CURRENT_USER\Software\Classes\VirtualStore\MACHINE\SOFTWARE\Sierra OnLine\Setup\HELLFIRE"
		};

		public static string installPath = null;

		private InstallerWindow installerWindow;

		public HellfireCDMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;
		}

		public static bool IsHellfireInstalled() {
			return (GetHellfireInstallPath() != null);
		}

		public static string GetHellfireInstallPath() {
			foreach (string location in installLocationRegKeys) {
				object value = Registry.GetValue(location, "Directory", null);
				if (value != null) {
					Console.WriteLine("{0} found at: \"{1}\"", GAME_NAME, value.ToString());
					return value.ToString();
				}
			}

			return null;
		}

		public void EnableInstallRequiredMenuButton() {
			this.PatchButton.Enabled = HellfireCDMenu.IsHellfireInstalled();
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			if (MainMenuButton.Text.StartsWith("Unmount")) {
				Console.WriteLine("Unmounting {0}...", GAME_NAME);
				CDMounter.UnmountImage(HELLFIRE_CD_PATH);
				MainMenuButton.Text = InstallerWindow.MAIN_MENU_BUTTON_TEXT;
			}
			this.installerWindow.changeState(MenuStates.MainMenu);
		}

		private void MountButton_Click(object sender, EventArgs e) {
			Console.WriteLine("Now mounting {0}...", GAME_NAME);
			CDMounter.InstallService();
			CDMounter.MountImage(HELLFIRE_CD_PATH);
			MainMenuButton.Text = "Unmount and " + InstallerWindow.MAIN_MENU_BUTTON_TEXT;
		}

		private void PatchButton_Click(object sender, EventArgs e) {
			Console.WriteLine("Patching Hellfire to version 1.01");
			var installPath = HellfireCDMenu.GetHellfireInstallPath();
			var patchFiles = new DirectoryInfo(PATCH_PATH);

			Console.WriteLine(installPath);
			Debug.Assert(installPath != null, "Patch button should be disabled if Hellfire is not installed!");
			foreach (var file in patchFiles.GetFiles()) {
				var finalPath = Path.Combine(installPath, file.Name);
				file.CopyTo(finalPath, true);
			}
		}
	}
}
