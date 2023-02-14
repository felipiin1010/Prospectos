using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospectos
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        public static Form formulario;
        public static void MostrarFormulario()
        {
            formulario.Show();
        }
        public static Perfil perfil;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            formulario = this;
            lblerror.Text="";
            string lbl="";
            if (txtUsuario.Text.Length <1)
            {
                lbl+= "El usuario no puede estar vacio \n";
            }
            if (txtContrasenia.Text.Length < 1)
            {
                lbl += "La contraseña no puede estar vacia \n";
            }
            if (Acceso(txtUsuario.Text, txtContrasenia.Text))
            {
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                this.Hide();
            }
            else
            {
                lbl= "Error datos incorrectos";
            }
            lblerror.Text = lbl;
        }
        //Autenticar
        private bool Acceso(string usuario , string contrasenia)
        {
            perfil =Prospectos.Connexion.Acceso(usuario,contrasenia);
            if (perfil != null)
            {
                switch (perfil.GetPerfil())
                {
                    case "Promotor":
                        {
                            CapturaProspecto form = new CapturaProspecto();
                            form.Show();
                            break;
                        }
                    case "Evaluador":
                        {
                            Evaluacion form = new Evaluacion();
                            form.Show();
                            break;
                        }
                    default:
                        break;
                }
                return true;
            }
            return false;

        }

    }
}
