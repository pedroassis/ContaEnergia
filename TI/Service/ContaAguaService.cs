using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.DataSource;
using TI.Entidade;


namespace TI.Service
{
    class ContaAguaService : IContaService
    {
        private static readonly Strategy<Pessoa> pessoaStrategy = new DataSourceStrategy<Pessoa>();
        private static readonly FaixaConsumoService faixaConsumoService = new FaixaConsumoService();

        private static readonly double COFINS = 0.03d;

        public double getTotal(Conta conta)
        {
            return getTotalSemImposto(conta) + getImposto(conta);
        }

        public double getTotalSemImposto(Conta conta)
        {
            double consumo = getConsumo(conta);

            String tipoPessoa = pessoaStrategy.getById(conta.Consumidor).Tipo;

			List<FaixaConsumo> faixas = faixaConsumoService.getAll ()

				.Where (faixa => consumo >= faixa.Minimo && faixa.TipoConta == conta.TipoConta && faixa.TipoPessoa == tipoPessoa)
				.ToList ();

			FaixaConsumo faixaConsumo = faixas.OrderBy (f => f.Maximo).First();

			return faixaConsumo.Maximo >= consumo ? faixaConsumo.ValorFixo : calculaFaixas (faixas, consumo);
        }

		private double calculaFaixas(List<FaixaConsumo> faixas, double consumo){

			return faixas.Sum(faixa => faixaConsumoService.getTotal(consumo, faixa));
		}

        public double getConsumo(Conta conta)
        {
            return conta.LeituraAtual - conta.LeituraAnterior;
        }

        public double getImposto(Conta conta)
        {
            return getTotalSemImposto(conta) * COFINS;
        }

    }
}
