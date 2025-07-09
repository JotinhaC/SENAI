using System;
namespace RPG
{
    public class Classes
    {

        class Arqueiro : Personagem
        {
            public static void arqueiro(Personagem p1)
            {

                p1.Classe = "Arqueiro";
                p1.Hp = p1.Hp - 20;
                p1.Dex = p1.Dex + 5;
                p1.Agi = p1.Agi + 10;
                p1.Def = p1.Def - 5;

            }
        }
        class Guerreiro : Personagem
        {
            public static void guerreiro(Personagem p1)
            {
                p1.Classe = "Guerreiro";
                p1.Hp = p1.Hp + 50;
                p1.Def = p1.Def + 10;
                p1.Inl = p1.Inl - 10;
            }
        }
        class Mago : Personagem
        {
            public static void mago(Personagem p1)
            {
                p1.Classe = "Mago";
                p1.Def = p1.Def - 10;
                p1.Inl = p1.Inl + 10;
            }
        }
        class Assassino : Personagem
        {
            public static void assassin(Personagem p1)
            {
                p1.Classe = "Assassino";
                p1.Hp = p1.Hp - 20;
                p1.Dex = p1.Dex + 10;
                p1.Agi = p1.Agi + 5;
                p1.Def = p1.Def - 10;
            }
        }
        class Mediocre : Personagem
        {
            public static void mediocre(Personagem p1)
            {
                p1.Classe = "Mediocre";
                p1.Hp = p1.Hp - 90;
            }
        }
        class MagoDeGuerra : Personagem
        {
            public static void magoDeGuerra(Personagem p1)
            {
                p1.Classe = "Mago de Guerra";
                p1.Hp = p1.Hp + 25;
                p1.Inl = p1.Inl + 5;
                p1.Def = p1.Def - 5;
            }
        }
        class AssassinoAgil : Personagem
        {
            public static void assassinoAgil(Personagem p1)
            {
                p1.Classe = "Assassino Ágil";
                p1.Hp = p1.Hp - 15;
                p1.Dex = p1.Dex + 6;
                p1.Agi = p1.Agi + 6;
                p1.Def = p1.Def - 15;
            }
        }
        class ArqueiroDefensivo : Personagem
        {
            public static void arqueiroDefensivo(Personagem p1)
            {
                p1.Classe = "Arqueiro Defensivo";
                p1.Hp = p1.Hp + 20;
                p1.Dex = p1.Dex + 1;
                p1.Agi = p1.Agi + 2;
                p1.Def = p1.Def + 2;
            }
        }
        class MagoAssassino : Personagem
        {
            public static void magoAssassino(Personagem p1)
            {
                p1.Classe = "Mago Assassino";
                p1.Hp = p1.Hp - 30;
                p1.Dex = p1.Dex + 4;
                p1.Agi = p1.Agi + 2;
                p1.Inl = p1.Inl + 4;
                p1.Def = p1.Def - 10;
            }
        }
        class AssassinoDeBriga : Personagem
        {
            public static void assassinoDeBriga(Personagem p1)
            {
                p1.Classe = "Assassino de Briga";
                p1.Hp = p1.Hp + 10;
                p1.Dex = p1.Dex + 2;
                p1.Agi = p1.Agi + 2;
                p1.Def = p1.Def + 5;
                p1.Inl = p1.Inl - 5;
            }
        }
        class GuerreiroAgil : Personagem
        {
            public static void guerreiroAgil(Personagem p1)
            {
                p1.Classe = "Guerreiro Ágil";
                p1.Hp = p1.Hp + 20;
                p1.Agi = p1.Agi + 3;
                p1.Def = p1.Def + 6;
                p1.Inl = p1.Inl - 4;
            }
        }
        class ArqueiroArcano : Personagem
        {
            public static void arqueiroArcano(Personagem p1)
            {
                p1.Classe = "Arqueiro Arcano";
                p1.Hp = p1.Hp - 25;
                p1.Dex = p1.Dex + 3;
                p1.Agi = p1.Agi + 5;
                p1.Inl = p1.Inl + 2;
                p1.Def = p1.Def - 15;
            }
        }
        public static void SetClasse(Personagem p1)
        {
            if (p1.Dex > p1.Agi && p1.Dex > p1.Def && p1.Dex > p1.Inl)
            { Assassino.assassin(p1); }
            else if (p1.Agi > p1.Dex && p1.Agi > p1.Def && p1.Agi > p1.Inl)
            { Arqueiro.arqueiro(p1); }
            else if (p1.Def > p1.Dex && p1.Def > p1.Inl && p1.Def > p1.Agi)
            { Guerreiro.guerreiro(p1); }
            else if (p1.Inl == p1.Dex && p1.Def == p1.Agi && p1.Inl == p1.Agi)
            { Mediocre.mediocre(p1); }
            else if (p1.Inl > p1.Dex && p1.Inl > p1.Def && p1.Inl > p1.Agi)
            { Mago.mago(p1); }
            else if (p1.Agi > p1.Dex && p1.Agi > p1.Def && p1.Inl > p1.Def && p1.Inl > p1.Dex)
            { ArqueiroArcano.arqueiroArcano(p1); }
            else if (p1.Dex > p1.Agi && p1.Dex > p1.Def && p1.Inl > p1.Def && p1.Inl > p1.Agi)
            { MagoAssassino.magoAssassino(p1); }
            else if (p1.Def > p1.Agi && p1.Def > p1.Dex && p1.Inl > p1.Agi && p1.Inl > p1.Dex)
            { MagoDeGuerra.magoDeGuerra(p1); }
            else if (p1.Agi > p1.Dex && p1.Agi > p1.Inl && p1.Def > p1.Dex && p1.Def > p1.Inl)
            { ArqueiroDefensivo.arqueiroDefensivo(p1); }
            else if (p1.Dex > p1.Def && p1.Dex > p1.Inl && p1.Agi > p1.Def && p1.Agi > p1.Inl)
            { AssassinoAgil.assassinoAgil(p1); }
            else if (p1.Dex > p1.Agi && p1.Dex > p1.Inl && p1.Def > p1.Agi && p1.Def > p1.Inl)
            { AssassinoDeBriga.assassinoDeBriga(p1); }
            else if (p1.Agi > p1.Dex && p1.Agi > p1.Inl && p1.Def > p1.Dex && p1.Def > p1.Inl)
            { GuerreiroAgil.guerreiroAgil(p1); }
            }
        }
    }
