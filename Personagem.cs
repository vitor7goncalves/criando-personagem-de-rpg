using System;
namespace Personagem
{
    public class Personagem
    {
        public string Name;
        public string Genre;
        public string Class;
        public string Spell;

        public string ChoiceSpell(){
            if(Class == "Paladin" || Class == "paladin"){
                System.Console.WriteLine(" 1 Cura pelas mãos - 2 Insparação Divina - 3 Vingança Sagrada");
                System.Console.Write("Escolha sua primeira habilidade: ");
                Spell = Console.ReadLine();
                if(Spell == "1"){
                   Spell = "Cura pelas mãos";
                }else if(Spell == "2"){
                   Spell = "Insparação Divina";
                }else if(Spell == "3"){
                   Spell = "Vingança Sagrada";
                }else
                {
                    System.Console.WriteLine("Error: Escolha Invalida");
                    Spell = "Error";
                }
            }
            else if(Class == "Wizard" || Class == "wizard"){
                System.Console.WriteLine(" 1 Bola de Fogo - 2 Armadura Arcana - 3 Tempestade de Gelo");
                System.Console.Write("Escolha sua primeira habilidade: ");
                Spell = Console.ReadLine();
                if(Spell == "1"){
                   Spell = "Bola de Fogo";
                }else if(Spell == "2"){
                   Spell = "Armadura Arcana";
                }else if(Spell == "3"){
                   Spell = "Tempestade de Gelo";
                }else
                {
                    System.Console.WriteLine("Error: Escolha Invalida");
                    Spell = "Error";
                }
            }
            else if(Class == "Warrior" || Class == "warrior"){
                System.Console.WriteLine(" 1 Lâmina Ardente - 2 Estratégia do Aço - 3 Montante de Sangue");
                System.Console.Write("Escolha sua primeira habilidade: ");
                Spell = Console.ReadLine(); 
                if(Spell == "1"){
                   Spell = "Lãmina Ardente";
                }else if(Spell == "2"){
                   Spell = "Estratégia do Aço";
                }else if(Spell == "3"){
                   Spell = "Montante de Sangue";
                }else
                {
                    System.Console.WriteLine("Error: Escolha Invalida");
                    Spell = "Error";
                }
            }
            else {
                System.Console.WriteLine("Error: Classe inválida 'Essa classe não existe em Monorian' ");
                Class = "Error";
            }
            return Class;
        }
            public override string ToString()
        {
            return "Nome: " + Name + " - Gênero: " + Genre + " - Classe: " + Class + " - Habilidade: " + Spell;
        }

        


    }
}