namespace encapsulamento
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string email;
        private string endereco;


 
        public string Nome {
            get { return (string) nome; }
            set { if (value != "") nome = value; }
        }

        public int Idade {
            get { return (int) idade; }
            set { if(value > 0) idade = value; }
        }
        public string Telefone {
            get { return (string) telefone; }
            set { if(value != "") telefone = value; }
        }
        public string Email {
            get { return (string) email; }
            set { if (value != "") email = value; }
        }
        public string Endereco {
            get { return endereco; }
            set { if (value != "") endereco = value; }
        }
    }
}
