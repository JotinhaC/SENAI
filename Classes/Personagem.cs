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
        double dex;// Destreza do personagem, influencia em dano cr�tico
        double agi;// Agilidade do personagem, influencia em esquiva e ordem de ataque
        double def;// Defesa do personagem, reduz dano recebido
        double inl;// Intelig�ncia do personagem, influencia em dano m�gico
        public bool totalatb; // Atributostotal do personagem, deu erro, to jogando de lado por enquanto
        public void Status()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"HP: {Hp}");
            Console.WriteLine($"Dano: {Dmg}");
            Console.WriteLine($"Destreza: {Dex}");
            Console.WriteLine($"Agilidade: {Agi}");
            Console.WriteLine($"Defesa: {Def}");
            Console.WriteLine($"Intelig�ncia: {Inl}");
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

        public void SetAgi()
        {  
            {  double value;
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
        public void SetDef()
        {
            {    double value;
                // Solicita ao usu�rio que insira o valor de DEF at� 10
                // Continua solicitando at� que um valor v�lido seja inserido
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
        public void SetInl()
        {
            {
               double value;
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
        /*public void TotalAtributo(Processos processos, Personagem p1)
        {
            while (true)
            {
                void Totalatb(Personagem p1)
                    {
                    totalatb= p1.Agi + p1.Dex + p1.Inl + p1.Def <= 20 && p1.Agi + p1.Dex + p1.Inl + p1.Def != 0;
                    }

                if (totalatb == false)
                {
                    Console.WriteLine("N�o ultrapasse o limite de 20 atributos totais e tamb�m n�o zere seus atributos!");
                    p1.Inl = 0;
                    p1.Dex = 0;
                    p1.Def = 0;
                    p1.Agi = 0;
                    Console.WriteLine("Reiniciando atributos...");
                    processos.SetAtributos();
                    // Ap�s SetAtributos, o loop volta e reavalia totalatb com os novos valores
                }
                else
                {
                    Console.WriteLine("Atributos definidos com sucesso!");
                    break;
                }
            }
        }*/
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
    }
}
