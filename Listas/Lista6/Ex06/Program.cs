﻿using System;

class Porgram
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }

        int opcao = int.Parse(Console.ReadLine());

        if(opcao == 1)
        {
            for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                {
                    System.Console.WriteLine(matriz[linha,coluna]);
                }
            }
        }
        else if(opcao == 2)
        {
            int somatorioElementos = 0;

            for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                {
                    somatorioElementos += matriz[linha,coluna];
                }
            }
            System.Console.WriteLine(somatorioElementos);
        }
        else if(opcao == 3)
        {
            int somatorioElementos = 0;

            for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                {
                    if(linha == 2)
                    {
                        somatorioElementos += matriz[linha,coluna];
                    }
                }
            }
            System.Console.WriteLine(somatorioElementos);
        }
        else if(opcao == 4)
        {
            int somatorioElementos = 0;

            for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                {
                    if(linha == coluna)
                    {
                        somatorioElementos += matriz[linha,coluna];
                    }
                }
            }
            System.Console.WriteLine(somatorioElementos);
        }
        else if(opcao == 5)
        {
            int somatorioElementos = 0;

            for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                {
                    if(linha == 1 && matriz[linha,coluna] % 2 == 0)
                    {
                        somatorioElementos += matriz[linha,coluna];
                    }
                }
            }
            System.Console.WriteLine(somatorioElementos);
        }
    }
}