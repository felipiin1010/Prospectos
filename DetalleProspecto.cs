using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospectos
{
    public partial class DetalleProspecto : Form
    {
        public DetalleProspecto(int idprospecto=10)
        {
            InitializeComponent();

            Deshabilitainputs();

            MuestraDatos(
                    Connexion.MostrarProspecto(idprospecto, LOGIN.perfil.GetUsuario()));

            CrearBotones(
                    Connexion.MostrarDocumentos(idprospecto, LOGIN.perfil.GetUsuario()));

        }
        public void MuestraDatos(DataTable dt)
        {


            foreach (DataRow row in dt.Rows)
            {
                txtNombre.Text = row["nombre"].ToString();
                txtApPaterno.Text = row["appaterno"].ToString();
                txtApMaterno.Text = row["apmaterno"].ToString();
                txtCalle.Text = row["calle"].ToString();
                txtNumero.Text = row["numero"].ToString();
                txtColonia.Text = row["colonia"].ToString();
                txtCp.Text = row["codigopostal"].ToString();
                txtTelefono.Text = row["telefono"].ToString();
                txtRFC.Text = row["rfc"].ToString();
                txtEstatus.Text = row["estatus"].ToString();
                txtObservaciones.Text = row["observaciones"].ToString();

                if (row["estatus"].ToString()!= "Rechazado")
                {
                    lblObservaciones.Visible = false;
                    txtObservaciones.Visible = false;
                }
            }

            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
            }
        }


        public void Deshabilitainputs()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
            }
        }
        public void CrearBotones(List<string> rutas)
        {
            int x = 40;
            foreach (var ruta in rutas)
            {
                Button dynamicButton = new Button();
                dynamicButton.Text = "Mostrar";
                dynamicButton.Location = new Point(x, 200);
                dynamicButton.Name = ruta;
                dynamicButton.Click += new EventHandler(btnDinamico_Click);
                this.Controls.Add(dynamicButton);
                x += 80;
            }
        }
        private void btnDinamico_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Process process = new Process();
            process.StartInfo.FileName =btn.Name;
            process.Start();
        }
    }
}
