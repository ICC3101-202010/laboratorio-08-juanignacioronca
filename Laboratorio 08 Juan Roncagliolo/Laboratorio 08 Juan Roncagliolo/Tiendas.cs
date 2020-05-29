using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08_Juan_Roncagliolo
{
    class Tiendas:Locales
    {
        public List<string> Categorias;
        public Tiendas(string nombre, string dueño, int id, string horario, List<string> categorias)
        {
            Nombre = nombre;
            Dueño = dueño;
            ID = id;
            Horario = horario;
            Categorias = categorias;
        }
    }
}
