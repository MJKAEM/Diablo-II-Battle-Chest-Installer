namespace Diablo_Battle_Chest_Installer {
	#region Using Statements
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Drawing;
	using System.Data;
	using System.Text;
	using System.Windows.Forms;
	using System.Diagnostics;
	using System.Security.Permissions;
	using System.Threading;
	using Microsoft.Win32;
	#endregion Using Statements
	public partial class DiabloCDMenu : UserControl, CDMenu {
		private InstallerWindow installerWindow;

		public DiabloCDMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;
			this.EnableInstallRequiredMenuButton();
		}

		public void EnableInstallRequiredMenuButton() {
			this.PatchButton.Enabled = this.ExtrasButton.Enabled = Global.Diablo.IsGameInstalled();
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			if (MainMenuButton.Text.StartsWith("Unmount")) {
				Console.WriteLine("Unmounting {0}...", Global.Diablo.GAME_NAME);
				CDMounter.UnmountImage(Global.Diablo.CD_PATH);
				MainMenuButton.Text = InstallerWindow.MAIN_MENU_BUTTON_TEXT;
			}
			this.installerWindow.changeState(MenuStates.MainMenu);
		}

		private void MountButton_Click(object sender, EventArgs e) {
			Console.WriteLine("Now mounting {0}...", Global.Diablo.GAME_NAME);
			CDMounter.InstallService();
			CDMounter.MountImage(Global.Diablo.CD_PATH);
			MainMenuButton.Text = "Unmount and " + InstallerWindow.MAIN_MENU_BUTTON_TEXT;
		}

		private void PatchButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.DiabloPatch);
		}

		private void ExtrasButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.DiabloExtras);
		}
	}
}
