using System;
using RPG;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace RPG

{
    class Program 
    {  
        static async Task Main(string[] args)
        {
            Personagem p1 = new Personagem();
            Processos processos = new Processos();
            //await processos.criacao();
            p1.SetAgi();
            p1.SetDex();
            p1.SetDef();
            p1.SetInl();
            //p1.TotalAtributo(processos, p1);
            Classes.SetClasse(p1);
            Console.WriteLine("Sua classe é: " + p1.Classe);
        }
    } 
}