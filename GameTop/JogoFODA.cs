using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void iniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.chuta());
            System.Console.WriteLine(_jogadorA.corre());
            System.Console.WriteLine(_jogadorA.passe());

            System.Console.WriteLine("PROXÍMO JOGADOR!\n");

            System.Console.WriteLine(_jogadorB.chuta());
            System.Console.WriteLine(_jogadorB.corre());
            System.Console.WriteLine(_jogadorB.passe());
        }
    }
}