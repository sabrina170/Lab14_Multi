using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14
{
   public class TodoItem
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public bool Done { get; set; }

    }
}
