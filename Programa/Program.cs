using RPG;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG

{   
    class Program
    {
        Personagem heroi = new Personagem();
        Personagem vilao = new Personagem();
        Processos processos = new Processos();
        CombateP combate = new CombateP();

        
        static async Task Main(string[] args)
        {
            
            Personagem heroi = new Personagem();
            Personagem vilao = new Personagem();
            Processos processos = new Processos();
            CombateP combate = new CombateP();
            int opc;
       
            do
            {
                opc = processos.introdução();
                switch (opc)
                {
                    case 1:
                        await processos.criacao(heroi, processos);
                        break;
                    case 2:
                        await processos.Guia();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por jogar! Até a proxima!");
                        return;
                }
            } while (opc != 3);
       
           
            processos.CriarInimigo(heroi, vilao, 1);
            combate.COMBATE(processos,heroi, vilao);
            

        }
    } 
}