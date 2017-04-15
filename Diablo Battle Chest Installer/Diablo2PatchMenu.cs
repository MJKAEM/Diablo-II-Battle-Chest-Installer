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
	using System.IO;
	using System.Diagnostics;
	#endregion Using Statements
	public partial class Diablo2PatchMenu : UserControl {
		public const string GAME_NAME = "Diablo II";
		public const string MAIN_PATH = "Diablo2";
		public const string PATCH_PATH = MAIN_PATH + @"\Patches\";

		private IDictionary<string, FileInfo> versionToPatchDictionary;

		private InstallerWindow installerWindow;
		public Diablo2PatchMenu(InstallerWindow installerWindow) {
			InitializeComponent();
			this.installerWindow = installerWindow;

			versionToPatchDictionary = new Dictionary<string, FileInfo>();
			this.versionToPatchDictionary.Add("Patch 1.01", new FileInfo(PATCH_PATH + "D2Patch_101.exe"));
			this.versionToPatchDictionary.Add("Patch 1.03", new FileInfo(PATCH_PATH + "D2Patch_103.exe"));
			this.versionToPatchDictionary.Add("Patch 1.04b", new FileInfo(PATCH_PATH + "D2Patch_104b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.04c", new FileInfo(PATCH_PATH + "D2Patch104c.exe"));
			this.versionToPatchDictionary.Add("Patch 1.05", new FileInfo(PATCH_PATH + "D2Patch_105.exe"));
			this.versionToPatchDictionary.Add("Patch 1.05b", new FileInfo(PATCH_PATH + "D2Patch_105b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.06", new FileInfo(PATCH_PATH + "D2Patch_106.exe"));
			this.versionToPatchDictionary.Add("Patch 1.06b", new FileInfo(PATCH_PATH + "D2Patch_106b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.08", new FileInfo(PATCH_PATH + "D2Patch_108.exe"));
			this.versionToPatchDictionary.Add("Patch 1.09", new FileInfo(PATCH_PATH + "D2Patch_109.exe"));
			this.versionToPatchDictionary.Add("Patch 1.09b", new FileInfo(PATCH_PATH + "D2Patch_109b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.10", new FileInfo(PATCH_PATH + "D2Patch_110.exe"));
			this.versionToPatchDictionary.Add("Patch 1.11", new FileInfo(PATCH_PATH + "D2Patch_111.exe"));
			this.versionToPatchDictionary.Add("Patch 1.11b", new FileInfo(PATCH_PATH + "D2Patch_111b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.12a", new FileInfo(PATCH_PATH + "D2Patch_112a.exe"));
			this.versionToPatchDictionary.Add("Patch 1.13c", new FileInfo(PATCH_PATH + "D2Patch_113c.exe"));
			this.versionToPatchDictionary.Add("Patch 1.13d", new FileInfo(PATCH_PATH + "D2Patch_113d.exe"));
			this.versionToPatchDictionary.Add("Patch 1.14a", new FileInfo(PATCH_PATH + "D2Patch_114a.exe"));
			this.versionToPatchDictionary.Add("Patch 1.14b", new FileInfo(PATCH_PATH + "D2Patch_114b.exe"));
			this.versionToPatchDictionary.Add("Patch 1.14c", new FileInfo(PATCH_PATH + "D2Patch_114c.exe"));
			this.versionToPatchDictionary.Add("Patch 1.14d", new FileInfo(PATCH_PATH + "D2Patch_114d.exe"));
		}

		private void MainMenuButton_Click(object sender, EventArgs e) {
			this.installerWindow.changeState(MenuStates.Diablo2CD);
		}

		private void PatchButton_Click(object sender, EventArgs e) {
			var versionName = PatchComboBox.Text;
			if (string.IsNullOrEmpty(versionName)) {
				return;
			}

			FileInfo patchPath = null;
			if (!this.versionToPatchDictionary.TryGetValue(versionName, out patchPath)) {
				throw new ArgumentException("Patch number not recognized or found.");
			}
			Console.WriteLine("Patching game to {0}...", versionName);
			Process.Start(patchPath.FullName);
		}
	}
}
