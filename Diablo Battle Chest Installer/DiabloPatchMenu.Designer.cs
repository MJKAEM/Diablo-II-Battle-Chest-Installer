namespace Diablo_Battle_Chest_Installer {
	partial class DiabloPatchMenu {
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
			this.MainMenuButton.Location = new System.Drawing.Point(155, 323);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(96, 53);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Return to the Main Menu";
			this.MainMenuButton.UseVisualStyleBackColor = true;
			this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
			// 
			// PatchButton
			// 
			this.PatchButton.Location = new System.Drawing.Point(376, 323);
			this.PatchButton.Name = "PatchButton";
			this.PatchButton.Size = new System.Drawing.Size(75, 53);
			this.PatchButton.TabIndex = 0;
			this.PatchButton.Text = "Revert and Patch Game";
			this.PatchButton.UseVisualStyleBackColor = true;
			this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
			// 
			// PatchComboBox
			// 
			this.PatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PatchComboBox.FormattingEnabled = true;
			this.PatchComboBox.Items.AddRange(new object[] {
            "Patch 1.04",
            "Patch 1.07",
            "Patch 1.08",
            "Patch 1.09",
            "Patch 1.09b"});
			this.PatchComboBox.Location = new System.Drawing.Point(257, 323);
			this.PatchComboBox.Name = "PatchComboBox";
			this.PatchComboBox.Size = new System.Drawing.Size(113, 21);
			this.PatchComboBox.TabIndex = 2;
			// 
			// DiabloPatchMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo_1_box;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.PatchComboBox);
			this.Controls.Add(this.MainMenuButton);
			this.Controls.Add(this.PatchButton);
			this.Name = "DiabloPatchMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);

		}

		#endregion
		private InstallerButton MainMenuButton;
		private InstallerButton PatchButton;
		private System.Windows.Forms.ComboBox PatchComboBox;
	}
}
