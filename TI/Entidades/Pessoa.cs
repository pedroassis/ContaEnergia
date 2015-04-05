using System;

namespace TI
{
	public class Pessoa
	{
		public Int32 Id 		{ get; set; }
		public String Nome 		{ get; set; }
		public String Documento { get; set; }
		public String Tipo 		{ get; set; }

		public Pessoa(){}

		public Pessoa(Int32 id, String nome, String documento, String tipo){
			this.Id = id;
			this.Nome = nome;
			this.Documento = documento;
			this.Tipo = tipo;
		}
	}
}

