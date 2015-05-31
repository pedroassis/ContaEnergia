using System;

namespace TI.Entidade
{
	public class Conta
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

		public override string ToString ()
		{
			System.Text.StringBuilder lines = new System.Text.StringBuilder();
			lines.AppendLine (Id.ToString());
			lines.AppendLine (NumeroRegistro.ToString());
			lines.AppendLine (LeituraAtual.ToString());
			lines.AppendLine (LeituraAnterior.ToString());
			lines.AppendLine (Consumidor.ToString());
			lines.AppendLine (TipoConta);
			lines.AppendLine (Data);
			return lines.ToString();
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

