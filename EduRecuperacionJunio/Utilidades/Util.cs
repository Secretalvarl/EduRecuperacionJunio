using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Utilidades
{
    internal class Util
    {
        /// <summary>
        /// Metodo para crear en nombre del fichero log
        /// agb-14/06/20024
        /// </summary>
        /// <returns></returns>
        public static string crearNombreLog()
        {
            DateTime now = DateTime.Now;

            string fechaString = now.ToString("ddMMyyyy");

            string nombreLog = string.Concat("log-", fechaString, ".txt");

            return nombreLog;
        }
    }
}
