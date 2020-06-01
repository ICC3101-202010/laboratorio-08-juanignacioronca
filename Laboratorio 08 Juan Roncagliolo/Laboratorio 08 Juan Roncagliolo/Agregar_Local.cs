using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Laboratorio_08_Juan_Roncagliolo
{
    public partial class Agregar_Local : UserControl
    {
        public static List<Tiendas> Lista_Tiendas =  new List<Tiendas>();
        public static List<Restaurantes> Lista_Restaurantes = new List<Restaurantes>(); 
        public static List<Cines> Lista_Cines = new List<Cines>();
        public static List<Recreacional> Lista_Recreacional = new List<Recreacional>();
        public static List<string> List_temp = new List<string>();
        bool bool_temp;

        public Agregar_Local()
        {
            InitializeComponent();
        }
        private void button_Atras_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void listBox_Tipos_de_Locales_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox_Tipos_de_Locales.SelectedItem.ToString()=="Tienda")
            {
                label_Opciones_segun_tipo_de_local.Show();
                label_Opciones_segun_tipo_de_local.Text = "Categorias";
                textBox_Particulares.Show();
                button_Agregar_Categoria.Show();
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Restaurante")
            {
                label_Opciones_segun_tipo_de_local.Text = "Mesas exclusivas (S/N):";
                label_Opciones_segun_tipo_de_local.Show();
                textBox_Particulares.Show();
                button_Agregar_Categoria.Hide();
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Cine")
            {
                label_Opciones_segun_tipo_de_local.Text = "Cantidad de salas:";
                label_Opciones_segun_tipo_de_local.Show();
                textBox_Particulares.Show();
                button_Agregar_Categoria.Hide();
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Recreacional")
            {
                label_Opciones_segun_tipo_de_local.Hide();
                textBox_Particulares.Hide();
                button_Agregar_Categoria.Hide();
            }
            else
            {
                label_Opciones_segun_tipo_de_local.Hide();
                textBox_Particulares.Hide();
                button_Agregar_Categoria.Hide();
            }

        }
        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Nombre_del_Local.Clear();
            textBox_Nombre_del_Dueño.Clear();
            textBox_Numero_de_ID.Clear();
            textBox_Horario_de_atencion.Clear();
            textBox_Particulares.Clear();
            List_temp.Clear();
        }
        private void button_Agregar_Local_Click(object sender, EventArgs e)
        {
            if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Tienda")
            {
                Lista_Tiendas.Add(new Tiendas(textBox_Nombre_del_Local.Text,textBox_Nombre_del_Dueño.Text,
                    Convert.ToInt32(textBox_Numero_de_ID.Text),textBox_Horario_de_atencion.Text,List_temp));
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Cine")
            {
                Lista_Cines.Add(new Cines(textBox_Nombre_del_Local.Text, textBox_Nombre_del_Dueño.Text,
                    Convert.ToInt32(textBox_Numero_de_ID.Text), textBox_Horario_de_atencion.Text,Convert.ToInt32(textBox_Particulares.Text)));
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Restaurante")
            {
                
                if (textBox_Particulares.Text =="s"||textBox_Particulares.Text == "S")
                {
                    bool_temp = true;
                }
                else if (textBox_Particulares.Text == "n" || textBox_Particulares.Text == "N")
                {
                    bool_temp = false;
                }
                else
                {
                    textBox_Particulares.Text = "Error";
                }
                Lista_Restaurantes.Add(new Restaurantes(textBox_Nombre_del_Local.Text, textBox_Nombre_del_Dueño.Text,
                    Convert.ToInt32(textBox_Numero_de_ID.Text), textBox_Horario_de_atencion.Text,bool_temp));
            }
            else if (listBox_Tipos_de_Locales.SelectedItem.ToString() == "Recreacional")
            {
                Lista_Recreacional.Add(new Recreacional(textBox_Nombre_del_Local.Text, textBox_Nombre_del_Dueño.Text,
                    Convert.ToInt32(textBox_Numero_de_ID.Text), textBox_Horario_de_atencion.Text));
            }
            Mostrar_Locales.recivir();
            textBox_Nombre_del_Local.Clear();
            textBox_Nombre_del_Dueño.Clear();
            textBox_Numero_de_ID.Clear();
            textBox_Horario_de_atencion.Clear();
            textBox_Particulares.Clear();
            List_temp.Clear();


        }
        private void button_Agregar_Categoria_Click(object sender, EventArgs e)
        {
            
            List_temp.Add(textBox_Particulares.Text);
            textBox_Particulares.Clear();
            
        }
        
    }
}

