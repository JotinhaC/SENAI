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
            Console.WriteLine("\nPara iniciarmos sua jornada, você deve, como fez, criar um personagem, por isso iniciemos com um nome, um nome que será lembrado por toda história. Insira-o:");
            p1.Nome = Console.ReadLine();
            await Task.Delay(150);
            Console.WriteLine($"Muito bem {p1.Nome}, acreditamos no seu potencial de se tornar uma grande lenda, mas precisamos definir mais algumas coisas.\nNesta jornada, você carregará consigo alguns atributos. São eles: \nHP: Sua vida, em algumas raras ocasiões você terá a chance de aumenta-la\nDMG: É o dano que você inflige nos seus inimigos, ele não tem uma própria definição, é baseado no seu maior atributo. Além disso, é calculado de acordo com o número rolado no dado.\nDEX: Sua destreza, define sua chance de conseguir algum dano crítico, além de ser o principal atributo da classe arqueira.\nAGI: Define sua chance de desviar de ataques, e a chance de de você atacar primeiro. É o principal atributo dos assassinos.\nDEF: É o atributo que define qual será a redução do dano recebido, atributo principal da classe guerreiro.\nINL: É o atributo que agregra no dano das magias, feitiços. Principal atributo da classe mago.", p1.Nome);
            await Task.Delay(150);
            Console.WriteLine($"{p1.Nome}, você deve ter percebido que citamos algumas classes, mas o que seriam elas?\nClasse é a principal função em que seu personagem está atuando, elas são definidas não por você, mas sim pelos maiores atributos do seu personagem.\nPor exemplo, se sua defesa for muito alta, então o jogo te considerará um -Guerreiro- e você receberá respectivos 'buffs' para a classe -Guerreiro-. \nEntão escolha sabiamente como aumenta seus atributos.", p1.Nome);
        }
        public Personagem SetAtributos;
    }   
}