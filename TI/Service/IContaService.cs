using System;

namespace TI
{
	public interface IContaService
	{
		double getTotal(Conta conta);

		double getTotalSemImposto(Conta conta);

		double getConsumo(Conta conta);

		double getImposto(Conta conta);

		double getTarifa(Conta conta);
	}
}

