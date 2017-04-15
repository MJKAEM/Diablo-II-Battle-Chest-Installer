namespace Diablo_Battle_Chest_Installer {
	partial class Diablo2PatchMenu {
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
			this.PatchButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.PatchComboBox = new System.Windows.Forms.ComboBox();
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
			// PatchButton
			// 
			this.PatchButton.Location = new System.Drawing.Point(409, 222);
			this.PatchButton.Name = "PatchButton";
			this.PatchButton.Size = new System.Drawing.Size(75, 53);
			this.PatchButton.TabIndex = 3;
			this.PatchButton.Text = "Patch Game";
			this.PatchButton.UseVisualStyleBackColor = true;
			this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
			// 
			// PatchComboBox
			// 
			this.PatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PatchComboBox.FormattingEnabled = true;
			this.PatchComboBox.IntegralHeight = false;
			this.PatchComboBox.Items.AddRange(new object[] {
            "Patch 1.01",
            "Patch 1.03",
            "Patch 1.04b",
            "Patch 1.04c",
            "Patch 1.05",
            "Patch 1.05b",
            "Patch 1.06",
            "Patch 1.06b",
            "Patch 1.08",
            "Patch 1.09",
            "Patch 1.09b",
            "Patch 1.09d",
            "Patch 1.10",
            "Patch 1.11",
            "Patch 1.11b",
            "Patch 1.12a",
            "Patch 1.13c",
            "Patch 1.13d",
            "Patch 1.14a",
            "Patch 1.14b",
            "Patch 1.14c",
            "Patch 1.14d"});
			this.PatchComboBox.Location = new System.Drawing.Point(263, 222);
			this.PatchComboBox.Name = "PatchComboBox";
			this.PatchComboBox.Size = new System.Drawing.Size(122, 21);
			this.PatchComboBox.TabIndex = 6;
			// 
			// Diablo2PatchMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo_2_cover;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.PatchComboBox);
			this.Controls.Add(this.PatchButton);
			this.Controls.Add(this.MainMenuButton);
			this.Name = "Diablo2PatchMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);

		}

		#endregion

		private InstallerButton MainMenuButton;
		private InstallerButton PatchButton;
		private System.Windows.Forms.ComboBox PatchComboBox;
	}
}
