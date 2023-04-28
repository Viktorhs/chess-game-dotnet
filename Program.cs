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
        Tabuleiro tab = new Tabuleiro(8, 8);
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
        tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

        tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 0));
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 3));
        tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 2));

        Tela.ImprimirTabuleiro(tab);
      }
      catch (TabuleiroException e)
      {
        System.Console.WriteLine(e.Message);
      }
      Console.ReadLine();
    }
  }
}