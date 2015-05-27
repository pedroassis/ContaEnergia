using System;
using System.Collections.Generic;
using TI.Entidade;

namespace TI.Service
{
	public interface IContaService
	{
		double getTotal(Conta conta);

		double getTotalSemImposto(Conta conta);

		double getConsumo(Conta conta);

		double getImposto(Conta conta);

	}
}

