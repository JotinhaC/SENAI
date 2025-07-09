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
            Console.WriteLine("\nPara iniciarmos sua jornada, voc� deve, como fez, criar um personagem, por isso iniciemos com um nome, um nome que ser� lembrado por toda hist�ria. Insira-o:");
            p1.Nome = Console.ReadLine();
            await Task.Delay(1500);
            Console.WriteLine($"Muito bem {p1.Nome}, acreditamos no seu potencial de se tornar uma grande lenda, mas precisamos definir mais algumas coisas.");
            await Task.Delay(1500);
            Console.WriteLine("Voc� deve definir seus atributos, que s�o: Destreza, Agilidade, Defesa e Intelig�ncia.\nCada um desses atributos tem uma fun��o espec�fica no jogo, e voc� deve escolher como distribu�-los.");
            await Task.Delay(3000);
            Console.WriteLine($"{p1.Nome}, al�m disso temos tamb�m as classes. Classe � a principal fun��o em que seu personagem est� atuando, elas s�o definidas n�o por voc�, mas sim pelos maiores atributos do seu personagem.\nPor exemplo, se sua defesa for muito alta, ent�o o jogo te considerar� um -Guerreiro- e voc� receber� respectivos 'buffs' para a classe -Guerreiro-. \nEnt�o escolha sabiamente como aumenta seus atributos.", p1.Nome);
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