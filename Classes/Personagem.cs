using System;
namespace RPG
{
    public class Personagem
    {
        string nome;
        double hp;
        double dmg;
        double dex;
        double agi;
        double def;
        double inl;
        public bool pode;
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
               Console.WriteLine("Insira sua DEX (at� 10):");
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
                    Console.WriteLine("Insira sua AGI (at� 10):");
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
                    Console.WriteLine("Insira sua DEF (at� 10):");
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
               Console.WriteLine("Insira sua INL (at� 10):");
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
