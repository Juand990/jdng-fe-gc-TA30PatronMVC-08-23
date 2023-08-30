using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_02.Modelo;

namespace TA30_02.Controlador
{
    internal class Video
    {
        //Lista de Videos
        List<VideoModelo> lista = new List<VideoModelo>();
        //Añadir Video a la lista
        public void Guardar(VideoModelo modelo)
        {
            lista.Add(modelo);
        }
        //Obtener toda la lista
        public List<VideoModelo> Mostrar()
        {
            return lista;
        }
    }
}
