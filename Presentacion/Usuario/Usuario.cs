using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
	public abstract partial class Usuario : CoreClasses.Formulario
	{
		public Usuario()
		{
			InitializeComponent();
		}

		protected abstract void btnAceptar_Click(object sender, EventArgs e);

		private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
		{
			MenuPrincipal menu = (MenuPrincipal)this.MdiParent;
			if(menu != null) menu.CheckLogIn();
		}
	}
}
