﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        
        int numero = Convert.ToInt32(Console.ReadLine());
        
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número inserido é par.");
        }
        else
        {
            Console.WriteLine("O número inserido é ímpar.");
        }
    }
}
