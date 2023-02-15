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
    public partial class Evaluar : Form
    {
        private int prospecto;
        public Evaluar(int @prospectoid)
        {
            InitializeComponent();

            lblobservaciones.Visible = false;
            txtobservaciones.Visible = false;
            prospecto = @prospectoid;
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = -1, valor = "Seleccione.." });
            items.Add(new Item() { id = 2, valor = "Autorizado" });
            items.Add(new Item() { id = 3, valor = "Rechazado" });
            txtcombo.DataSource = items;
            txtcombo.DisplayMember = "valor";
            txtcombo.ValueMember = "id";
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            string lbl = "";
            if (txtcombo.SelectedText == "Seleccione..")
                {
                    lbl = "Por favor elija una opcion";
                }
                else
                { 
                    if (txtcombo.SelectedText == "Seleccione..")
                    {
                        lbl= "Por favor elija una opcion";
                    }
                    else            
                    {
                    }
                label1.Text = lbl;
                }

            Item i =(Item) txtcombo.SelectedItem;
            if (i.valor == "Rechazado")
            {
                Connexion.GuardarEstatus(prospecto.ToString(), i.id.ToString(), txtobservaciones.Text.ToString());
            }
            else 
            {
                Connexion.GuardarEstatus(prospecto.ToString(), i.id.ToString());
            }


            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)txtcombo.SelectedItem;
            if (i.valor == "Rechazado")
            {
                lblobservaciones.Visible = true;
                txtobservaciones.Visible = true;
            }
            else
            {
                lblobservaciones.Visible = false;
                txtobservaciones.Visible = false;
            }
        }

    }
}
