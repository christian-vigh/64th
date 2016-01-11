namespace SixtyForth. Forms
	{
	partial class MainForm
		{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose ( bool disposing )
			{
			if ( disposing && ( components != null ) )
				{
				components. Dispose ( );
				}
			base. Dispose ( disposing );
			}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent ( )
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDisplay = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDisplay64thConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDisplay64thShell = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSettingsLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSettingsLanguageEN_US = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSettingsLanguageFR_FR = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.DummyLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.LanguageLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MainMenu.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuDisplay,
            this.MenuSettings,
            this.MenuHelp});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(726, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "MainMenu";
			// 
			// MenuFile
			// 
			this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileQuit});
			this.MenuFile.Name = "MenuFile";
			this.MenuFile.Size = new System.Drawing.Size(58, 20);
			this.MenuFile.Text = "*** FILE";
			// 
			// MenuFileQuit
			// 
			this.MenuFileQuit.Name = "MenuFileQuit";
			this.MenuFileQuit.Size = new System.Drawing.Size(119, 22);
			this.MenuFileQuit.Text = "*** QUIT";
			this.MenuFileQuit.Click += new System.EventHandler(this.MenuFileQuit_Click);
			// 
			// MenuDisplay
			// 
			this.MenuDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDisplay64thConsole,
            this.MenuDisplay64thShell});
			this.MenuDisplay.Name = "MenuDisplay";
			this.MenuDisplay.Size = new System.Drawing.Size(82, 20);
			this.MenuDisplay.Text = "*** DISPLAY";
			// 
			// MenuDisplay64thConsole
			// 
			this.MenuDisplay64thConsole.Name = "MenuDisplay64thConsole";
			this.MenuDisplay64thConsole.Size = new System.Drawing.Size(183, 22);
			this.MenuDisplay64thConsole.Text = "*** FORTHCONSOLE";
			this.MenuDisplay64thConsole.Click += new System.EventHandler(this.MenuDisplay64thConsole_Click);
			// 
			// MenuDisplay64thShell
			// 
			this.MenuDisplay64thShell.Name = "MenuDisplay64thShell";
			this.MenuDisplay64thShell.Size = new System.Drawing.Size(183, 22);
			this.MenuDisplay64thShell.Text = "*** FORTHSHELL";
			this.MenuDisplay64thShell.Click += new System.EventHandler(this.MenuDisplay64thShell_Click);
			// 
			// MenuSettings
			// 
			this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsLanguage});
			this.MenuSettings.Name = "MenuSettings";
			this.MenuSettings.Size = new System.Drawing.Size(89, 20);
			this.MenuSettings.Text = "*** SETTINGS";
			// 
			// MenuSettingsLanguage
			// 
			this.MenuSettingsLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsLanguageEN_US,
            this.MenuSettingsLanguageFR_FR});
			this.MenuSettingsLanguage.Name = "MenuSettingsLanguage";
			this.MenuSettingsLanguage.Size = new System.Drawing.Size(153, 22);
			this.MenuSettingsLanguage.Text = "*** LANGUAGE";
			// 
			// MenuSettingsLanguageEN_US
			// 
			this.MenuSettingsLanguageEN_US.Image = ((System.Drawing.Image)(resources.GetObject("MenuSettingsLanguageEN_US.Image")));
			this.MenuSettingsLanguageEN_US.Name = "MenuSettingsLanguageEN_US";
			this.MenuSettingsLanguageEN_US.Size = new System.Drawing.Size(156, 22);
			this.MenuSettingsLanguageEN_US.Text = "*** ENGLISH US";
			this.MenuSettingsLanguageEN_US.Click += new System.EventHandler(this.MenuSettingsLanguageEN_US_Click);
			// 
			// MenuSettingsLanguageFR_FR
			// 
			this.MenuSettingsLanguageFR_FR.Image = ((System.Drawing.Image)(resources.GetObject("MenuSettingsLanguageFR_FR.Image")));
			this.MenuSettingsLanguageFR_FR.Name = "MenuSettingsLanguageFR_FR";
			this.MenuSettingsLanguageFR_FR.Size = new System.Drawing.Size(156, 22);
			this.MenuSettingsLanguageFR_FR.Text = "***  FRENCH FR";
			this.MenuSettingsLanguageFR_FR.Click += new System.EventHandler(this.MenuSettingsLanguageFR_FR_Click);
			// 
			// MenuHelp
			// 
			this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpAbout});
			this.MenuHelp.Name = "MenuHelp";
			this.MenuHelp.Size = new System.Drawing.Size(52, 20);
			this.MenuHelp.Text = "*** ???";
			// 
			// MenuHelpAbout
			// 
			this.MenuHelpAbout.Name = "MenuHelpAbout";
			this.MenuHelpAbout.Size = new System.Drawing.Size(131, 22);
			this.MenuHelpAbout.Text = "*** ABOUT";
			this.MenuHelpAbout.Click += new System.EventHandler(this.MenuHelpAbout_Click);
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DummyLabel,
            this.LanguageLabel});
			this.StatusBar.Location = new System.Drawing.Point(0, 439);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(726, 22);
			this.StatusBar.TabIndex = 1;
			this.StatusBar.Text = "statusStrip1";
			// 
			// DummyLabel
			// 
			this.DummyLabel.Name = "DummyLabel";
			this.DummyLabel.Size = new System.Drawing.Size(705, 17);
			this.DummyLabel.Spring = true;
			// 
			// LanguageLabel
			// 
			this.LanguageLabel.Margin = new System.Windows.Forms.Padding(0, 3, 6, 2);
			this.LanguageLabel.Name = "LanguageLabel";
			this.LanguageLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 461);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.MainMenu);
			this.Fading = Thrak.Forms.Form.FadingOption.Both;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.PersistAppearance = true;
			this.Text = "64th";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem MenuFile;
		private System.Windows.Forms.ToolStripMenuItem MenuFileQuit;
		private System.Windows.Forms.ToolStripMenuItem MenuSettings;
		private System.Windows.Forms.ToolStripMenuItem MenuSettingsLanguage;
		private System.Windows.Forms.ToolStripMenuItem MenuSettingsLanguageEN_US;
		private System.Windows.Forms.ToolStripMenuItem MenuSettingsLanguageFR_FR;
		private System.Windows.Forms.ToolStripMenuItem MenuHelp;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel DummyLabel;
		private System.Windows.Forms.ToolStripStatusLabel LanguageLabel;
		private System.Windows.Forms.ToolStripMenuItem MenuDisplay;
		private System.Windows.Forms.ToolStripMenuItem MenuDisplay64thShell;
		private System.Windows.Forms.ToolStripMenuItem MenuDisplay64thConsole;
		}
	}

