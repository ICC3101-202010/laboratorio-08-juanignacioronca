namespace Laboratorio_08_Juan_Roncagliolo
{
    partial class Mostrar_Locales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Locales));
            this.button_Mostrar_Tiendas = new System.Windows.Forms.Button();
            this.button_Mostrar_Restaurantes = new System.Windows.Forms.Button();
            this.button_Mostrar_Cines = new System.Windows.Forms.Button();
            this.button_Mostrar_Todos = new System.Windows.Forms.Button();
            this.button_Mostrar_Recreacional = new System.Windows.Forms.Button();
            this.Info_Locales = new System.Windows.Forms.DataGridView();
            this.Tipo_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_Atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particularidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Info_Locales)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Mostrar_Tiendas
            // 
            this.button_Mostrar_Tiendas.Location = new System.Drawing.Point(40, 250);
            this.button_Mostrar_Tiendas.Name = "button_Mostrar_Tiendas";
            this.button_Mostrar_Tiendas.Size = new System.Drawing.Size(200, 200);
            this.button_Mostrar_Tiendas.TabIndex = 2;
            this.button_Mostrar_Tiendas.Text = "Tiendas";
            this.button_Mostrar_Tiendas.UseVisualStyleBackColor = true;
            this.button_Mostrar_Tiendas.Click += new System.EventHandler(this.button_Mostrar_Tiendas_Click);
            // 
            // button_Mostrar_Restaurantes
            // 
            this.button_Mostrar_Restaurantes.Location = new System.Drawing.Point(397, 250);
            this.button_Mostrar_Restaurantes.Name = "button_Mostrar_Restaurantes";
            this.button_Mostrar_Restaurantes.Size = new System.Drawing.Size(200, 200);
            this.button_Mostrar_Restaurantes.TabIndex = 3;
            this.button_Mostrar_Restaurantes.Text = "Restaurantes";
            this.button_Mostrar_Restaurantes.UseVisualStyleBackColor = true;
            this.button_Mostrar_Restaurantes.Click += new System.EventHandler(this.button_Mostrar_Restaurantes_Click);
            // 
            // button_Mostrar_Cines
            // 
            this.button_Mostrar_Cines.Location = new System.Drawing.Point(754, 250);
            this.button_Mostrar_Cines.Name = "button_Mostrar_Cines";
            this.button_Mostrar_Cines.Size = new System.Drawing.Size(200, 200);
            this.button_Mostrar_Cines.TabIndex = 4;
            this.button_Mostrar_Cines.Text = "Cines";
            this.button_Mostrar_Cines.UseVisualStyleBackColor = true;
            this.button_Mostrar_Cines.Click += new System.EventHandler(this.button_Mostrar_Cines_Click);
            // 
            // button_Mostrar_Todos
            // 
            this.button_Mostrar_Todos.Location = new System.Drawing.Point(576, 550);
            this.button_Mostrar_Todos.Name = "button_Mostrar_Todos";
            this.button_Mostrar_Todos.Size = new System.Drawing.Size(200, 200);
            this.button_Mostrar_Todos.TabIndex = 5;
            this.button_Mostrar_Todos.Text = "Todos";
            this.button_Mostrar_Todos.UseVisualStyleBackColor = true;
            this.button_Mostrar_Todos.Click += new System.EventHandler(this.button_Mostrar_Todos_Click);
            // 
            // button_Mostrar_Recreacional
            // 
            this.button_Mostrar_Recreacional.Location = new System.Drawing.Point(219, 550);
            this.button_Mostrar_Recreacional.Name = "button_Mostrar_Recreacional";
            this.button_Mostrar_Recreacional.Size = new System.Drawing.Size(200, 200);
            this.button_Mostrar_Recreacional.TabIndex = 6;
            this.button_Mostrar_Recreacional.Text = "Recreacional";
            this.button_Mostrar_Recreacional.UseVisualStyleBackColor = true;
            this.button_Mostrar_Recreacional.Click += new System.EventHandler(this.button_Mostrar_Recreacional_Click);
            // 
            // Info_Locales
            // 
            this.Info_Locales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Info_Locales.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Info_Locales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Info_Locales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Local,
            this.Nombre_Local,
            this.Nombre_Dueño,
            this.Numero_ID,
            this.Horario_Atencion,
            this.Particularidades});
            this.Info_Locales.Dock = System.Windows.Forms.DockStyle.Right;
            this.Info_Locales.Location = new System.Drawing.Point(994, 0);
            this.Info_Locales.Name = "Info_Locales";
            this.Info_Locales.RowHeadersWidth = 102;
            this.Info_Locales.RowTemplate.Height = 40;
            this.Info_Locales.Size = new System.Drawing.Size(926, 1080);
            this.Info_Locales.TabIndex = 7;
            // 
            // Tipo_Local
            // 
            this.Tipo_Local.HeaderText = "Tipo Local";
            this.Tipo_Local.MinimumWidth = 12;
            this.Tipo_Local.Name = "Tipo_Local";
            // 
            // Nombre_Local
            // 
            this.Nombre_Local.HeaderText = "Nombre Local";
            this.Nombre_Local.MinimumWidth = 12;
            this.Nombre_Local.Name = "Nombre_Local";
            // 
            // Nombre_Dueño
            // 
            this.Nombre_Dueño.HeaderText = "Nombre Dueño";
            this.Nombre_Dueño.MinimumWidth = 12;
            this.Nombre_Dueño.Name = "Nombre_Dueño";
            // 
            // Numero_ID
            // 
            this.Numero_ID.HeaderText = "ID";
            this.Numero_ID.MinimumWidth = 12;
            this.Numero_ID.Name = "Numero_ID";
            // 
            // Horario_Atencion
            // 
            this.Horario_Atencion.HeaderText = "Horario de atencion";
            this.Horario_Atencion.MinimumWidth = 12;
            this.Horario_Atencion.Name = "Horario_Atencion";
            // 
            // Particularidades
            // 
            this.Particularidades.HeaderText = "Particularidades";
            this.Particularidades.MinimumWidth = 12;
            this.Particularidades.Name = "Particularidades";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.button_Atras);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_Atras
            // 
            this.button_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Atras.Image = ((System.Drawing.Image)(resources.GetObject("button_Atras.Image")));
            this.button_Atras.Location = new System.Drawing.Point(3, 3);
            this.button_Atras.Name = "button_Atras";
            this.button_Atras.Size = new System.Drawing.Size(120, 90);
            this.button_Atras.TabIndex = 17;
            this.button_Atras.UseVisualStyleBackColor = true;
            this.button_Atras.Click += new System.EventHandler(this.button_Atras_Click);
            // 
            // Mostrar_Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Info_Locales);
            this.Controls.Add(this.button_Mostrar_Recreacional);
            this.Controls.Add(this.button_Mostrar_Todos);
            this.Controls.Add(this.button_Mostrar_Cines);
            this.Controls.Add(this.button_Mostrar_Restaurantes);
            this.Controls.Add(this.button_Mostrar_Tiendas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Mostrar_Locales";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.Info_Locales)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Mostrar_Tiendas;
        private System.Windows.Forms.Button button_Mostrar_Restaurantes;
        private System.Windows.Forms.Button button_Mostrar_Cines;
        private System.Windows.Forms.Button button_Mostrar_Todos;
        private System.Windows.Forms.Button button_Mostrar_Recreacional;
        private System.Windows.Forms.DataGridView Info_Locales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_Atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particularidades;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Atras;
    }
}
