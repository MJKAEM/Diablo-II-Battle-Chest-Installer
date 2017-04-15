namespace Diablo_Battle_Chest_Installer {
	#region Using Statements
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Media;
	using System.Text;
	#endregion Using Statements

	class InstallerButton : System.Windows.Forms.Button {
		protected override void OnMouseEnter(EventArgs e) {
			base.OnMouseEnter(e);
			playMouseOverSound();
		}

		protected override void OnClick(EventArgs e) {
			base.OnClick(e);
			playMenuClickSound();
		}

		private void playMenuClickSound() {
			var s = Properties.Resources.Menu_Click;
			var player = new SoundPlayer(s);
			player.Play();
		}

		private void playMouseOverSound() {
			var s = Properties.Resources.Mouse_Over;
			var player = new SoundPlayer(s);
			player.Play();
		}
	}
}
