using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string chuta()
        {
            return "Maradona estas pateando";
        }

        public string corre()
        {
            return "Maradona estas corriendo";
        }

        public string passe()
        {
            return "Maradona estas pasando";
        }
    }
}