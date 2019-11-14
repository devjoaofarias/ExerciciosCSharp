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
        private string PrepararRegistroCSV(Cliente cliente) {
            return $"nome={cliente.Nome}; email={cliente.Email}; endereço={cliente.Endereco}; senha={cliente.Senha}; telefone={cliente.Telefone}; data_nascimento={cliente.DataNascimento}";

        }
    }
}