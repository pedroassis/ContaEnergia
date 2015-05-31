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

		public override string ToString ()
		{
			System.Text.StringBuilder lines = new System.Text.StringBuilder();
			lines.AppendLine (Id.ToString());
			lines.AppendLine (Nome);
			lines.AppendLine (Documento);
			lines.AppendLine (Tipo);
			return lines.ToString();
		}
	}
}

