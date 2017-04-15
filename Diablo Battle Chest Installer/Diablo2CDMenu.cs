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
	#endregion Using Statements
	public partial class Diablo2CDMenu : UserControl, CDMenu {
		public const string GAME_NAME = "Diablo II";
		public const string MAIN_PATH = "Diablo2";
		public const string CD_PATH = MAIN_PATH + "/Diablo II Classic.iso";

		public static string[] installLocationRegKeys = {
			@"HKEY_LOCAL_MACHINE\SOFTWARE\Blizzard Entertainment\Diablo II",
			@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Blizzard Entertainment\Diablo II",
			@"HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II",
			@"HKEY_CURRENT_USER\Software\Classes\VirtualStore\MACHINE\SOFTWARE\Blizzard Entertainment\Diablo II"
		};

		private InstallerWindow installerWindow;
		public Diablo2CDMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;
		}

		public static bool IsDiablo2Installed() {
			foreach (string location in installLocationRegKeys) {
				object value = Registry.GetValue(location, "InstallPath", null);
				if (value != null) {
					Console.WriteLine("{0} found at: \"{1}\"", GAME_NAME, value.ToString());
					return true;
				}
			}

			return false;
		}

		public void EnableInstallRequiredMenuButton() {
			PatchButton.Enabled = true;
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.MainMenu);
			CDMounter.UnmountImage(Diablo2CDMenu.CD_PATH);
			MainMenuButton.Text = InstallerWindow.MAIN_MENU_BUTTON_TEXT;
		}

		private void MountButton_Click(object sender, EventArgs e) {
			CDMounter.MountImage(Diablo2CDMenu.CD_PATH);
			MainMenuButton.Text = "Unmount and " + InstallerWindow.MAIN_MENU_BUTTON_TEXT;
		}

		private void PatchButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.Diablo2Patch);
		}
	}
}
