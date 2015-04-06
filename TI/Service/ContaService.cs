using System;
using SuperTrunfo;

namespace TI
{
	public class ContaService
	{
		private static readonly double CONTRIBUICAO 		= 9.25d; 
		private static readonly double IMPOSTO_RESIDECIAL 	= 0.3d; 
		private static readonly double IMPOSTO_COMERCIAL 	= 0.18d; 
		private static readonly double TARIFA_RESIDECIAL 	= 0.4d; 
		private static readonly double TARIFA_COMERCIAL 	= 0.35d;

		private readonly Strategy<Pessoa> pessoaStrategy;

		public ContaService(){
			pessoaStrategy = new DataSourceStrategy<Pessoa> ();
		}

		public double getTotal(Conta conta){
			return getTotalSemImposto (conta) + getImposto (conta);
		}

		public double getTotalSemImposto(Conta conta){
			double total = getConsumo(conta);
			return total * getTarifa(conta) + CONTRIBUICAO;
		}

		public double getConsumo(Conta conta){
			return conta.LeituraAtual - conta.LeituraAnterior;
		}

		public double getImposto(Conta conta){
			return pessoaStrategy.getById(conta.Consumidor).Tipo == "COMERCIAL" ? IMPOSTO_COMERCIAL : IMPOSTO_RESIDECIAL;
		}

		public double getTarifa(Conta conta){
			return pessoaStrategy.getById(conta.Consumidor).Tipo == "COMERCIAL" ? TARIFA_COMERCIAL : TARIFA_RESIDECIAL;
		}

        internal string getTotal()
        {
            throw new NotImplementedException();
        }
    }
}

