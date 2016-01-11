namespace SixtyForth. Forms
	{
	partial class ForthConsole
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
			this.SuspendLayout();
			// 
			// ForthConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(667, 423);
			this.ErrorColor.Background = System.Drawing.Color.Black;
			this.ErrorColor.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.InputColor.Background = System.Drawing.Color.Black;
			this.InputColor.Foreground = System.Drawing.Color.Green;
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "ForthConsole";
			this.OutputColor.Background = System.Drawing.Color.Black;
			this.OutputColor.Foreground = System.Drawing.Color.Green;
			this.PromptColor.Background = System.Drawing.Color.Black;
			this.PromptColor.Foreground = System.Drawing.Color.DarkCyan;
			this.TextColor.Background = System.Drawing.Color.Black;
			this.TextColor.Foreground = System.Drawing.Color.Green;
			this.Load += new System.EventHandler(this.ForthConsole_Load);
			this.ResumeLayout(false);

			}

		#endregion
		}
	}
