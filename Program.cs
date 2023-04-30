using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {

      try
      {
        PartidaDeXadrez partida = new PartidaDeXadrez();

        while (!partida.Terminada)
        {
          Console.Clear();
          Tela.ImprimirTabuleiro(partida.Tab);
          System.Console.WriteLine();
          System.Console.Write("Origem: ");
          Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
          System.Console.Write("Destino: ");
          Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

          partida.ExecutaMovimento(origem, destino);

        }


      }
      catch (TabuleiroException e)
      {
        System.Console.WriteLine(e.Message);
      }
      Console.ReadLine();
    }
  }
}