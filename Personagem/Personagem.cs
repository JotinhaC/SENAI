using System;
using System.Numerics;
namespace RPG
{
    public class Personagem
    {
        
        string nome;
        string classe; // Classe do personagem, pode ser Guerreiro, Mago, Arqueiro, etc.
        double hp; // Vida do personagem
        double dmg;// Dano que o personagem pode causar
        double dex;// Destreza do personagem, influencia em dano crítico
        double agi;// Agilidade do personagem, influencia em esquiva e ordem de ataque
        double def;// Defesa do personagem, reduz dano recebido
        double inl;// Inteligência do personagem, influencia em dano mágico
        public double totalatb; // Atributostotal do personagem, deu erro, to jogando de lado por enquanto
        double maiorAtb;
        double xp;
        double nivel;
        
        public Personagem()
        {
            nome = "Desconhecido";
            classe = "";
            hp = 100;
            dmg = 0;
            dex = 0;
            agi = 0;
            def = 0;
            inl = 0;
            totalatb = 0;
            maiorAtb = 0;
        }
        public void Status()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"HP: {Hp}");
            Console.WriteLine($"Destreza: {Dex}");
            Console.WriteLine($"Agilidade: {Agi}");
            Console.WriteLine($"Defesa: {Def}");
            Console.WriteLine($"Inteligência: {Inl}");
        }
 

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public double Dmg
        {
            get { return dmg; }
            set { dmg = value; }
        }
        public void SetDex()
        {
            double value;
            {
               Console.WriteLine("Insira sua DEX (até 10):");
                do
                {
                    string? input = Console.ReadLine();
                    if (double.TryParse(input, out value) && value <= 10)
                    {
                        dex = value;
                        break;
                    }
                } while (true);
            }
        }

        public void SetAgi()
        {  
            {  double value;
                do
                {
                    Console.WriteLine("Insira sua AGI (até 10):");
                    string? input = Console.ReadLine();
                    if  (double.TryParse(input, out value) && value <= 10)
                    {
                        agi = value;
                        break;
                    }
                } while (true);
            } 
        }
        public void SetDef()
        {
            {    double value;
                // Solicita ao usuário que insira o valor de DEF até 10
                // Continua solicitando até que um valor válido seja inserido
                do
                {
                    Console.WriteLine("Insira sua DEF (até 10):");
                    string? input = Console.ReadLine();
                    if (double.TryParse(input, out value) && value <= 10)
                    {
                        def = value;
                        break;
                    }
                 } while (true);
            } 
        }
        public void SetInl()
        {
            {
               double value;
                Console.WriteLine("Insira sua INL (até 10):");
                do
                {
                    string? input = Console.ReadLine();
                    if (double.TryParse(input, out value) && value <= 10)
                    {
                        inl = value;
                        break;
                    }
                } while (true);
            } 
        }
        void Totalatb(Personagem heroi)
        {
            totalatb = heroi.Agi + heroi.Dex + heroi.Inl + heroi.Def;
        }
        public void TotalAtributo(Processos processos, Personagem heroi)
        {
            Totalatb(heroi);
            while (totalatb > 20 || totalatb == 0)
            {
                Totalatb(heroi);
                Console.WriteLine("Não ultrapasse o limite de 20 atributos totais e também não zere seus atributos!");
                heroi.Inl = 0;
                heroi.Dex = 0;
                heroi.Def = 0;
                heroi.Agi = 0;
                Console.WriteLine("Reiniciando atributos...");
                processos.SetAtributos(heroi);
                Totalatb(heroi);
            }    
            Console.WriteLine("Atributos definidos com sucesso!");        
        }
        public void NivelP(Personagem heroi)
        {
            if (heroi.Xp < 100)
            { heroi.Nivel = 1; }
            else if (heroi.Xp >= 100)
            { heroi.Nivel += 1;  Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}");  heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 200)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 350)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 500)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 650)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 800)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 1000)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 1200)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
            else if (heroi.Xp >= 1400)
            { heroi.Nivel += 1; Console.WriteLine($"Parabéns, vc subiu de Nivel! Nível {heroi.Nivel}"); heroi.Dex += 5; heroi.Agi += 5; heroi.Def += 5; heroi.Inl += 5; heroi.Hp += 5; }
        }
        public void CalcXp(Personagem heroi, Personagem vilao)
        {
            heroi.Xp += vilao.Hp - vilao.Hp * 0.25;
        }
        public double Inl
        {
            get { return inl; }
            set { inl = value; }
        }
        public double Dex
        {
            get { return dex; }
            set { dex = value; }
        }
        public double Agi
        {
            get { return agi; }
            set { agi = value; }
        }
        public double Def
        {
            get { return def; }
            set { def = value; }
        }
        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        public double MaiorAtb { get;  set; }
        public double Xp
        {
            get { return xp; }
            set { xp = value; } 
        }
        public double Nivel
        {
            get; set;
        }
    }
    
}
