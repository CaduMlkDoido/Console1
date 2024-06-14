using System.Net.Security;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.nome = "Eduardo";
            Console.WriteLine("Olá, " + usuario.nome);

            //
            string senha;
            string login;
            do{

                Console.WriteLine("Digite seu login: ");
                login = Console.ReadLine();

                Console.WriteLine("Agora digite sua senha: ");
                senha = Console.ReadLine();

                Console.WriteLine("Digite novamente"); 
            }while (usuario.logar(login, senha));

            /*
            //Método para escrever na tela           
            Console.WriteLine("Hello, " + usuario.nome);

            Console.WriteLine(usuario.logar("root", "qwe123"));

            string result = Console.ReadLine();

            //Método para ler do teclado
            Console.WriteLine("O usuario digitou: " +  result);
            */
        }
    }
}
  