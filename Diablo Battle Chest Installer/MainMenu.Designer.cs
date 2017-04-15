namespace Diablo_Battle_Chest_Installer {
	partial class MainMenu {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.DiabloCDButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.HellfireCDButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.Diablo2ExpCDButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.Diablo2CDButton = new Diablo_Battle_Chest_Installer.InstallerButton();
			this.SuspendLayout();
			// 
			// DiabloCDButton
			// 
			this.DiabloCDButton.AutoSize = true;
			this.DiabloCDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DiabloCDButton.Image = global::Diablo_Battle_Chest_Installer.Properties.Resources.Diablo;
			this.DiabloCDButton.Location = new System.Drawing.Point(12, 285);
			this.DiabloCDButton.Name = "DiabloCDButton";
			this.DiabloCDButton.Size = new System.Drawing.Size(110, 38);
			this.DiabloCDButton.TabIndex = 1;
			this.DiabloCDButton.Text = "Diablo Setup";
			this.DiabloCDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DiabloCDButton.UseVisualStyleBackColor = true;
			this.DiabloCDButton.Click += new System.EventHandler(this.DiabloCDButton_Click);
			// 
			// HellfireCDButton
			// 
			this.HellfireCDButton.AutoSize = true;
			this.HellfireCDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HellfireCDButton.Image = ((System.Drawing.Image)(resources.GetObject("HellfireCDButton.Image")));
			this.HellfireCDButton.Location = new System.Drawing.Point(128, 285);
			this.HellfireCDButton.Name = "HellfireCDButton";
			this.HellfireCDButton.Size = new System.Drawing.Size(112, 38);
			this.HellfireCDButton.TabIndex = 2;
			this.HellfireCDButton.Text = "Hellfire Setup";
			this.HellfireCDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.HellfireCDButton.UseVisualStyleBackColor = true;
			this.HellfireCDButton.Click += new System.EventHandler(this.HellfireCDButton_Click);
			// 
			// Diablo2ExpCDButton
			// 
			this.Diablo2ExpCDButton.AutoSize = true;
			this.Diablo2ExpCDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Diablo2ExpCDButton.Enabled = false;
			this.Diablo2ExpCDButton.Image = ((System.Drawing.Image)(resources.GetObject("Diablo2ExpCDButton.Image")));
			this.Diablo2ExpCDButton.Location = new System.Drawing.Point(473, 285);
			this.Diablo2ExpCDButton.Name = "Diablo2ExpCDButton";
			this.Diablo2ExpCDButton.Size = new System.Drawing.Size(145, 38);
			this.Diablo2ExpCDButton.TabIndex = 3;
			this.Diablo2ExpCDButton.Text = "Diablo II: LoD Setup";
			this.Diablo2ExpCDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Diablo2ExpCDButton.UseVisualStyleBackColor = true;
			this.Diablo2ExpCDButton.Click += new System.EventHandler(this.Diablo2ExpCDButton_Click);
			// 
			// Diablo2CDButton
			// 
			this.Diablo2CDButton.AutoSize = true;
			this.Diablo2CDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Diablo2CDButton.Image = ((System.Drawing.Image)(resources.GetObject("Diablo2CDButton.Image")));
			this.Diablo2CDButton.Location = new System.Drawing.Point(348, 285);
			this.Diablo2CDButton.Name = "Diablo2CDButton";
			this.Diablo2CDButton.Size = new System.Drawing.Size(119, 38);
			this.Diablo2CDButton.TabIndex = 4;
			this.Diablo2CDButton.Text = "Diablo II Setup";
			this.Diablo2CDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Diablo2CDButton.UseVisualStyleBackColor = true;
			this.Diablo2CDButton.Click += new System.EventHandler(this.Diablo2CDButton_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::Diablo_Battle_Chest_Installer.Properties.Resources._71LIoQjjmGL__AC_SL1000_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.DiabloCDButton);
			this.Controls.Add(this.HellfireCDButton);
			this.Controls.Add(this.Diablo2ExpCDButton);
			this.Controls.Add(this.Diablo2CDButton);
			this.Name = "MainMenu";
			this.Size = new System.Drawing.Size(630, 440);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private InstallerButton DiabloCDButton;
		private InstallerButton HellfireCDButton;
		private InstallerButton Diablo2ExpCDButton;
		private InstallerButton Diablo2CDButton;
	}
}
