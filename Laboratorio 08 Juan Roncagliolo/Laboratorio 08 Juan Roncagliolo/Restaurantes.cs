using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08_Juan_Roncagliolo
{
    public class Restaurantes:Locales
    {
        public bool Disponibilidad_Mesas_Exclusivas; 
        public Restaurantes(string nombre, string dueño, int id, string horario,bool disponibilidad)
        {
            Nombre = nombre;
            Dueño = dueño;
            ID = id;
            Horario = horario;
            Disponibilidad_Mesas_Exclusivas = disponibilidad;
        }
        
    }
}
