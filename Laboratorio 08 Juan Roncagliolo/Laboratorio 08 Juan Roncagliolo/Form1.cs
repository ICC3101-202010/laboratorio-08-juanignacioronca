using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_08_Juan_Roncagliolo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Agregar_Local_Click(object sender, EventArgs e)
        {
            agregar_Local1.Show();
            mostrar_Locales1.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agregar_Local1.Hide();
            mostrar_Locales1.Hide();  
        }

        private void button_Locales_existentes(object sender, EventArgs e)
        {
            agregar_Local1.Hide();
            mostrar_Locales1.Show();

        }
    }
}
