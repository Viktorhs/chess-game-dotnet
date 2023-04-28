using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {

      PosicaoXadrez pos = new PosicaoXadrez('a', 1);
      System.Console.WriteLine(pos);
      System.Console.WriteLine(pos.ToPosicao());
      Console.ReadLine();
    }
  }
}