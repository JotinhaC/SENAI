using System;
using System.Security.Cryptography;
using RPG;

namespace RPG
{

    public class CombateP : Personagem
    {
        Random dado = new Random();
        bool esquivou;
        public double Ataque(Processos processos, Personagem personagem)
        {
            Dmg = dado.Next(0, 20) + processos.CalcmaiorAtb(personagem);
            CalcCrit(personagem);
            return Dmg;
        }
        public void CalcCrit(Personagem personagem)
        {
            double chanceCrit = dado.NextDouble() + Dex * 0.05;
            if (chanceCrit >= 1)
            {
                Console.WriteLine("Crítico!");
                Dmg *= 2;
            }
            else
            {
                chanceCrit = 0;
            }
        }
        public double DanoRecebido(Processos processos, Personagem personagemquebate, Personagem personagemqueapanha)//Quem bate vem primeiro e quem apanha vem depois
        {
            double danoRecebido = Ataque(processos, personagemquebate) - Def;
            if (danoRecebido <= 0)
            {
                danoRecebido = 0;
            }
            Console.WriteLine($"{personagemqueapanha.Nome} recebeu {danoRecebido} de dano.");
               return personagemqueapanha.Hp -= danoRecebido;
        }
        public void MostrarHp(Personagem personagemqueapanha)
        {
            Console.WriteLine($"{personagemqueapanha.Nome} está com {personagemqueapanha.Hp} HP");
        }
        public void Defesa(Personagem personagemquebate,Personagem personagemqueapanha, Processos processos)
        {
            personagemqueapanha.Hp = DanoRecebido(processos,personagemquebate, personagemqueapanha) - personagemqueapanha.Def * 1;
            Console.WriteLine($"ficando com {personagemqueapanha.Hp} HP");
        }
    
   
        public void COMBATE(Processos processos, Personagem heroi, Personagem vilao)//botar nome do heroi primeiro e do vilão depois
        {
            int op;
            do
            {
                Console.WriteLine($"O que vai fazer {heroi.Nome}?");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Esquivar");
                Console.WriteLine("3 - Defender");
                Console.WriteLine("4 - Ver seus status");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        DanoRecebido(processos, heroi, vilao);
                        MostrarHp(vilao);
                        DanoRecebido(processos, vilao, heroi);
                        MostrarHp(heroi);
                        break;
                    case 2:
                        double esquiva = dado.Next(0, 20) + Agi * 0.5;
                        if (esquiva > 20)
                        {
                            Console.WriteLine($"{Nome}, você conseguiu esquivar do ataque!");
                        }
                        else
                        {
                            Console.WriteLine($"{Nome} não conseguiu esquivar do ataque");
                            DanoRecebido(processos, vilao, heroi);
                        }
                        break;
                    case 3:
                        Defesa(vilao, heroi, processos);
                        break;
                    case 4:
                        heroi.Status();
                        break;
                }
            } while ( heroi.Hp > 0 && vilao.Hp > 0);
            if (heroi.Hp <= 0)
            {
                Console.WriteLine($"{heroi.Nome} você levanta as suas mãos para o céu e é levado. Você morreu.");
            }
            else if (vilao.Hp <= 0)
            {
                Console.WriteLine($"{vilao.Nome} foi derrotado! Parabéns pela conquista!");
            }

        }
    }
    
}