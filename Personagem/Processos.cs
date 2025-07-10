using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
namespace RPG
{
    public class Processos
    {
        Personagem? heroi = new Personagem();
        Random random = new Random();
        Classes Classes = new Classes();
        
        public int introdução()
        {

            Console.WriteLine("-------------Bem Vindo-------------");
            Console.WriteLine("O que fazer agora?");
            Console.WriteLine("1 - Criar Personagem");
            Console.WriteLine("2 - Guia de Atributos");
            Console.WriteLine("3 - Prosseguir com jornada(deve cirar um personagem antes)");
            Console.WriteLine("4 - Sair do jogo");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public async Task Guia()
        {
            Console.WriteLine("-------------Guia de Atributos-------------");
            await Task.Delay(1000);
            Console.WriteLine("\nAtributos do Personagem:");
            await Task.Delay(1000);
            Console.WriteLine("HP: Representa a vida do personagem, se chegar a 0, o personagem morre.");
            await Task.Delay(1000);
            Console.WriteLine("Destreza: Influencia no dano crítico causado pelo personagem.");
            await Task.Delay(1000);
            Console.WriteLine("Agilidade: Influencia na esquiva e na não implementada ordem de ataque do personagem.");
            await Task.Delay(1000);
            Console.WriteLine("Defesa: Reduz o dano recebido pelo personagem.");
            await Task.Delay(1000);
            Console.WriteLine("Inteligência: Influencia no dano mágico causado pelo personagem.");
            await Task.Delay(1000);
        }
        public async Task criacao(Personagem heroi,Processos processos)
        {
            Console.WriteLine("\nPara iniciarmos sua jornada você deve criar um personagem, por isso iniciemos com um nome, um nome que será lembrado por toda história. Insira-o:");
            heroi.Nome = Console.ReadLine();
            await Task.Delay(1500);
            Console.WriteLine($"Muito bem {heroi.Nome}, acreditamos no seu potencial de se tornar uma grande lenda, mas precisamos definir mais algumas coisas.\n");
            await Task.Delay(1500);
            heroi.SetAgi();
            heroi.SetDex();
            heroi.SetDef();
            heroi.SetInl();
            heroi.TotalAtributo(processos, heroi);
            Classes.SetClasse(heroi);
            Console.WriteLine("Sua classe é: " + heroi.Classe);
        }
        public void SetAtributos(Personagem heroi)
        {

            heroi.SetAgi();
            heroi.SetDex();
            heroi.SetDef();
            heroi.SetInl();

        }

        public double CalcmaiorAtb(Personagem heroi)
        {
            heroi.MaiorAtb = Math.MaxMagnitude(Math.MaxMagnitude(Math.MaxMagnitude(Math.MaxMagnitude(heroi.Dex, heroi.Agi), Math.MaxMagnitude(heroi.Def, heroi.Inl)), Math.MaxMagnitude(Math.MaxMagnitude(heroi.Dex, heroi.Inl), Math.MaxMagnitude(heroi.Dex, heroi.Def))), Math.MaxMagnitude(Math.MaxMagnitude(Math.MaxMagnitude(heroi.Agi, heroi.Inl), Math.MaxMagnitude(heroi.Agi, heroi.Def)), Math.MaxMagnitude(heroi.Def, heroi.Agi))); 
               return heroi.MaiorAtb;
        }
        public void CriarInimigo(Personagem vilao, int i)
        {
            vilao.Nome = $"Vilão{i}";
            vilao.Hp = random.Next(50, 200); 
            vilao.Dex = random.Next(0, 15);
            vilao.Agi = random.Next(0, 15);
            vilao.Def = random.Next(0, 15);
            vilao.Inl = random.Next(0, 15);
            Console.WriteLine($"Um inimigo apareceu!(OG) O nome dele é {vilao.Nome} e ele tem {vilao.Hp} de HP.");
        }
    }
}