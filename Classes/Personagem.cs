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
        public void TotalAtributo(Processos processos)
        {
            totalatb = dex + inl + def + agi;
            do
            {
                if (totalatb == 20)
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
    }
}
