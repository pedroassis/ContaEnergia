using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Entidade
{
    class FaixaConsumo
    {
        public String    Nome            { get; set; }
        public Int32     Minimo          { get; set; }
        public Int32     Maximo          { get; set; }
        public Double    Valor           { get; set; }
		public Double    ValorFixo       { get; set; }
        public String    TipoPessoa      { get; set; }
		public String    TipoConta       { get; set; }
    }
}
