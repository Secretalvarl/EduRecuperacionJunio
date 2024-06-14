using EduRecuperacionJunio.Controladores;
using EduRecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {


        public void altaNuevoPropietario()
        {
            bool cerrarPropietario = false;
            do
            {
                PropietarioDto propietarios = new PropietarioDto();
                bool cerrarPedidda = false;
                do
                {
                    Console.WriteLine("Escriba el dni del nuevo propietario");
                    string dniDado = Console.ReadLine();

                    if (dniDado.Length != 9)
                    {
                        Console.WriteLine("El dni dado no sirve vuelva a escribirlo");
                    }
                    else
                    {
                        propietarios.Dni = dniDado;
                        cerrarPedidda = true;
                    }

                } while (!cerrarPedidda);

                propietarios.Id = calcularIDPropietarios();

                Console.WriteLine("Desea seguir añadiendo propietarios? Si - No");
                string eleccion = Console.ReadLine();

                if (eleccion.Equals("No")){

                    cerrarPropietario = true;
                    foreach (PropietarioDto propietario in Program.listaPropietarios)
                    {
                        Console.WriteLine(propietario.ToString('-'));
                    }
                }

            }while (!cerrarPropietario);

        }


        /// <summary>
        /// Metodo privado para calcular el id de los propietarios
        /// agb-14/06/2024
        /// </summary>
        /// <returns></returns>
        private int calcularIDPropietarios()
        {
            int id;

            if(Program.listaPropietarios.Count() == 0) {

                id = 1;
            }
            else
            {
                id = Program.listaPropietarios.Count() + 1;
            }

            return id;

        }
        /// <summary>
        /// Metodo privado para calcular el id de los vehiculos
        /// agb-14/06/2024
        /// </summary>
        /// <returns></returns>
        private int calcularIDVehiculos()
        {
            int id;

            if (Program.listaVehiculos.Count() == 0)
            {

                id = 1;
            }
            else
            {
                id = Program.listaVehiculos.Count() + 1;
            }

            return id;

        }
    }
}
