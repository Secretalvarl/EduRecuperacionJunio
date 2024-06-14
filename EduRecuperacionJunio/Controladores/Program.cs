using EduRecuperacionJunio.Dtos;
using EduRecuperacionJunio.Servicios;

namespace EduRecuperacionJunio.Controladores
{
    internal class Program
    {
        // Ruta global del fichero log
        public static string rutaCompletaLog = String.Concat("C:\\Users\\Profesor\\source\\repos\\EduRecuperacionJunio\\EduRecuperacionJunio\\Log\\", Utilidades.Util.crearNombreLog());
        // Ruta global del fichero de Datos
        public static string rutaCompletaFicheroDatos = String.Concat("C:\\Users\\Profesor\\source\\repos\\EduRecuperacionJunio\\EduRecuperacionJunio\\DatosIniciales\\", "datosIniciales.txt");
        // Lista global de vehiculos
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();
        // Lista global de propietarios
        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        static void Main(string[] args)
        {
            FicheroInterfaz fi = new FicheroImplementacion();
            fi.cargaInicial();
            MenuInterfaz mi= new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;
            foreach (VehiculoDto vehiculoDto in listaVehiculos)
            {
                Console.WriteLine(vehiculoDto.Matricula, vehiculoDto.FchMatriculacion);
            }

            foreach (PropietarioDto propietarioDto in listaPropietarios)
            {
                Console.WriteLine(propietarioDto.Matricula, propietarioDto.FchCompra);
            }

            do
            {
                try
                {
                    opcionSeleccionada = mi.menuPrincipal();
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            fi.crearFicheroLog("Cerrar menu");
                            cerrarMenu = true;
                            break;
                        case 1:
                            fi.crearFicheroLog("Número de historicos");
                            break;
                        case 2:
                            oi.altaNuevoPropietario();
                            fi.crearFicheroLog("Alta nuevo propietario");
                            break;
                        default:
                            Console.WriteLine("Opcion seleccionada no valida");
                            fi.crearFicheroLog("Opcion seleccionada no valida");
                            break;

                    }

                }
                catch (Exception ex)
                {
                    fi.crearFicheroLog(ex.ToString());
                }
                

            } while (!cerrarMenu);

            

        }
    }
}