using System;
using System.Numerics;
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
        public double totalatb; // Atributostotal do personagem
        public Personagem()
        {
            nome = "Sem nome";
            hp = 100;
            dmg = 10;
            dex = 0;
            agi = 0;
            def = 0;
            inl = 0;
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
        public double SetDmg
        {
            get { return dmg; }
            set { dmg = value; }
        }
        public double SetDex()
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
            } return dex;
        }

        public double SetAgi()
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
            } return agi;
        }
        public double SetDef()
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
            } return def;
        }
        public double SetInl()
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
            } return inl;
        }
        
        public void TotalAtributo(Processos processos, Personagem p1)
        {
            
            do
            {
                totalatb = p1.dex + p1.inl + p1.def + p1.agi;
                if (totalatb <= 20 && totalatb!= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Prossigamos com as suas caracteristicas, elas são limitadas a um total de 20, distribuidas entre DEX,AGI,DEF e INL");
                    processos.SetAtributos();
                }
            } while (true);
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
    }
}
