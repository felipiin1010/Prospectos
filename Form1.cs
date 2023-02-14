using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospectos
{
    public partial class CapturaProspecto : Form
    {
        public CapturaProspecto()
        {
            InitializeComponent();
            lbldocumento.Text = "";
            lbldocumento.Visible = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Ver Detalles";
            buttonColumn.Name = "boton";
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog()==DialogResult.OK)
            {
                lbldocumento.Text += "\n" + dlg.FileName;
                lbldocumentoNombre.Text += "\n" +dlg.SafeFileName;
            }
        }

        private void CapturaProspecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Se perderán los datos de la pantalla actual","Desea salir",MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                LOGIN.MostrarFormulario();            
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            if (ValidaCamposRequeridos())
            {
                int @prospectoid = Connexion.GuardarProspecto(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtCalle.Text, txtNumero.Text, txtColonia.Text, txtCp.Text, txtTelefono.Text, txtRFC.Text,LOGIN.perfil.GetUsuario());

                string[] arreglo = lbldocumento.Text.Split('\n');
                //var rutasdelimitadas = "";
                for (int i = 1; i < arreglo.Length; i++)
                {
                    string extension = arreglo[i].Split('.')[1];
                    //Generar un id para el archivo
                    string nombre = (@prospectoid).ToString()+"_"+ i.ToString();
                    System.IO.File.Copy(arreglo[i], "./" + nombre + "." + extension, true);
                    string currentDirectory = Directory.GetCurrentDirectory()+"\\";
                    //rutasdelimitadas += currentDirectory+nombre+"."+extension + "-";
                    Connexion.GuardarDocumentos(prospectoid.ToString(), currentDirectory + nombre + "." + extension);
                }
                //Connexion.GuardarDocumentos(prospectoid.ToString(), rutasdelimitadas);
                LImpiacampos();
            }
        }

        private bool ValidaCamposRequeridos()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                if (txt.Name != "txtApMaterno")
                    if ( txt.Text.Length < 1)
                    {
                        Label lbl = this.Controls.OfType<Label>().Where(x=>x.Name.Substring(3)== txt.Name.Substring(3)).First();
                        MessageBox.Show("El campo " + lbl.Text.Substring(1) + " es Requerido");

                        return false;
                    }
            }
            return true;
        }
        private void LImpiacampos()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
            lbldocumento.Text = "";
            lbldocumentoNombre.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a =tabControl1.SelectedIndex;
            if (a == 1)
            {
                DataTable dt = Connexion.MostrarProspectos(LOGIN.perfil.GetUsuario());
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
            }
        }
        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var grid = (DataGridView)sender;
            int buttonColumn = 0;
            if (grid.Columns[buttonColumn] is DataGridViewButtonColumn)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    grid.Rows[i].Cells[buttonColumn].Value = "Ver";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["boton"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["id"];
                int valor = Convert.ToInt32(cell.Value.ToString());

                DetalleProspecto detalle = new DetalleProspecto(valor);
                detalle.ShowDialog();
            }
        }

    }
    }

