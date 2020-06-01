namespace Laboratorio_08_Juan_Roncagliolo
{
    partial class Form1
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
            System.Windows.Forms.Button button_Locales_existentes;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Agregar_Local = new System.Windows.Forms.Button();
            this.label_Menu_Principal = new System.Windows.Forms.Label();
            this.mostrar_Locales1 = new Laboratorio_08_Juan_Roncagliolo.Mostrar_Locales();
            this.agregar_Local1 = new Laboratorio_08_Juan_Roncagliolo.Agregar_Local();
            button_Locales_existentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Locales_existentes
            // 
            button_Locales_existentes.BackColor = System.Drawing.Color.LightSkyBlue;
            button_Locales_existentes.FlatAppearance.BorderSize = 0;
            button_Locales_existentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Locales_existentes.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_Locales_existentes.ForeColor = System.Drawing.Color.Black;
            button_Locales_existentes.Location = new System.Drawing.Point(362, 401);
            button_Locales_existentes.MaximumSize = new System.Drawing.Size(400, 400);
            button_Locales_existentes.MinimumSize = new System.Drawing.Size(400, 400);
            button_Locales_existentes.Name = "button_Locales_existentes";
            button_Locales_existentes.Size = new System.Drawing.Size(400, 400);
            button_Locales_existentes.TabIndex = 0;
            button_Locales_existentes.Text = "Locales Existentes";
            button_Locales_existentes.UseVisualStyleBackColor = false;
            button_Locales_existentes.Click += new System.EventHandler(this.button_Locales_existentes);
            // 
            // button_Agregar_Local
            // 
            this.button_Agregar_Local.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Agregar_Local.FlatAppearance.BorderSize = 0;
            this.button_Agregar_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Agregar_Local.Image = ((System.Drawing.Image)(resources.GetObject("button_Agregar_Local.Image")));
            this.button_Agregar_Local.Location = new System.Drawing.Point(1146, 401);
            this.button_Agregar_Local.MaximumSize = new System.Drawing.Size(400, 400);
            this.button_Agregar_Local.MinimumSize = new System.Drawing.Size(400, 400);
            this.button_Agregar_Local.Name = "button_Agregar_Local";
            this.button_Agregar_Local.Size = new System.Drawing.Size(400, 400);
            this.button_Agregar_Local.TabIndex = 2;
            this.button_Agregar_Local.UseVisualStyleBackColor = false;
            this.button_Agregar_Local.Click += new System.EventHandler(this.button_Agregar_Local_Click);
            // 
            // label_Menu_Principal
            // 
            this.label_Menu_Principal.AutoSize = true;
            this.label_Menu_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label_Menu_Principal.Font = new System.Drawing.Font("Verdana", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Menu_Principal.Location = new System.Drawing.Point(595, 130);
            this.label_Menu_Principal.Name = "label_Menu_Principal";
            this.label_Menu_Principal.Size = new System.Drawing.Size(724, 113);
            this.label_Menu_Principal.TabIndex = 3;
            this.label_Menu_Principal.Text = "Menu Principal";
            // 
            // mostrar_Locales1
            // 
            this.mostrar_Locales1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mostrar_Locales1.BackgroundImage")));
            this.mostrar_Locales1.Location = new System.Drawing.Point(0, 0);
            this.mostrar_Locales1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.Name = "mostrar_Locales1";
            this.mostrar_Locales1.Size = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.TabIndex = 5;
            // 
            // agregar_Local1
            // 
            this.agregar_Local1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregar_Local1.BackgroundImage")));
            this.agregar_Local1.Location = new System.Drawing.Point(0, 0);
            this.agregar_Local1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.Name = "agregar_Local1";
            this.agregar_Local1.Size = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.mostrar_Locales1);
            this.Controls.Add(this.agregar_Local1);
            this.Controls.Add(this.label_Menu_Principal);
            this.Controls.Add(this.button_Agregar_Local);
            this.Controls.Add(button_Locales_existentes);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Agregar_Local;
        private System.Windows.Forms.Label label_Menu_Principal;
        private Agregar_Local agregar_Local1;
        private Mostrar_Locales mostrar_Locales1;
    }
}

