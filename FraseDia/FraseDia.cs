using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraseDia
{
	public partial class FraseDia : Form
	{
		public FraseDia()
		{
			InitializeComponent();
		}

		private void labelTitulo_Click(object sender, EventArgs e)
		{

		}

		private void buttonExibir_Click(object sender, EventArgs e)
		{
			labelResultado.Text = textBoxFrase.Text + "\n" + textBoxAutor.Text;
			textBoxAutor.Text = "";
			textBoxFrase.Text = "";
		}
	}
}
