using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class PagoBE
    {
        public String Cod_Pag { get; set; }
        public Int16 Num_cuot_Pag { get; set; }
        public Single Mon_Pag { get; set; }
        public DateTime Fec_pro_Pag { get; set; }
        public DateTime Fec_real_Pag { get; set; }
        public String Cod_Pre { get; set; }
        public Int16 Est_Pag { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
