using System;
using tabuleiro;

namespace Xadrez_console // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Posicao p;
      p = new Posicao(3, 4);

      System.Console.WriteLine("posiçâo: " + p);
    }
  }
}