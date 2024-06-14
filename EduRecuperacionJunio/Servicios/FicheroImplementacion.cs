using EduRecuperacionJunio.Controladores;
using EduRecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void crearFicheroLog(string msg) 
        {

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(Program.rutaCompletaLog, true);

                sw.WriteLine(msg);

            }catch (Exception e)
            {
                Console.WriteLine(String.Concat("Error-007, siga usando la aplicacion con normalidad", e.ToString()));

            }finally 
            { 
                if(sw != null)
                {
                    sw.Close();
                }
            }

        }


        public void cargaInicial()
        {

            try
            {

                StreamReader sr = new StreamReader(Program.rutaCompletaFicheroDatos);

                string lineas;

                while((lineas = sr.ReadLine()) != null)
                {
                    string[] lines = lineas.Split(':');

                    PropietarioDto pd = new PropietarioDto();
                    VehiculoDto vd = new VehiculoDto();

                    pd.Matricula = lines[0];

                    vd.Matricula = lines[0];

                    String fechaMatriculacion = lines[1];
                    DateTime fechaConvertida = Convert.ToDateTime(fechaMatriculacion);
                    vd.FchMatriculacion = fechaConvertida;
                    pd.Dni = lines[2];

                    String fechaCompra = lines[3];
                    DateTime fechaCompraConvertida = Convert.ToDateTime(fechaCompra);
                    pd.FchCompra = fechaCompraConvertida;

                    Program.listaVehiculos.Add(vd);
                    Program.listaPropietarios.Add(pd);

                }

                sr.Close();

            }catch (Exception e)
            {
                Console.WriteLine(String.Concat("Error-006, siga usando la aplicacion con normalidad", e.ToString()));
            }

        }
    }
}
