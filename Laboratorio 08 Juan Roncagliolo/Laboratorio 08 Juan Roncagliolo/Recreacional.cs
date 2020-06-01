using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08_Juan_Roncagliolo
{
    public class Recreacional:Locales
    {
        public Recreacional(string nombre, string dueño, int id, string horario)
        {
            Nombre = nombre;
            Dueño = dueño;
            ID = id;
            Horario = horario;
        }
    }
}
