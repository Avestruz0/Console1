namespace Console1
{
    internal class Program { 
    
        static void Main(string[] args) {
            Usuario usuario = new Usuario();

            usuario.nome = "Nickolas";
            usuario.login = "root";
            usuario.senha = "Senac123#";

            //Console.WriteLine("Hello, " + usuario.nome);
            //Console.WriteLine(usuario.logar("root", "qwe123"));
            //string result = Console.ReadLine();
            //Método para digitar
            //Console.WriteLine("O usuário digitou: " + result);

            //do{
            // Console.WriteLine("Digite seu login: ");
            //string login = Console.ReadLine();

            //Console.WriteLine("Digite sua senha: ");
            //string senha = Console.ReadLine();

            // Console.WriteLine(usuario.logar(login, senha));
            // } while (true);


            string login;
            string senha;
            do
            {
                Console.WriteLine("Digite seu login: ");
                login = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();


            } while (!usuario.logar(login, senha));



        }
    }
}
