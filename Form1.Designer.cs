
namespace Prospectos
{
    partial class CapturaProspecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.lbldocumentoNombre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabcaptura = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabcaptura.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(50, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(192, 36);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApPaterno.TabIndex = 1;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(333, 36);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApMaterno.TabIndex = 2;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(50, 80);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(191, 80);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(333, 80);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 20);
            this.txtColonia.TabIndex = 5;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(49, 128);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(100, 20);
            this.txtCp.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(191, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(333, 128);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "* Nombre";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(189, 17);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(83, 13);
            this.lblApPaterno.TabIndex = 11;
            this.lblApPaterno.Text = "* Primer Apellido";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(330, 17);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(90, 13);
            this.lblApMaterno.TabIndex = 12;
            this.lblApMaterno.Text = "Segundo Apellido";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(47, 64);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(37, 13);
            this.lblCalle.TabIndex = 13;
            this.lblCalle.Text = "* Calle";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(188, 64);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "* Número";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(330, 64);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(49, 13);
            this.lblColonia.TabIndex = 15;
            this.lblColonia.Text = "* Colonia";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(46, 112);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(79, 13);
            this.lblCp.TabIndex = 16;
            this.lblCp.Text = "* Código Postal";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(188, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "* Teléfono";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(330, 112);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(35, 13);
            this.lblRFC.TabIndex = 18;
            this.lblRFC.Text = "* RFC";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(384, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Documentos";
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Location = new System.Drawing.Point(46, 200);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(0, 13);
            this.lbldocumento.TabIndex = 22;
            // 
            // lbldocumentoNombre
            // 
            this.lbldocumentoNombre.AutoSize = true;
            this.lbldocumentoNombre.Location = new System.Drawing.Point(189, 210);
            this.lbldocumentoNombre.Name = "lbldocumentoNombre";
            this.lbldocumentoNombre.Size = new System.Drawing.Size(0, 13);
            this.lbldocumentoNombre.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabcaptura);
            this.tabControl1.Controls.Add(this.tabListado);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 389);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabcaptura
            // 
            this.tabcaptura.Controls.Add(this.label2);
            this.tabcaptura.Controls.Add(this.txtNombre);
            this.tabcaptura.Controls.Add(this.button3);
            this.tabcaptura.Controls.Add(this.lbldocumentoNombre);
            this.tabcaptura.Controls.Add(this.txtApPaterno);
            this.tabcaptura.Controls.Add(this.lbldocumento);
            this.tabcaptura.Controls.Add(this.txtApMaterno);
            this.tabcaptura.Controls.Add(this.label1);
            this.tabcaptura.Controls.Add(this.txtCalle);
            this.tabcaptura.Controls.Add(this.txtNumero);
            this.tabcaptura.Controls.Add(this.txtColonia);
            this.tabcaptura.Controls.Add(this.lblRFC);
            this.tabcaptura.Controls.Add(this.txtCp);
            this.tabcaptura.Controls.Add(this.lblTelefono);
            this.tabcaptura.Controls.Add(this.txtTelefono);
            this.tabcaptura.Controls.Add(this.lblCp);
            this.tabcaptura.Controls.Add(this.txtRFC);
            this.tabcaptura.Controls.Add(this.lblColonia);
            this.tabcaptura.Controls.Add(this.button1);
            this.tabcaptura.Controls.Add(this.lblNumero);
            this.tabcaptura.Controls.Add(this.lblNombre);
            this.tabcaptura.Controls.Add(this.lblCalle);
            this.tabcaptura.Controls.Add(this.lblApPaterno);
            this.tabcaptura.Controls.Add(this.lblApMaterno);
            this.tabcaptura.Location = new System.Drawing.Point(4, 22);
            this.tabcaptura.Name = "tabcaptura";
            this.tabcaptura.Padding = new System.Windows.Forms.Padding(3);
            this.tabcaptura.Size = new System.Drawing.Size(669, 363);
            this.tabcaptura.TabIndex = 0;
            this.tabcaptura.Text = "Captura";
            this.tabcaptura.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cargar documento";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.dataGridView1);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(669, 363);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // CapturaProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 426);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CapturaProspecto";
            this.Text = "Captura de Prospecto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapturaProspecto_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabcaptura.ResumeLayout(false);
            this.tabcaptura.PerformLayout();
            this.tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lbldocumentoNombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabcaptura;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

