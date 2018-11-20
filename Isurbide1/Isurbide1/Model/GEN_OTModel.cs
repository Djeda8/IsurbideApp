using Isurbide1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Isurbide1
{
    public class GEN_OTModel
    {
        public int ID { get; set; }
        public int NUMERO { get; set; }
        public string SERIE { get; set; }
        public string TIPOPARTE { get; set; }
        public string CLIENTENOMBRE { get; set; }
        public string CLIENTEDIRECCION { get; set; }
        public string FECHAINTERVENCION { get; set; }
        public string DESCRIPCION { get; set; }
        public GEN_ESTADOModel GEN_ESTADOModel { get; set; }
        //public string Estado { get; set; }
    }
}
