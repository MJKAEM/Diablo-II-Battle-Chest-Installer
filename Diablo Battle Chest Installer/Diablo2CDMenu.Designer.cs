namespace Diablo_Battle_Chest_Installer {
	partial class Diablo2CDMenu {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.MainMenuButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.MountButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.PatchButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.SuspendLayout();
			// 
			// MainMenuButton
			// 
			this.MainMenuButton.Location = new System.Drawing.Point(145, 222);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(96, 53);
			this.MainMenuButton.TabIndex = 2;
			this.MainMenuButton.Text = "Return to the Previous Menu";
			this.MainMenuButton.UseVisualStyleBackColor = true;
			this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
			// 
			// MountButton
			// 
			this.MountButton.Location = new System.Drawing.Point(409, 222);
			this.MountButton.Name = "MountButton";
			this.MountButton.Size = new System.Drawing.Size(75, 53);
			this.MountButton.TabIndex = 3;
			this.MountButton.Text = "Mount CD";
			this.MountButton.UseVisualStyleBackColor = true;
			this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
			// 
			// PatchButton
			// 
			this.PatchButton.Enabled = false;
			this.PatchButton.Location = new System.Drawing.Point(409, 281);
			this.PatchButton.Name = "PatchButton";
			this.PatchButton.Size = new System.Drawing.Size(75, 53);
			this.PatchButton.TabIndex = 4;
			this.PatchButton.Text = "Patches";
			this.PatchButton.UseVisualStyleBackColor = true;
			this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
			// 
			// Diablo2CDMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo_2_cover;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.PatchButton);
			this.Controls.Add(this.MountButton);
			this.Controls.Add(this.MainMenuButton);
			this.Name = "Diablo2CDMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);

		}

		#endregion

		private InstallerButton MainMenuButton;
		private InstallerButton MountButton;
		private InstallerButton PatchButton;
	}
}
