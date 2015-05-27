using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Entidade
{
    class FaixaConsumo
    {
        public Int32    Minimo          { get; set; }
        public Int32    Maximo          { get; set; }
        public Double   Agua            { get; set; }
        public Double   Esgoto          { get; set; }
        public Int32    AguaFixo        { get; set; }
        public Int32    EsgotoFixo      { get; set; }
        public String   Tipo            { get; set; }
    }
}
