using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
namespace RPG
{ 
    public class Processos()
    {
        Personagem? p1 = new Personagem();
        public async Task criacao()
        {
            
            Console.WriteLine("-------------Bem Vindo-------------");
            Console.WriteLine("\nPara iniciarmos sua jornada, você deve, como fez, criar um personagem, por isso iniciemos com um nome, um nome que será lembrado por toda história. Insira-o:");
            p1.Nome = Console.ReadLine();
            await Task.Delay(1500);
            Console.WriteLine($"Muito bem {p1.Nome}, acreditamos no seu potencial de se tornar uma grande lenda, mas precisamos definir mais algumas coisas.");
            await Task.Delay(1500);
            Console.WriteLine("Você deve definir seus atributos, que são: Destreza, Agilidade, Defesa e Inteligência.\nCada um desses atributos tem uma função específica no jogo, e você deve escolher como distribuí-los.");
            await Task.Delay(3000);
            Console.WriteLine($"{p1.Nome}, além disso temos também as classes. Classe é a principal função em que seu personagem está atuando, elas são definidas não por você, mas sim pelos maiores atributos do seu personagem.\nPor exemplo, se sua defesa for muito alta, então o jogo te considerará um -Guerreiro- e você receberá respectivos 'buffs' para a classe -Guerreiro-. \nEntão escolha sabiamente como aumenta seus atributos.", p1.Nome);
        }
        public void SetAtributos()
        {            
            
            p1.SetAgi();
            p1.SetDex();
            p1.SetDef(); 
            p1.SetInl();
            
        }
        
    }   
}