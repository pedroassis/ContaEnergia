using System;
using System.IO;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
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

		private Dictionary<String, Pessoa> consumidores = new Dictionary<string, Pessoa> ();

		private List<Pessoa> pessoas = new List<Pessoa>();

		private List<Conta> contas;

		public ContaCSVImporter(){
			contas = contaDataSource.getAll();
		}

		public void Import(String[] lines, String[] columns, Action<Conta> notifier){

			new Thread (new ThreadStart (() => doImport(lines, columns, notifier))).Start();
		}

		private void doImport(String[] lines, String[] columns, Action<Conta> notifier){
			BlockingCollection<String> c = new BlockingCollection<String> (lines.Length);

			foreach(String t in lines){
				c.Add (t);
			}

			try {
				while(!c.IsCompleted){
					String line = c.Take();
					Conta ct = ParseLine(line, columns);
					contaDataSource.add(ct);
					notifier(ct);
				}
				pessoaDataSource.addAll(pessoas);
				pessoas = new List<Pessoa>();
			} catch(Exception e){
				Console.WriteLine(e.StackTrace);
			}
		}

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
			pessoa.Id = consumidores.ContainsKey(cell) ? consumidores[cell].Id : getLastIDPessoa(cell);
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
//			pessoaDataSource.add(pessoa);

			return pessoa.Id;
		}

		private Int32 getLastIDConta(){
			contaLastId = contaLastId == 0 && contas.Any () ? contas.Max(x => x.Id) + 1 : contaLastId + 1;
			return contaLastId;
		}

		private Int32 getLastIDPessoa(String cell){
			Pessoa p = pessoaDataSource.findOne ("Documento", cell);
			pessoaLastId = p != null ? p.Id : pessoaLastId == 0 && pessoaDataSource.getAll ().Any () ? pessoaDataSource.getAll().DefaultIfEmpty().Max(x => x.Id) + 1 : pessoaLastId + 1;
			return pessoaLastId;
		}
	}
}

