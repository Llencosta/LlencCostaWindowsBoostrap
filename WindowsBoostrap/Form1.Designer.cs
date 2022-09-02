namespace WindowsBoostrap
{
    partial class FormBoostrap
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
            this.labelMensaje = new System.Windows.Forms.Label();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.butMostrar = new System.Windows.Forms.Button();
            this.AceptarCondiciones = new System.Windows.Forms.CheckBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.listPaises = new System.Windows.Forms.ListBox();
            this.SelecAnimales = new System.Windows.Forms.ComboBox();
            this.groupBoxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(178, 57);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(120, 16);
            this.labelMensaje.TabIndex = 0;
            this.labelMensaje.Text = "Escrive tu mensaje";
            this.labelMensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(401, 54);
            this.textBoxMensaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(245, 22);
            this.textBoxMensaje.TabIndex = 1;
            // 
            // butMostrar
            // 
            this.butMostrar.Location = new System.Drawing.Point(489, 302);
            this.butMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butMostrar.Name = "butMostrar";
            this.butMostrar.Size = new System.Drawing.Size(157, 55);
            this.butMostrar.TabIndex = 2;
            this.butMostrar.Text = "Mostrar mensaje";
            this.butMostrar.UseVisualStyleBackColor = true;
            this.butMostrar.Click += new System.EventHandler(this.butMostrar_Click);
            // 
            // AceptarCondiciones
            // 
            this.AceptarCondiciones.AutoSize = true;
            this.AceptarCondiciones.Location = new System.Drawing.Point(181, 123);
            this.AceptarCondiciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AceptarCondiciones.Name = "AceptarCondiciones";
            this.AceptarCondiciones.Size = new System.Drawing.Size(169, 20);
            this.AceptarCondiciones.TabIndex = 3;
            this.AceptarCondiciones.Text = "Acepto las condiciones";
            this.AceptarCondiciones.UseVisualStyleBackColor = true;
            this.AceptarCondiciones.CheckedChanged += new System.EventHandler(this.AceptarCondiciones_CheckedChanged);
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(5, 32);
            this.radioButtonHombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(77, 20);
            this.radioButtonHombre.TabIndex = 4;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            this.radioButtonHombre.CheckedChanged += new System.EventHandler(this.radioButtonHombre_CheckedChanged);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(5, 59);
            this.radioButtonMujer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(61, 20);
            this.radioButtonMujer.TabIndex = 5;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            this.radioButtonMujer.CheckedChanged += new System.EventHandler(this.radioButtonMujer_CheckedChanged);
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonHombre);
            this.groupBoxGenero.Controls.Add(this.radioButtonMujer);
            this.groupBoxGenero.Location = new System.Drawing.Point(181, 164);
            this.groupBoxGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGenero.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGenero.TabIndex = 6;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Genero";
            // 
            // listPaises
            // 
            this.listPaises.FormattingEnabled = true;
            this.listPaises.ItemHeight = 16;
            this.listPaises.Items.AddRange(new object[] {
            "Espanya",
            "Francia",
            "Argentina"});
            this.listPaises.Location = new System.Drawing.Point(526, 123);
            this.listPaises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPaises.Name = "listPaises";
            this.listPaises.Size = new System.Drawing.Size(120, 84);
            this.listPaises.TabIndex = 7;
            this.listPaises.SelectedIndexChanged += new System.EventHandler(this.listPaises_SelectedIndexChanged);
            // 
            // SelecAnimales
            // 
            this.SelecAnimales.FormattingEnabled = true;
            this.SelecAnimales.Items.AddRange(new object[] {
            "Lemur",
            "Perro",
            "Gato",
            "Tortuga"});
            this.SelecAnimales.Location = new System.Drawing.Point(181, 302);
            this.SelecAnimales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelecAnimales.Name = "SelecAnimales";
            this.SelecAnimales.Size = new System.Drawing.Size(121, 24);
            this.SelecAnimales.TabIndex = 8;
            this.SelecAnimales.SelectedIndexChanged += new System.EventHandler(this.SelecAnimales_SelectedIndexChanged);
            // 
            // FormBoostrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelecAnimales);
            this.Controls.Add(this.listPaises);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.AceptarCondiciones);
            this.Controls.Add(this.butMostrar);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.labelMensaje);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBoostrap";
            this.Text = "Prueva de formulario";
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.Button butMostrar;
        private System.Windows.Forms.CheckBox AceptarCondiciones;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.ListBox listPaises;
        private System.Windows.Forms.ComboBox SelecAnimales;
    }
}

