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
	using System.IO;
	#endregion Using Statements

	public partial class DiabloExtrasMenu : UserControl {
		private InstallerWindow installerWindow;
		public DiabloExtrasMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.DiabloCD);
		}

		private void InstallButton_Click(object sender, EventArgs e) {
			if (!string.IsNullOrEmpty(ExtrasComboBox.Text)) {
				Global.Diablo.InstallExtra(ExtrasComboBox.Text);
			}
		}
	}
}
