namespace Diablo_Battle_Chest_Installer {
	#region Using Statements
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.IO;
	using System.Media;
	using System.Reflection;
	using System.Text;
	using System.Windows.Forms;
	#endregion Using Statements

	public enum MenuStates {
		MainMenu,
		DiabloCD,
		DiabloPatch,
		DiabloExtras,
		HellfireCD,
		HellfireExtras,
		Diablo2CD,
		Diablo2Patch,
		Diablo2Extras,
		Diablo2ExpCD,
		Diablo2ExpPatch,
		Diablo2ExpExtras
	}

	public partial class InstallerWindow : Form {
		public const string MAIN_MENU_BUTTON_TEXT = "Return to the Main Menu";

		private IDictionary<MenuStates, UserControl> menuStateDictionary;

		public InstallerWindow() {
			InitializeComponent();

			this.menuStateDictionary = new Dictionary<MenuStates, UserControl>();
			this.menuStateDictionary.Add(MenuStates.MainMenu, new MainMenu(this));
			this.menuStateDictionary.Add(MenuStates.DiabloCD, new DiabloCDMenu(this));
			this.menuStateDictionary.Add(MenuStates.DiabloPatch, new DiabloPatchMenu(this));
			this.menuStateDictionary.Add(MenuStates.DiabloExtras, new DiabloExtrasMenu(this));
			this.menuStateDictionary.Add(MenuStates.HellfireCD, new HellfireCDMenu(this));
			this.menuStateDictionary.Add(MenuStates.Diablo2CD, new Diablo2CDMenu(this));
			this.menuStateDictionary.Add(MenuStates.Diablo2Patch, new Diablo2PatchMenu(this));
			this.menuStateDictionary.Add(MenuStates.Diablo2ExpCD, new Diablo2ExpCDMenu(this));

			changeState(MenuStates.MainMenu);
		}

		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

		public void changeState(MenuStates menuState) {
			this.Controls.Clear();
			UserControl nextState = null;
			if (!this.menuStateDictionary.TryGetValue(menuState, out nextState)) {
				throw new ArgumentException("Invaid state or not handled.");
			}

			this.Controls.Add(nextState);
		}

		private void InstallerWindow_Activated(object sender, EventArgs e) {
			(this.menuStateDictionary[MenuStates.MainMenu] as MainMenu).EnableDiablo2ExpMenuButton();
			(this.menuStateDictionary[MenuStates.MainMenu] as MainMenu).EnableHellfireMenuButton();

			foreach(var menu in this.menuStateDictionary.Values) {
				(menu as CDMenu)?.EnableInstallRequiredMenuButton();
			}
		}
	}
}
