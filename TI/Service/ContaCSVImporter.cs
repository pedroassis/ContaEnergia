using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using TI.Entidade;
using TI.DataSource;

namespace TI.Service
{
	public class ContaCSVImporter
	{
		private readonly Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
		private Strategy<Conta> contaDataSource = new DataSourceStrategy<Conta>();

		private Int32 contaLastId;
		private Int32 pessoaLastId;

		private List<Pessoa> pessoas = new List<Pessoa>();

		public List<Conta> Import(String fileName, String[] columns){
			String[] lines = File.ReadAllLines(fileName);
			List<Conta> contas = lines.Select (line => ParseLine(line, columns)).ToList(); 
			pessoaDataSource.addAll (pessoas);
			pessoas = new List<Pessoa> ();
			return contas;
		}

		private Conta ParseLine(String line, String[] columns){
			String[] cells = line.Split (';');
			return new Conta (getLastIDConta(), 0, Int32.Parse(cells[4]), Int32.Parse(cells[3]), getConsumidor(cells[1]), "AGUA");
		}

		private Int32 getConsumidor(String cell){
			Pessoa pessoa = new Pessoa();
			pessoa.Id = getLastIDPessoa(cell);
			if (cell.Contains("/"))
			{                    
				pessoa.Documento = cell;
				pessoa.Tipo = "JURIDICA";                  
			}
			else
			{
				pessoa.Documento = cell;
				pessoa.Tipo = "FISICA";
			}
			pessoas.Add(pessoa);
			return pessoa.Id;
		}

		private Int32 getLastIDConta(){
			contaLastId = contaLastId == 0 && contaDataSource.getAll().Any () ? contaDataSource.getAll().Max(x => x.Id) + 1 : contaLastId + 1;
			return contaLastId;
		}

		private Int32 getLastIDPessoa(String cell){
			Pessoa p = pessoaDataSource.findOne ("Documento", cell);
			pessoaLastId = p != null ? p.Id : pessoaLastId == 0 && pessoaDataSource.getAll ().Any () ? pessoaDataSource.getAll().DefaultIfEmpty().Max(x => x.Id) + 1 : pessoaLastId + 1;
			return pessoaLastId;
		}
	}
}

