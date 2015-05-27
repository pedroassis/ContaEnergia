using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperTrunfo;
using TI.Entidade;


namespace TI.Service
{
    class ContaAguaService : IContaService
    {
        private static readonly Strategy<Pessoa> pessoaStrategy = new DataSourceStrategy<Pessoa>();
        private static readonly FaixaConsumoService consumoService = new FaixaConsumoService();

        private static readonly double COFINS = 3d;

        public double getTotal(Conta conta)
        {
            throw new NotImplementedException();
        }

        public double getTotalSemImposto(Conta conta)
        {
            throw new NotImplementedException();
        }

        public double getConsumo(Conta conta)
        {
            return conta.LeituraAtual - conta.LeituraAnterior;
        }

        public double getImposto(Conta conta)
        {
            return COFINS;
        }

        public double getTarifa(Conta conta)
        {
            double consumo = getConsumo(conta);

            return consumoService.getAll().Where(c => {
                return c.Maximo <= consumo; 
            })
            .Sum(c => consumoService.getTotal(consumo, c));
        }
    }
}
