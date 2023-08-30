using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA30_02.Modelo
{
    //Atributos Video
    internal class VideoModelo
    {
        private int id = 0;
        private string titulo;
        private string director;
        private int cli_id;
        public VideoModelo(string nTitulo, string nDirector, int nCliId)
        {
            this.id = this.id + 1;
            this.titulo = nTitulo;
            this.director = nDirector;
            this.cli_id = nCliId;
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public int Cli_id { get => cli_id; set => cli_id = value; }
    }
}
