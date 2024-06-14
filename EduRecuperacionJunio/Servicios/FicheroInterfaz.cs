using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Servicios
{
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo para crear fichero log y escribir en el 
        /// agb-14/06/2024
        /// </summary>
        /// <param name="msg"></param>
        public void crearFicheroLog(string msg);
        /// <summary>
        /// Metodo para extraer los datos de un fichero
        /// agb-14/06/2024
        /// </summary>
        /// <param name="msg"></param>
        public void cargaInicial();
    }
}
