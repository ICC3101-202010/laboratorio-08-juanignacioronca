namespace Laboratorio_08_Juan_Roncagliolo
{
    partial class Agregar_Local
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Local));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Tipos_de_Locales = new System.Windows.Forms.ListBox();
            this.button_Atras = new System.Windows.Forms.Button();
            this.label_Agregar_nuevo_local = new System.Windows.Forms.Label();
            this.textBox_Particulares = new System.Windows.Forms.TextBox();
            this.textBox_Horario_de_atencion = new System.Windows.Forms.TextBox();
            this.textBox_Numero_de_ID = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_del_Dueño = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_del_Local = new System.Windows.Forms.TextBox();
            this.button_Agregar_Categoria = new System.Windows.Forms.Button();
            this.label_Opciones_segun_tipo_de_local = new System.Windows.Forms.Label();
            this.label_Tipo_de_local = new System.Windows.Forms.Label();
            this.label_Horario_de_Atencion = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Nombre_Dueño = new System.Windows.Forms.Label();
            this.label_Nombre_Local = new System.Windows.Forms.Label();
            this.button_Agregar_Local = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.listBox_Tipos_de_Locales);
            this.panel1.Controls.Add(this.button_Atras);
            this.panel1.Controls.Add(this.label_Agregar_nuevo_local);
            this.panel1.Controls.Add(this.textBox_Particulares);
            this.panel1.Controls.Add(this.textBox_Horario_de_atencion);
            this.panel1.Controls.Add(this.textBox_Numero_de_ID);
            this.panel1.Controls.Add(this.textBox_Nombre_del_Dueño);
            this.panel1.Controls.Add(this.textBox_Nombre_del_Local);
            this.panel1.Controls.Add(this.button_Agregar_Categoria);
            this.panel1.Controls.Add(this.label_Opciones_segun_tipo_de_local);
            this.panel1.Controls.Add(this.label_Tipo_de_local);
            this.panel1.Controls.Add(this.label_Horario_de_Atencion);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.label_Nombre_Dueño);
            this.panel1.Controls.Add(this.label_Nombre_Local);
            this.panel1.Controls.Add(this.button_Agregar_Local);
            this.panel1.Controls.Add(this.button_Limpiar);
            this.panel1.Location = new System.Drawing.Point(480, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 1080);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox_Tipos_de_Locales
            // 
            this.listBox_Tipos_de_Locales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Tipos_de_Locales.FormattingEnabled = true;
            this.listBox_Tipos_de_Locales.ItemHeight = 31;
            this.listBox_Tipos_de_Locales.Items.AddRange(new object[] {
            "---",
            "Tienda",
            "Restaurante",
            "Cine",
            "Recreacional"});
            this.listBox_Tipos_de_Locales.Location = new System.Drawing.Point(292, 647);
            this.listBox_Tipos_de_Locales.Name = "listBox_Tipos_de_Locales";
            this.listBox_Tipos_de_Locales.Size = new System.Drawing.Size(477, 35);
            this.listBox_Tipos_de_Locales.TabIndex = 17;
            this.listBox_Tipos_de_Locales.SelectedIndexChanged += new System.EventHandler(this.listBox_Tipos_de_Locales_SelectedIndexChanged);
            // 
            // button_Atras
            // 
            this.button_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Atras.Image = ((System.Drawing.Image)(resources.GetObject("button_Atras.Image")));
            this.button_Atras.Location = new System.Drawing.Point(27, 72);
            this.button_Atras.Name = "button_Atras";
            this.button_Atras.Size = new System.Drawing.Size(120, 90);
            this.button_Atras.TabIndex = 16;
            this.button_Atras.UseVisualStyleBackColor = true;
            this.button_Atras.Click += new System.EventHandler(this.button_Atras_Click);
            // 
            // label_Agregar_nuevo_local
            // 
            this.label_Agregar_nuevo_local.AutoSize = true;
            this.label_Agregar_nuevo_local.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Agregar_nuevo_local.Location = new System.Drawing.Point(151, 70);
            this.label_Agregar_nuevo_local.Name = "label_Agregar_nuevo_local";
            this.label_Agregar_nuevo_local.Size = new System.Drawing.Size(658, 73);
            this.label_Agregar_nuevo_local.TabIndex = 15;
            this.label_Agregar_nuevo_local.Text = "Agregar nuevo local:";
            // 
            // textBox_Particulares
            // 
            this.textBox_Particulares.Location = new System.Drawing.Point(292, 744);
            this.textBox_Particulares.Name = "textBox_Particulares";
            this.textBox_Particulares.Size = new System.Drawing.Size(477, 38);
            this.textBox_Particulares.TabIndex = 14;
            this.textBox_Particulares.Visible = false;
            // 
            // textBox_Horario_de_atencion
            // 
            this.textBox_Horario_de_atencion.Location = new System.Drawing.Point(292, 544);
            this.textBox_Horario_de_atencion.Name = "textBox_Horario_de_atencion";
            this.textBox_Horario_de_atencion.Size = new System.Drawing.Size(477, 38);
            this.textBox_Horario_de_atencion.TabIndex = 12;
            // 
            // textBox_Numero_de_ID
            // 
            this.textBox_Numero_de_ID.Location = new System.Drawing.Point(292, 444);
            this.textBox_Numero_de_ID.Name = "textBox_Numero_de_ID";
            this.textBox_Numero_de_ID.Size = new System.Drawing.Size(477, 38);
            this.textBox_Numero_de_ID.TabIndex = 11;
            // 
            // textBox_Nombre_del_Dueño
            // 
            this.textBox_Nombre_del_Dueño.Location = new System.Drawing.Point(292, 344);
            this.textBox_Nombre_del_Dueño.Name = "textBox_Nombre_del_Dueño";
            this.textBox_Nombre_del_Dueño.Size = new System.Drawing.Size(477, 38);
            this.textBox_Nombre_del_Dueño.TabIndex = 10;
            // 
            // textBox_Nombre_del_Local
            // 
            this.textBox_Nombre_del_Local.Location = new System.Drawing.Point(292, 244);
            this.textBox_Nombre_del_Local.Name = "textBox_Nombre_del_Local";
            this.textBox_Nombre_del_Local.Size = new System.Drawing.Size(477, 38);
            this.textBox_Nombre_del_Local.TabIndex = 9;
            // 
            // button_Agregar_Categoria
            // 
            this.button_Agregar_Categoria.Font = new System.Drawing.Font("Verdana", 6F);
            this.button_Agregar_Categoria.Location = new System.Drawing.Point(804, 739);
            this.button_Agregar_Categoria.Name = "button_Agregar_Categoria";
            this.button_Agregar_Categoria.Size = new System.Drawing.Size(130, 50);
            this.button_Agregar_Categoria.TabIndex = 8;
            this.button_Agregar_Categoria.Text = "Agregar";
            this.button_Agregar_Categoria.UseVisualStyleBackColor = true;
            this.button_Agregar_Categoria.Visible = false;
            this.button_Agregar_Categoria.Click += new System.EventHandler(this.button_Agregar_Categoria_Click);
            // 
            // label_Opciones_segun_tipo_de_local
            // 
            this.label_Opciones_segun_tipo_de_local.Location = new System.Drawing.Point(5, 730);
            this.label_Opciones_segun_tipo_de_local.Name = "label_Opciones_segun_tipo_de_local";
            this.label_Opciones_segun_tipo_de_local.Size = new System.Drawing.Size(281, 64);
            this.label_Opciones_segun_tipo_de_local.TabIndex = 7;
            this.label_Opciones_segun_tipo_de_local.Text = "Descripcion";
            this.label_Opciones_segun_tipo_de_local.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Opciones_segun_tipo_de_local.Visible = false;
            // 
            // label_Tipo_de_local
            // 
            this.label_Tipo_de_local.AutoSize = true;
            this.label_Tipo_de_local.Location = new System.Drawing.Point(89, 650);
            this.label_Tipo_de_local.Name = "label_Tipo_de_local";
            this.label_Tipo_de_local.Size = new System.Drawing.Size(185, 32);
            this.label_Tipo_de_local.TabIndex = 6;
            this.label_Tipo_de_local.Text = "Tipo de local:";
            // 
            // label_Horario_de_Atencion
            // 
            this.label_Horario_de_Atencion.AutoSize = true;
            this.label_Horario_de_Atencion.Location = new System.Drawing.Point(3, 550);
            this.label_Horario_de_Atencion.Name = "label_Horario_de_Atencion";
            this.label_Horario_de_Atencion.Size = new System.Drawing.Size(271, 32);
            this.label_Horario_de_Atencion.TabIndex = 5;
            this.label_Horario_de_Atencion.Text = "Horario de atencion:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(78, 450);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(196, 32);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "Numero de ID:";
            // 
            // label_Nombre_Dueño
            // 
            this.label_Nombre_Dueño.AutoSize = true;
            this.label_Nombre_Dueño.Location = new System.Drawing.Point(18, 350);
            this.label_Nombre_Dueño.Name = "label_Nombre_Dueño";
            this.label_Nombre_Dueño.Size = new System.Drawing.Size(256, 32);
            this.label_Nombre_Dueño.TabIndex = 3;
            this.label_Nombre_Dueño.Text = "Nombre del dueño:";
            // 
            // label_Nombre_Local
            // 
            this.label_Nombre_Local.AutoSize = true;
            this.label_Nombre_Local.Location = new System.Drawing.Point(38, 250);
            this.label_Nombre_Local.Name = "label_Nombre_Local";
            this.label_Nombre_Local.Size = new System.Drawing.Size(236, 32);
            this.label_Nombre_Local.TabIndex = 2;
            this.label_Nombre_Local.Text = "Nombre del local:";
            // 
            // button_Agregar_Local
            // 
            this.button_Agregar_Local.Font = new System.Drawing.Font("Verdana", 10F);
            this.button_Agregar_Local.Location = new System.Drawing.Point(553, 842);
            this.button_Agregar_Local.Name = "button_Agregar_Local";
            this.button_Agregar_Local.Size = new System.Drawing.Size(260, 100);
            this.button_Agregar_Local.TabIndex = 1;
            this.button_Agregar_Local.Text = "Agregar Local";
            this.button_Agregar_Local.UseVisualStyleBackColor = true;
            this.button_Agregar_Local.Click += new System.EventHandler(this.button_Agregar_Local_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar.Location = new System.Drawing.Point(147, 842);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(260, 100);
            this.button_Limpiar.TabIndex = 0;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // Agregar_Local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Agregar_Local";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Agregar_Categoria;
        private System.Windows.Forms.Label label_Opciones_segun_tipo_de_local;
        private System.Windows.Forms.Label label_Tipo_de_local;
        private System.Windows.Forms.Label label_Horario_de_Atencion;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Nombre_Dueño;
        private System.Windows.Forms.Label label_Nombre_Local;
        private System.Windows.Forms.Button button_Agregar_Local;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox textBox_Particulares;
        private System.Windows.Forms.TextBox textBox_Horario_de_atencion;
        private System.Windows.Forms.TextBox textBox_Numero_de_ID;
        private System.Windows.Forms.TextBox textBox_Nombre_del_Dueño;
        private System.Windows.Forms.TextBox textBox_Nombre_del_Local;
        private System.Windows.Forms.Label label_Agregar_nuevo_local;
        private System.Windows.Forms.Button button_Atras;
        private System.Windows.Forms.ListBox listBox_Tipos_de_Locales;
        public System.Windows.Forms.Panel panel1;
    }
}
