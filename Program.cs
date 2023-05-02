﻿using System;
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

          try
          {
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab);
            System.Console.WriteLine();
            System.Console.WriteLine("Turno " + partida.Turno);
            System.Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);
            System.Console.WriteLine();
            System.Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

            System.Console.WriteLine();
            System.Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);

            partida.RealizaJogada(origem, destino);
          }
          catch (TabuleiroException e)
          {
            System.Console.WriteLine(e.Message);
            Console.ReadLine();
          }


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