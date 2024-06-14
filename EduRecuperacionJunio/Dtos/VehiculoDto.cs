using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionJunio.Dtos
{
    internal class VehiculoDto
    {
        //Campos
        int id;
        string matricula;
        DateTime fchMatriculacion = new DateTime(1999, 12, 31);

        //Geters and setters
        public int Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }

        //Constructo vacio
        public VehiculoDto() { }
    }
}
