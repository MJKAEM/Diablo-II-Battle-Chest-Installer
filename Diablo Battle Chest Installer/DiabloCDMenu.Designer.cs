namespace Diablo_Battle_Chest_Installer {
	partial class DiabloCDMenu {
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
			this.PatchButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.MountButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.MainMenuButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.ExtrasButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.SuspendLayout();
			// 
			// PatchButton
			// 
			this.PatchButton.Enabled = false;
			this.PatchButton.Location = new System.Drawing.Point(376, 382);
			this.PatchButton.Name = "PatchButton";
			this.PatchButton.Size = new System.Drawing.Size(75, 53);
			this.PatchButton.TabIndex = 1;
			this.PatchButton.Text = "Patches";
			this.PatchButton.UseVisualStyleBackColor = true;
			this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
			// 
			// MountButton
			// 
			this.MountButton.Location = new System.Drawing.Point(376, 323);
			this.MountButton.Name = "MountButton";
			this.MountButton.Size = new System.Drawing.Size(75, 53);
			this.MountButton.TabIndex = 1;
			this.MountButton.Text = "Mount CD";
			this.MountButton.UseVisualStyleBackColor = true;
			this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
			// 
			// MainMenuButton
			// 
			this.MainMenuButton.Location = new System.Drawing.Point(155, 323);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(96, 53);
			this.MainMenuButton.TabIndex = 0;
			this.MainMenuButton.Text = "Return to the Main Menu";
			this.MainMenuButton.UseVisualStyleBackColor = true;
			this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
			// 
			// ExtrasButton
			// 
			this.ExtrasButton.Enabled = false;
			this.ExtrasButton.Location = new System.Drawing.Point(186, 382);
			this.ExtrasButton.Name = "ExtrasButton";
			this.ExtrasButton.Size = new System.Drawing.Size(65, 53);
			this.ExtrasButton.TabIndex = 1;
			this.ExtrasButton.Text = "Extras";
			this.ExtrasButton.UseVisualStyleBackColor = true;
			this.ExtrasButton.Click += new System.EventHandler(this.ExtrasButton_Click);
			// 
			// DiabloCDMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo_1_box;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.ExtrasButton);
			this.Controls.Add(this.PatchButton);
			this.Controls.Add(this.MountButton);
			this.Controls.Add(this.MainMenuButton);
			this.Name = "DiabloCDMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);

		}

		#endregion

		private InstallerButton MountButton;
		private InstallerButton MainMenuButton;
		private InstallerButton PatchButton;
		private InstallerButton ExtrasButton;
	}
}
