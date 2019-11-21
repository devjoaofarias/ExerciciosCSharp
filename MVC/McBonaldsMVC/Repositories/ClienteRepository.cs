using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class ClienteRepository : RepositoryBase {
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
        
        private string PrepararRegistroCSV(Cliente cliente) {
            return $"nome={cliente.Nome}; email={cliente.Email}; endereço={cliente.Endereco}; senha={cliente.Senha}; telefone={cliente.Telefone}; data_nascimento={cliente.DataNascimento}";

        }
    }
}