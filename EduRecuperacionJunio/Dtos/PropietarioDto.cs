using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Dtos
{
    internal class PropietarioDto
    {
        //Campos
        int id;
        string dni;
        DateTime fchCompra = new DateTime(1999, 12, 31);
        string matricula = "9999ZZZ";
        bool esHistorico = false;

        //Geters and setters
        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        //Constructor
        public PropietarioDto(int id, string dni, DateTime fchCompra, string matricula, bool esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
            
        }

        public PropietarioDto()
        {
        }

        public String ToString(char c)
        {
            string mostrar = String.Concat("Nuevo propietario: ", this.id, " ", c ," ", this.dni);

            return mostrar;
        }
    }
}
