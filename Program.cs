using System;

namespace Personagem
{
    class Program
    {
        static void Main(string[] args)
        {
           Personagem character = new Personagem();

           System.Console.WriteLine("Bem vindo à Monorian, aqui começa a sua aventura!");
           System.Console.WriteLine("Escolha um nome para o seu personagem.");
           character.Name = Console.ReadLine();
           System.Console.WriteLine("Qual o gênero do seu personagem?");
           character.Genre = Console.ReadLine();
           System.Console.WriteLine("Escolha sua classe. Digite: Paladin, Wizard ou Warrior.");
           character.Class = Console.ReadLine();
           System.Console.WriteLine("Com qual habilidade você prefere começar? Saiba que você aprendera as outras habilidades passando de nível.");
           character.ChoiceSpell();
           System.Console.Write("Personagem: " + character);
        }
    }
}
