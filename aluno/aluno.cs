using system; 

namespace aluno
{
    public class aluno {
        // Propriedades
        public string nome{get;set;}
        public string curso{get;set;}
        public string cpf{get;set;}
        public int[] notas;

        // Construtores
        public aluno(string nome, string cpf){
            this.nome = nome;
            this.cpf = cpf;
        }
        public aluno(string nome, string cpf, string curso){
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;

        // Metodos de acesso
        public int[] getnotas(){return notas;}
        public void setnotas (int bi, int nota){
            int i = bi - 1;
            if ((i < 0) || (i > 3)){
                throw new ArgumentOutOfRangeException($"")
                //Condiçao de erro;
                //Condiçao de erro;
            }

        }

        

        }
    }
        
}
