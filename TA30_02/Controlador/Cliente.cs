using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_02.Modelo;

namespace TA30_02.Controlador
{
    internal class Cliente
    {
        //Lista de clientes
        List<ClienteModelo> lista=new List<ClienteModelo>();
        //Añadir Cliente a la lista
        public void Guardar(ClienteModelo modelo)
        {
            lista.Add(modelo);
        }
        //Obtener toda la lista
        public List<ClienteModelo> Mostrar()
        {
            return lista;
        }

    }
}
