using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_02.Modelo
{
    internal class ClienteModelo
    {
        //Atributos Cliente
        private static int Incrementid = 1;
        private int id=0;
        private string nombre;
        private string apellido;
        private string direccion;
        private string dni;
        private string fecha;

        public ClienteModelo(string nom, string ape, string dir, string dni,string fecha)
        {
            this.id= Incrementid++;
            this.nombre= nom;
            this.apellido= ape;
            this.direccion= dir;
            this.dni= dni;
            this.fecha= fecha;  
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
