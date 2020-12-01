using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {  //tipo do objeto - indicador do novo 
            Personagem objetoPersonagem = new Personagem();

            objetoPersonagem.nome = "Ester";
            objetoPersonagem.idade = 20;
            objetoPersonagem.armadura = "voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Thalita";
            objetoPersonagem2.idade = 18;
            objetoPersonagem2.armadura = "Velocidade";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem.nome} - {objetoPersonagem.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");




        }
    }
}
