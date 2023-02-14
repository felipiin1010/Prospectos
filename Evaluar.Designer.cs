
namespace Prospectos
{
    partial class Evaluar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.txtcombo = new System.Windows.Forms.ComboBox();
            this.txtAceptar = new System.Windows.Forms.Button();
            this.lblcombo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(41, 108);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(192, 77);
            this.txtobservaciones.TabIndex = 0;
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Location = new System.Drawing.Point(38, 92);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblobservaciones.TabIndex = 1;
            this.lblobservaciones.Text = "Observaciones";
            // 
            // txtcombo
            // 
            this.txtcombo.FormattingEnabled = true;
            this.txtcombo.Location = new System.Drawing.Point(41, 54);
            this.txtcombo.Name = "txtcombo";
            this.txtcombo.Size = new System.Drawing.Size(192, 21);
            this.txtcombo.TabIndex = 2;
            this.txtcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAceptar
            // 
            this.txtAceptar.Location = new System.Drawing.Point(64, 220);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(143, 27);
            this.txtAceptar.TabIndex = 3;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.UseVisualStyleBackColor = true;
            this.txtAceptar.Click += new System.EventHandler(this.txtAceptar_Click);
            // 
            // lblcombo
            // 
            this.lblcombo.AutoSize = true;
            this.lblcombo.Location = new System.Drawing.Point(38, 25);
            this.lblcombo.Name = "lblcombo";
            this.lblcombo.Size = new System.Drawing.Size(116, 13);
            this.lblcombo.TabIndex = 4;
            this.lblcombo.Text = "Seleccione una opcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcombo);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.txtcombo);
            this.Controls.Add(this.lblobservaciones);
            this.Controls.Add(this.txtobservaciones);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.ComboBox txtcombo;
        private System.Windows.Forms.Button txtAceptar;
        private System.Windows.Forms.Label lblcombo;
        private System.Windows.Forms.Label label1;
    }
}