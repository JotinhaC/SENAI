using System;
namespace RPG
{
    public class Personagem
    {
        string nome;
        double hp; // Vida do personagem
        double dmg;// Dano que o personagem pode causar
        double dex;// Destreza do personagem, influencia em dano crítico
        double agi;// Agilidade do personagem, influencia em esquiva e ordem de ataque
        double def;// Defesa do personagem, reduz dano recebido
        double inl;// Inteligência do personagem, influencia em dano mágico
        double totalatb; // Atributostotal do personagem
        public Personagem()
        {
            nome = "Sem nome";
            hp = 100;
            dmg = 10;
            dex = 5;
            agi = 5;
            def = 5;
            inl = 5;
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
        public double Dex
        {
            get { return dex; }
            set
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

        public double Agi
        {  
            get { return agi; }
            set
            { 
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
        public double Def
        {
            get { return def; }
            set
            {
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
        public double Inl
        {
            get { return inl; }
            set
            {
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
       
    }
}
