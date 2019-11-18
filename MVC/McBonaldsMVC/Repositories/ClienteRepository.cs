using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class ClienteRepository {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Cliente cliente) {
            var linha = new string[] {PrepararRegistroCSV(cliente), "", PrepararRegistroCSV(cliente)};
             File.AppendAllLines(PATH, linha);
             return true;

        }

        public Cliente ObterPor(string email) {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas) {
                if(ExtraiValorDoCampo("email", item).Equals(email)) {
                    Cliente c = new Cliente();
                    c.Nome = ExtraiValorDoCampo("nome", item);
                    c.Email = ExtraiValorDoCampo("email", item);
                    c.Endereco = ExtraiValorDoCampo("endereço", item);
                    c.DataNascimento = DateTime.Parse(ExtraiValorDoCampo("data_nascimento", item));
                    c.Telefone = ExtraiValorDoCampo("telefone", item);
                    c.Senha = ExtraiValorDoCampo("senha", item);
            return c;
                }
            }
            return null;
        }
        private string ExtraiValorDoCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";" , indiceChave);
            var valor = "";

            if(indiceTerminal != -1) {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            } else { 
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }
        private string PrepararRegistroCSV(Cliente cliente) {
            return $"nome={cliente.Nome}; email={cliente.Email}; endereço={cliente.Endereco}; senha={cliente.Senha}; telefone={cliente.Telefone}; data_nascimento={cliente.DataNascimento}";

        }
    }
}