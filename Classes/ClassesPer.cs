using System;
namespace RPG
{
    public class Classes
    {

        class Arqueiro : Personagem
        {
            public static void arqueiro(Personagem p1)
            {

                p1.Dex = p1.Dex + 3;
                p1.Agi = p1.Agi + 2;

            }
        }
        class Guerreiro : Personagem
        {
            public static void guerreiro(Personagem p1)
            {
                p1.Hp = p1.Hp + 50;
                p1.Def = p1.Def + 5;
                p1.Inl = p1.Inl - 3;
            }
        }
        class Mago : Personagem
        {
            public static void mago(Personagem p1)
            {

                p1.Def = p1.Def - 10;
                p1.Inl = p1.Inl + 10;
            }
        }
        class Assassino : Personagem
        {
            public static void assassin(Personagem p1)
            {
                p1.Hp = p1.Hp - 20;
                p1.Dex = p1.Dex + 2;
                p1.Agi = p1.Agi + 5;
                p1.Def = p1.Def - 10;
            }
        }
        public static void SetClasse(Personagem p1)
        {
            if (p1.Dex >= p1.Agi && p1.Dex >= p1.Def && p1.Dex >= p1.Inl)
            { Assassino.assassin(p1); }
            else if (p1.Agi >= p1.Dex && p1.Agi >= p1.Def && p1.Agi >= p1.Inl)
            { Arqueiro.arqueiro(p1); }
            else if (p1.Def >= p1.Dex && p1.Def >= p1.Inl && p1.Def >= p1.Agi)
            { Guerreiro.guerreiro(p1); }
            else { Mago.mago(p1); }
        }
    }
}