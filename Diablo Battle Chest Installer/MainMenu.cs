namespace Diablo_Battle_Chest_Installer {
	#region Using Statements
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Drawing;
	using System.Data;
	using System.Text;
	using System.Windows.Forms;
	using System.IO;
	using System.Media;
	using Microsoft.Win32;
	#endregion Using Statements

	public partial class MainMenu : UserControl {
		private InstallerWindow installerWindow;
		public MainMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;
			this.EnableDiablo2ExpMenuButton();
			this.EnableHellfireMenuButton();
		}

		public void EnableHellfireMenuButton() {
			HellfireCDButton.Enabled = Global.Diablo.IsGameInstalled();
		}

		public void EnableDiablo2ExpMenuButton() {
			Diablo2ExpCDButton.Enabled = Diablo2CDMenu.IsDiablo2Installed();
		}

		private void DiabloCDButton_Click(object sender, EventArgs e) {
			installerWindow.changeState(MenuStates.DiabloCD);
		}

		private void HellfireCDButton_Click(object sender, EventArgs e) {
			installerWindow.changeState(MenuStates.HellfireCD);
		}

		private void Diablo2CDButton_Click(object sender, EventArgs e) {
			installerWindow.changeState(MenuStates.Diablo2CD);
		}

		private void Diablo2ExpCDButton_Click(object sender, EventArgs e) {
			installerWindow.changeState(MenuStates.Diablo2ExpCD);
		}
	}
}
