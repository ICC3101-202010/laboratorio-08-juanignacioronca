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

namespace Laboratorio_08_Juan_Roncagliolo
{

    public partial class Mostrar_Locales : UserControl
    {
        public static List<Tiendas> Lista_Tiendas;
        public static List<Restaurantes> Lista_Restaurantes;
        public static List<Cines> Lista_Cines;
        public static List<Recreacional> Lista_Recreacional;
        public static void recivir()
        {
            Lista_Tiendas = Agregar_Local.Lista_Tiendas;
            Lista_Cines = Agregar_Local.Lista_Cines;
            Lista_Restaurantes = Agregar_Local.Lista_Restaurantes;
            Lista_Recreacional = Agregar_Local.Lista_Recreacional;
        }
        public Mostrar_Locales()
        {
            InitializeComponent();
        }
        private void button_Mostrar_Tiendas_Click(object sender, EventArgs e)
        {
            recivir();
            Info_Locales.Rows.Clear();
            MessageBox.Show(Lista_Tiendas[0].Categorias[0]);
            foreach (var tienda in Lista_Tiendas)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Tienda";
                Info_Locales.Rows[n].Cells[1].Value = tienda.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = tienda.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = tienda.ID;
                Info_Locales.Rows[n].Cells[4].Value = tienda.Horario;
                string temp = "";
                foreach (var item in tienda.Categorias)
                {
                    temp += item.ToString() + "/ ";
                }
                Info_Locales.Rows[n].Cells[5].Value = temp;
            }
        }
        private void button_Mostrar_Restaurantes_Click(object sender, EventArgs e)
        {
            recivir();
            Info_Locales.Rows.Clear();
            foreach (var restaurante in Lista_Restaurantes)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Restaurante";
                Info_Locales.Rows[n].Cells[1].Value = restaurante.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = restaurante.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = restaurante.ID;
                Info_Locales.Rows[n].Cells[4].Value = restaurante.Horario;
                Info_Locales.Rows[n].Cells[5].Value = restaurante.Disponibilidad_Mesas_Exclusivas;
            }
        }
        private void button_Mostrar_Cines_Click(object sender, EventArgs e)
        {
            recivir();
            Info_Locales.Rows.Clear();
            foreach (var cines in Lista_Cines)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Cines";
                Info_Locales.Rows[n].Cells[1].Value = cines.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = cines.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = cines.ID;
                Info_Locales.Rows[n].Cells[4].Value = cines.Horario;
                Info_Locales.Rows[n].Cells[5].Value = cines.Numero_de_Salas;
            }
        }
        private void button_Mostrar_Recreacional_Click(object sender, EventArgs e)
        {
            recivir();
            Info_Locales.Rows.Clear();
            foreach (var recreacional in Lista_Recreacional)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Recreacional";
                Info_Locales.Rows[n].Cells[1].Value = recreacional.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = recreacional.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = recreacional.ID;
                Info_Locales.Rows[n].Cells[4].Value = recreacional.Horario;
                Info_Locales.Rows[n].Cells[5].Value = "";
            }
        }
        private void button_Mostrar_Todos_Click(object sender, EventArgs e)
        {
            recivir();
            Info_Locales.Rows.Clear();
            foreach (var tienda in Lista_Tiendas)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Tienda";
                Info_Locales.Rows[n].Cells[1].Value = tienda.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = tienda.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = tienda.ID;
                Info_Locales.Rows[n].Cells[4].Value = tienda.Horario;
                string temp = "";
                foreach (var item in tienda.Categorias)
                {
                    temp += item + "/ ";
                }
                Info_Locales.Rows[n].Cells[5].Value = temp;
            }
            foreach (var restaurante in Lista_Restaurantes)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Restaurante";
                Info_Locales.Rows[n].Cells[1].Value = restaurante.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = restaurante.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = restaurante.ID;
                Info_Locales.Rows[n].Cells[4].Value = restaurante.Horario;
                Info_Locales.Rows[n].Cells[5].Value = restaurante.Disponibilidad_Mesas_Exclusivas;
            }
            foreach (var cines in Lista_Cines)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Cines";
                Info_Locales.Rows[n].Cells[1].Value = cines.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = cines.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = cines.ID;
                Info_Locales.Rows[n].Cells[4].Value = cines.Horario;
                Info_Locales.Rows[n].Cells[5].Value = cines.Numero_de_Salas;
            }
            foreach (var recreacional in Lista_Recreacional)
            {
                int n = Info_Locales.Rows.Add();
                Info_Locales.Rows[n].Cells[0].Value = "Recreacional";
                Info_Locales.Rows[n].Cells[1].Value = recreacional.Nombre;
                Info_Locales.Rows[n].Cells[2].Value = recreacional.Dueño;
                Info_Locales.Rows[n].Cells[3].Value = recreacional.ID;
                Info_Locales.Rows[n].Cells[4].Value = recreacional.Horario;
                Info_Locales.Rows[n].Cells[5].Value = "";
            }
        }
        private void button_Atras_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
