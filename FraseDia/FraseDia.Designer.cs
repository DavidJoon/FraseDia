
namespace FraseDia
{
	partial class FraseDia
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelAutor = new System.Windows.Forms.Label();
			this.labelDigite = new System.Windows.Forms.Label();
			this.textBoxFrase = new System.Windows.Forms.TextBox();
			this.textBoxAutor = new System.Windows.Forms.TextBox();
			this.buttonExibir = new System.Windows.Forms.Button();
			this.labelResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitulo
			// 
			this.labelTitulo.AutoSize = true;
			this.labelTitulo.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTitulo.Location = new System.Drawing.Point(247, 69);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(295, 44);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "Frase do Dia";
			this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
			// 
			// labelAutor
			// 
			this.labelAutor.AutoSize = true;
			this.labelAutor.Location = new System.Drawing.Point(201, 187);
			this.labelAutor.Name = "labelAutor";
			this.labelAutor.Size = new System.Drawing.Size(40, 15);
			this.labelAutor.TabIndex = 1;
			this.labelAutor.Text = "Autor:";
			// 
			// labelDigite
			// 
			this.labelDigite.AutoSize = true;
			this.labelDigite.Location = new System.Drawing.Point(161, 156);
			this.labelDigite.Name = "labelDigite";
			this.labelDigite.Size = new System.Drawing.Size(80, 15);
			this.labelDigite.TabIndex = 2;
			this.labelDigite.Text = "Digite a Frase:";
			// 
			// textBoxFrase
			// 
			this.textBoxFrase.Location = new System.Drawing.Point(247, 153);
			this.textBoxFrase.Name = "textBoxFrase";
			this.textBoxFrase.Size = new System.Drawing.Size(318, 23);
			this.textBoxFrase.TabIndex = 3;
			// 
			// textBoxAutor
			// 
			this.textBoxAutor.Location = new System.Drawing.Point(247, 184);
			this.textBoxAutor.Name = "textBoxAutor";
			this.textBoxAutor.Size = new System.Drawing.Size(223, 23);
			this.textBoxAutor.TabIndex = 4;
			// 
			// buttonExibir
			// 
			this.buttonExibir.Location = new System.Drawing.Point(490, 184);
			this.buttonExibir.Name = "buttonExibir";
			this.buttonExibir.Size = new System.Drawing.Size(75, 23);
			this.buttonExibir.TabIndex = 5;
			this.buttonExibir.Text = "Exibir";
			this.buttonExibir.UseVisualStyleBackColor = true;
			this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
			// 
			// labelResultado
			// 
			this.labelResultado.AutoSize = true;
			this.labelResultado.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelResultado.Location = new System.Drawing.Point(247, 267);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(0, 39);
			this.labelResultado.TabIndex = 6;
			// 
			// FraseDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelResultado);
			this.Controls.Add(this.buttonExibir);
			this.Controls.Add(this.textBoxAutor);
			this.Controls.Add(this.textBoxFrase);
			this.Controls.Add(this.labelDigite);
			this.Controls.Add(this.labelAutor);
			this.Controls.Add(this.labelTitulo);
			this.Name = "FraseDia";
			this.Text = "Frase do Dia";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelAutor;
		private System.Windows.Forms.Label labelDigite;
		private System.Windows.Forms.TextBox textBoxFrase;
		private System.Windows.Forms.TextBox textBoxAutor;
		private System.Windows.Forms.Button buttonExibir;
		private System.Windows.Forms.Label labelResultado;
	}
}

