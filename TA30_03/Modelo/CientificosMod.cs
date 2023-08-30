using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_03.Modelo
{
    internal class CientificosMod
    {
        //Atributos
        private static int Incrementid = 1;
        private int id = 0;
        private string dni;
        private string NomApels;

        public CientificosMod(string nDNI, string nNomApels)
        {
            this.id = Incrementid++;
            this.dni = nDNI;
            this.NomApels = nNomApels;
        }
        //GETs SETs
        public int Id { get => id; set => id = value; }
        public string DNI { get => dni; set => dni = value; }
        public string NOMApels { get => NomApels; set => NomApels = value; }
    }

}

