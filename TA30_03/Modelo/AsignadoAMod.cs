using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_03.Modelo
{
    internal class AsignadoAMod
    {
        //Atributos
        private static int Incrementid = 1;
        private int id = 0;
        private string Cientifico_Dni;
        private string Proyecto_Nombre;

        public AsignadoAMod(string nCienDNI, string nProyNom)
        {
            this.id = Incrementid++;
            this.Cientifico_Dni= nCienDNI;
            this.Proyecto_Nombre= nProyNom;
        }
        //GETs SETs
        public int Id { get => id; set => id = value; }
        public string Cien_dni { get => Cientifico_Dni; set => Cientifico_Dni = value; }
        public string Proy_Nombre { get => Proyecto_Nombre; set => Proyecto_Nombre = value; }
        
    }
}
