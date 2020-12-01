namespace Teste //Projeto onde esse trabalho está vinculado 
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura = "";

        //ações
        public string Atacar(){
            return "Ataque de fogo";
        }

         public string Defender(){
            return "Nâo foi dessa vez!";
        }
    }
}