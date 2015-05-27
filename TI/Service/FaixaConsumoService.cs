using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Entidade;
using SuperTrunfo;


namespace TI.Service
{
    class FaixaConsumoService
    {

        private static readonly Strategy<FaixaConsumo> STRATEGY = new DataSourceStrategy<FaixaConsumo>(); 

        public List<FaixaConsumo> getAll() {
            return STRATEGY.getAll();
        }

        public double getTotal(double consumo, FaixaConsumo faixa) {
            double maxConsumoFaixa = consumo > faixa.Maximo ? faixa.Maximo : consumo;

            double consumoFaixa = maxConsumoFaixa - faixa.Minimo;
            consumoFaixa = consumoFaixa >= 0 ? consumoFaixa : 0;

            return consumoFaixa * faixa.Agua + consumoFaixa * faixa.Esgoto + faixa.AguaFixo + faixa.EsgotoFixo;
        }

    }
}
