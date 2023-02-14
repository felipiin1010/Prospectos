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
    public partial class Evaluacion : Form
    {
        public Evaluacion()
        {
            InitializeComponent();
        }
        private void Evaluacion_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DataTable dt = Connexion.EvaluarProspectos(LOGIN.perfil.GetUsuario());
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "EDITAR";
            buttonColumn.Name = "boton";
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["boton"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["id"];
                int valor = Convert.ToInt32(cell.Value.ToString());
                Evaluar detalle = new Evaluar(valor);
                detalle.ShowDialog();

                DataTable dt = Connexion.EvaluarProspectos(LOGIN.perfil.GetUsuario());
                dataGridView1.DataSource = dt;
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
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewComboBoxCell)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                }
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                string valorSeleccionado = comboBox.SelectedItem.ToString();
            }
        }
        private void Evaluacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            LOGIN.MostrarFormulario();
        }
    }
}
