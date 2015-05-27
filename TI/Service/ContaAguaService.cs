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
        private static readonly FaixaConsumoService faixaConsumoService = new FaixaConsumoService();

        private static readonly double COFINS = 3d;

        public double getTotal(Conta conta)
        {
            return getTotalSemImposto(conta) + getImposto(conta);
        }

        public double getTotalSemImposto(Conta conta)
        {
            double consumo = getConsumo(conta);

            String tipoPessoa = pessoaStrategy.getById(conta.Consumidor).Tipo;

            return faixaConsumoService.getAll()

                .Where(faixa => consumo >= faixa.Minimo && faixa.TipoConta == conta.TipoConta && faixa.TipoPessoa == tipoPessoa)

                .Sum(faixa => faixaConsumoService.getTotal(consumo, faixa));
        }

        public double getConsumo(Conta conta)
        {
            return conta.LeituraAtual - conta.LeituraAnterior;
        }

        public double getImposto(Conta conta)
        {
            return COFINS;
        }

    }
}
