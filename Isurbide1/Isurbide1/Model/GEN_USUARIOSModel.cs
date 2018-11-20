using System;
using System.Collections.Generic;
using System.Text;

namespace Isurbide1.Model
{
    public class GEN_USUARIOSModel
    {
        public int ID { get; set; }
        public string ROWID { get; set; }
        public int IDEMPRESA { get; set; }
        public string ID_INT { get; set; }
        public string CODIGO { get; set; }
        public string LOGIN { get; set; }
        public string PWD { get; set; }
        public string NOMBRE { get; set; }
        public string USERTYPE { get; set; }
        public Nullable<int> AUTO { get; set; }
        public string ACTIVO_SON { get; set; }
        public string APELLIDOS { get; set; }
        public System.DateTime FECHAINSERCION { get; set; }
        public Nullable<System.DateTime> FECHAACTUALIZACION { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
        public Nullable<int> MARCADO { get; set; }
    }
}
