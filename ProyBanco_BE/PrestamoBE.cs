using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class PrestamoBE
    {
        public String Cod_Pre { get; set; }
        public Single Mon_Pre { get; set; }
        public Int16 Cuot_Pre { get; set; }
        public DateTime Fec_Sol { get; set; }
        public DateTime Fec_Rech { get; set; }
        public DateTime Fec_Can { get; set; }
        public Int16 Pre_Est { get; set; }
        public Int16 Com_Deu { get; set; }
        public String Cod_Cli { get; set; }
        public String Cod_Emp { get; set; }
        public String Cod_Age { get; set; }
        public Int16 Est_Pre { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
