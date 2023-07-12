using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class TransferenciaBE
    {
        public String Cod_Tran { get; set; }
        public Single Mon_Tran { get; set; }
        public String Cuen_Dest { get; set; }
        public String Cuen_Orig { get; set; }
        public Int16 Tran_Int { get; set; }
        public DateTime Fec_Tran { get; set; }
    }
}
