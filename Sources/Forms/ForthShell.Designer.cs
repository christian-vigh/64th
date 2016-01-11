namespace SixtyForth. Forms
	{
	partial class ForthShell
		{
		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent ( )
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForthShell));
			this.SuspendLayout();
			// 
			// ForthShell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
			this.CaretColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(895, 442);
			this.ConsoleSize = new System.Drawing.Size(110, 30);
			this.ErrorColor.Background = System.Drawing.Color.Black;
			this.ErrorColor.Foreground = System.Drawing.Color.Red;
			this.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.InputColor.Background = System.Drawing.Color.Black;
			this.InputColor.Foreground = System.Drawing.Color.Green;
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ForthShell";
			this.OutputColor.Background = System.Drawing.Color.Black;
			this.OutputColor.Foreground = System.Drawing.Color.Green;
			this.PromptColor.Background = System.Drawing.Color.Black;
			this.PromptColor.Foreground = System.Drawing.Color.Green;
			this.Text = "Shell";
			this.TextColor.Background = System.Drawing.Color.Black;
			this.TextColor.Foreground = System.Drawing.Color.LightGreen;
			this.Load += new System.EventHandler(this.ForthShell_Load);
			this.ResumeLayout(false);

			}

		#endregion
		}
	}
