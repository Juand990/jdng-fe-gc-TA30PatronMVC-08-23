using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_03.Modelo
{
    internal class ProyectosMod
    {
        //Atributos
        private string id;
        private string Nombre;
        private int Horas;
        public ProyectosMod(string nId, string nNombre, int nHoras)
        {
            this.id = nId;
            this.Nombre = nNombre;
            this.Horas=nHoras;
        }
        //GETs SETs
        public string Id { get => id; set => id = value; }
        public string NOMBRE { get => Nombre; set => Nombre = value; }
        public int HORAS { get => Horas; set => Horas = value; }
    }
}
