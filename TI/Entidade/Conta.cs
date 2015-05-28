using System;

namespace TI.Entidade
{
	public class Conta : IEntidade
	{
		public Conta (){}
		public Conta (Int32 Id, Int32 NumeroRegistro, Int32 LeituraAtual, Int32 LeituraAnterior, Int32 Consumidor, String TipoConta){
			this.Id 				= Id;
			this.NumeroRegistro 	= NumeroRegistro;
			this.LeituraAtual 		= LeituraAtual;
			this.LeituraAnterior	= LeituraAnterior;
			this.Consumidor 		= Consumidor;
			this.TipoConta 			= TipoConta;
		}
		public Conta (Int32 Id, Int32 NumeroRegistro, Int32 LeituraAtual, Int32 LeituraAnterior, Int32 Consumidor){
			this.Id 				= Id;
			this.NumeroRegistro 	= NumeroRegistro;
			this.LeituraAtual 		= LeituraAtual;
			this.LeituraAnterior	= LeituraAnterior;
			this.Consumidor 		= Consumidor;
		}

		public Int32 Id				 { get; set;}
		public Int32 NumeroRegistro	 { get; set;}
		public Int32 LeituraAtual	 { get; set;}
		public Int32 LeituraAnterior { get; set;}
		public Int32 Consumidor		 { get; set;}
		public String TipoConta 	 { get; set;}
        public String Data           { get; set;}
	}
}

