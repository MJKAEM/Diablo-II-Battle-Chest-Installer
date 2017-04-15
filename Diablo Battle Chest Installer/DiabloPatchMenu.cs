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
	#endregion Using Statements

	public partial class DiabloPatchMenu : UserControl {
		private InstallerWindow installerWindow;
		public DiabloPatchMenu(InstallerWindow installerWindow) : base() {
			InitializeComponent();
			this.installerWindow = installerWindow;
		}

		private void PatchButton_Click(object sender, EventArgs e) {
			Global.Diablo.InstallPatch(PatchComboBox.Text);
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.DiabloCD);
		}
	}
}
