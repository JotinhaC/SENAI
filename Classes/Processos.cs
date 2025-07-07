using System;
using System.Threading.Tasks;
namespace RPG
{
    public class Processos
    {
        public async Task criacao()
        {
            Personagem p1 = new Personagem();
            Console.WriteLine("-------------Bem Vindo-------------");
            Console.WriteLine("\nPara iniciarmos sua jornada, voc� deve, como fez, criar um personagem, por isso iniciemos com um nome, um nome que ser� lembrado por toda hist�ria. Insira-o:");
            p1.Nome = Console.ReadLine();
            await Task.Delay(150);
            Console.WriteLine($"Muito bem {p1.Nome}, acreditamos no seu potencial de se tornar uma grande lenda, mas precisamos definir mais algumas coisas.\nNesta jornada, voc� carregar� consigo alguns atributos. S�o eles: \nHP: Sua vida, em algumas raras ocasi�es voc� ter� a chance de aumenta-la\nDMG: � o dano que voc� inflige nos seus inimigos, ele n�o tem uma pr�pria defini��o, � baseado no seu maior atributo. Al�m disso, � calculado de acordo com o n�mero rolado no dado.\nDEX: Sua destreza, define sua chance de conseguir algum dano cr�tico, al�m de ser o principal atributo da classe arqueira.\nAGI: Define sua chance de desviar de ataques, e a chance de de voc� atacar primeiro. � o principal atributo dos assassinos.\nDEF: � o atributo que define qual ser� a redu��o do dano recebido, atributo principal da classe guerreiro.\nINL: � o atributo que agregra no dano das magias, feiti�os. Principal atributo da classe mago.", p1.Nome);
            await Task.Delay(150);
            Console.WriteLine($"{p1.Nome}, voc� deve ter percebido que citamos algumas classes, mas o que seriam elas?\nClasse � a principal fun��o em que seu personagem est� atuando, elas s�o definidas n�o por voc�, mas sim pelos maiores atributos do seu personagem.\nPor exemplo, se sua defesa for muito alta, ent�o o jogo te considerar� um -Guerreiro- e voc� receber� respectivos 'buffs' para a classe -Guerreiro-. \nEnt�o escolha sabiamente como aumenta seus atributos.", p1.Nome);
        }
        public Personagem SetAtributos;
    }   
}