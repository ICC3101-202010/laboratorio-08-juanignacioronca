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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Agregar_Local = new System.Windows.Forms.Button();
            this.agregar_Local1 = new Laboratorio_08_Juan_Roncagliolo.Agregar_Local();
            this.mostrar_Locales1 = new Laboratorio_08_Juan_Roncagliolo.Mostrar_Locales();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(362, 401);
            button1.MaximumSize = new System.Drawing.Size(400, 400);
            button1.MinimumSize = new System.Drawing.Size(400, 400);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(400, 400);
            button1.TabIndex = 0;
            button1.Text = "Locales Existentes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_Agregar_Local
            // 
            this.button_Agregar_Local.BackColor = System.Drawing.Color.White;
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
            // agregar_Local1
            // 
            this.agregar_Local1.Location = new System.Drawing.Point(0, 0);
            this.agregar_Local1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.Name = "agregar_Local1";
            this.agregar_Local1.Size = new System.Drawing.Size(1920, 1080);
            this.agregar_Local1.TabIndex = 3;
            // 
            // mostrar_Locales1
            // 
            this.mostrar_Locales1.Location = new System.Drawing.Point(0, 0);
            this.mostrar_Locales1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.Name = "mostrar_Locales1";
            this.mostrar_Locales1.Size = new System.Drawing.Size(1920, 1080);
            this.mostrar_Locales1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.mostrar_Locales1);
            this.Controls.Add(this.agregar_Local1);
            this.Controls.Add(this.button_Agregar_Local);
            this.Controls.Add(button1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Agregar_Local;
        private Agregar_Local agregar_Local1;
        private Mostrar_Locales mostrar_Locales1;
    }
}

