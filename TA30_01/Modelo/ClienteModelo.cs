using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_01.Modelo
{
    internal class ClienteModelo
    {
        //Atributos de ClienteModelo
        private int id=0;
        private string nombre;
        private string apellido;
        private string direccion;
        private string dni;
        private string fecha;

        //Constructor
        public ClienteModelo(string nom, string ape, string dir, string dni,string fecha)
        {
            this.id=this.id+1;
            this.nombre= nom;
            this.apellido= ape;
            this.direccion= dir;
            this.dni= dni;
            this.fecha= fecha;  
        }
        //Gets y Sets
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
