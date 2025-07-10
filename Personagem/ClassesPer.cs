using System;
using System.Reflection.Metadata.Ecma335;
namespace RPG
{
    public class Classes
    {

        class Arqueiro : Personagem
        {
            public static void arqueiro(Personagem heroi)
            {

                heroi.Classe = "Arqueiro";
                heroi.Hp = heroi.Hp - 20;
                heroi.Dex = heroi.Dex + 5;
                heroi.Agi = heroi.Agi + 10;
                heroi.Def = heroi.Def - 5;

            }
        }
        class Guerreiro : Personagem
        {
            public static void guerreiro(Personagem heroi)
            {
                heroi.Classe = "Guerreiro";
                heroi.Hp = heroi.Hp + 50;
                heroi.Def = heroi.Def + 10;
                heroi.Inl = heroi.Inl - 10;
            }
        }
        class Mago : Personagem
        {
            public static void mago(Personagem heroi)
            {
                heroi.Classe = "Mago";
                heroi.Def = heroi.Def - 10;
                heroi.Inl = heroi.Inl + 10;
            }
        }
        class Assassino : Personagem
        {
            public static void assassin(Personagem heroi)
            {
                heroi.Classe = "Assassino";
                heroi.Hp = heroi.Hp - 20;
                heroi.Dex = heroi.Dex + 10;
                heroi.Agi = heroi.Agi + 5;
                heroi.Def = heroi.Def - 10;
            }
        }
        class Mediocre : Personagem
        {
            public static void mediocre(Personagem heroi)
            {
                heroi.Classe = "Mediocre";
                heroi.Hp = heroi.Hp - 90;
            }
        }
        class MagoDeGuerra : Personagem
        {
            public static void magoDeGuerra(Personagem heroi)
            {
                heroi.Classe = "Mago de Guerra";
                heroi.Hp = heroi.Hp + 25;
                heroi.Inl = heroi.Inl + 5;
                heroi.Def = heroi.Def - 5;
            }
        }
        class AssassinoAgil : Personagem
        {
            public static void assassinoAgil(Personagem heroi)
            {
                heroi.Classe = "Assassino Ágil";
                heroi.Hp = heroi.Hp - 15;
                heroi.Dex = heroi.Dex + 6;
                heroi.Agi = heroi.Agi + 6;
                heroi.Def = heroi.Def - 15;
            }
        }
        class ArqueiroDefensivo : Personagem
        {
            public static void arqueiroDefensivo(Personagem heroi)
            {
                heroi.Classe = "Arqueiro Defensivo";
                heroi.Hp = heroi.Hp + 20;
                heroi.Dex = heroi.Dex + 1;
                heroi.Agi = heroi.Agi + 2;
                heroi.Def = heroi.Def + 2;
            }
        }
        class MagoAssassino : Personagem
        {
            public static void magoAssassino(Personagem heroi)
            {
                heroi.Classe = "Mago Assassino";
                heroi.Hp = heroi.Hp - 30;
                heroi.Dex = heroi.Dex + 4;
                heroi.Agi = heroi.Agi + 2;
                heroi.Inl = heroi.Inl + 4;
                heroi.Def = heroi.Def - 10;
            }
        }
        class AssassinoDeBriga : Personagem
        {
            public static void assassinoDeBriga(Personagem heroi)
            {
                heroi.Classe = "Assassino de Briga";
                heroi.Hp = heroi.Hp + 10;
                heroi.Dex = heroi.Dex + 2;
                heroi.Agi = heroi.Agi + 2;
                heroi.Def = heroi.Def + 5;
                heroi.Inl = heroi.Inl - 5;
            }
        }
        class GuerreiroAgil : Personagem
        {
            public static void guerreiroAgil(Personagem heroi)
            {
                heroi.Classe = "Guerreiro Ágil";
                heroi.Hp = heroi.Hp + 20;
                heroi.Agi = heroi.Agi + 3;
                heroi.Def = heroi.Def + 6;
                heroi.Inl = heroi.Inl - 4;
            }
        }
        class ArqueiroArcano : Personagem
        {
            public static void arqueiroArcano(Personagem heroi)
            {
                heroi.Classe = "Arqueiro Arcano";
                heroi.Hp = heroi.Hp - 25;
                heroi.Dex = heroi.Dex + 3;
                heroi.Agi = heroi.Agi + 5;
                heroi.Inl = heroi.Inl + 2;
                heroi.Def = heroi.Def - 15;
            }
        }
        public static void SetClasse(Personagem heroi)
        {
            if (heroi.Dex > heroi.Agi && heroi.Dex > heroi.Def && heroi.Dex > heroi.Inl)
            { Assassino.assassin(heroi); }
            else if (heroi.Agi > heroi.Dex && heroi.Agi > heroi.Def && heroi.Agi > heroi.Inl)
            { Arqueiro.arqueiro(heroi); }
            else if (heroi.Def > heroi.Dex && heroi.Def > heroi.Inl && heroi.Def > heroi.Agi)
            { Guerreiro.guerreiro(heroi); }
            else if (heroi.Inl == heroi.Dex && heroi.Def == heroi.Agi && heroi.Inl == heroi.Agi)
            { Mediocre.mediocre(heroi); }
            else if (heroi.Inl > heroi.Dex && heroi.Inl > heroi.Def && heroi.Inl > heroi.Agi)
            { Mago.mago(heroi); }
            else if (heroi.Agi > heroi.Dex && heroi.Agi > heroi.Def && heroi.Inl > heroi.Def && heroi.Inl > heroi.Dex)
            { ArqueiroArcano.arqueiroArcano(heroi); }
            else if (heroi.Dex > heroi.Agi && heroi.Dex > heroi.Def && heroi.Inl > heroi.Def && heroi.Inl > heroi.Agi)
            { MagoAssassino.magoAssassino(heroi); }
            else if (heroi.Def > heroi.Agi && heroi.Def > heroi.Dex && heroi.Inl > heroi.Agi && heroi.Inl > heroi.Dex)
            { MagoDeGuerra.magoDeGuerra(heroi); }
            else if (heroi.Agi > heroi.Dex && heroi.Agi > heroi.Inl && heroi.Def > heroi.Dex && heroi.Def > heroi.Inl)
            { ArqueiroDefensivo.arqueiroDefensivo(heroi); }
            else if (heroi.Dex > heroi.Def && heroi.Dex > heroi.Inl && heroi.Agi > heroi.Def && heroi.Agi > heroi.Inl)
            { AssassinoAgil.assassinoAgil(heroi); }
            else if (heroi.Dex > heroi.Agi && heroi.Dex > heroi.Inl && heroi.Def > heroi.Agi && heroi.Def > heroi.Inl)
            { AssassinoDeBriga.assassinoDeBriga(heroi); }
            else if (heroi.Agi > heroi.Dex && heroi.Agi > heroi.Inl && heroi.Def > heroi.Dex && heroi.Def > heroi.Inl)
            { GuerreiroAgil.guerreiroAgil(heroi); }
            } 
        }
    }
