using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08_Juan_Roncagliolo
{
    public class Cines:Locales
    {
        public int Numero_de_Salas;
        public Cines(string nombre, string dueño, int id, string horario, int numero_de_salas)
        {
            Nombre = nombre;
            Dueño = dueño;
            ID = id;
            Horario = horario;
            Numero_de_Salas = numero_de_salas;
        }
        
    }
}
