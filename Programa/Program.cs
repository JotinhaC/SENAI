using System;
using RPG;
using System.Threading.Tasks;
namespace RPG
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Processos processos = new Processos();
            await processos.criacao();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}