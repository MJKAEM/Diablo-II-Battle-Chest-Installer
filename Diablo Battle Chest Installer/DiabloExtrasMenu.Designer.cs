namespace Diablo_Battle_Chest_Installer {
	partial class DiabloExtrasMenu {
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
			this.ExtrasComboBox = new System.Windows.Forms.ComboBox();
			this.MainMenuButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.PatchButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.SuspendLayout();
			// 
			// ExtrasComboBox
			// 
			this.ExtrasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExtrasComboBox.FormattingEnabled = true;
			this.ExtrasComboBox.Items.AddRange(new object[] {
            "Animation Fix v1.1",
            "DiabloPatch 2.0.1",
            "DDraw.dll Fix",
            "DDraw Color Reg Fix",
            "IPX to UDP Wrapper 0.6.0"});
			this.ExtrasComboBox.Location = new System.Drawing.Point(257, 323);
			this.ExtrasComboBox.Name = "ExtrasComboBox";
			this.ExtrasComboBox.Size = new System.Drawing.Size(138, 21);
			this.ExtrasComboBox.TabIndex = 2;
			// 
			// MainMenuButton
			// 
			this.MainMenuButton.Location = new System.Drawing.Point(155, 323);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(96, 53);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Return to the Previous Menu";
			this.MainMenuButton.UseVisualStyleBackColor = true;
			this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
			// 
			// PatchButton
			// 
			this.PatchButton.Location = new System.Drawing.Point(401, 323);
			this.PatchButton.Name = "PatchButton";
			this.PatchButton.Size = new System.Drawing.Size(75, 53);
			this.PatchButton.TabIndex = 0;
			this.PatchButton.Text = "Install";
			this.PatchButton.UseVisualStyleBackColor = true;
			this.PatchButton.Click += new System.EventHandler(this.InstallButton_Click);
			// 
			// DiabloExtrasMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo_1_box;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.ExtrasComboBox);
			this.Controls.Add(this.MainMenuButton);
			this.Controls.Add(this.PatchButton);
			this.Name = "DiabloExtrasMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);

		}

		#endregion
		private InstallerButton MainMenuButton;
		private InstallerButton PatchButton;
		private System.Windows.Forms.ComboBox ExtrasComboBox;
	}
}
