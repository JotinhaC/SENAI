using System;
using RPG;
using System.Threading.Tasks;
namespace RPG
{
    class Program 
    {
        static async Task Main(string[] args)
        {
            Personagem p1 = new Personagem();
            Processos processos = new Processos();
            await processos.criacao();
           
            p1.Agi = 0;
        }
    }
}