using System;

namespace DiamanteLETRAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string letras = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                char[] alfabetoemchar = letras.ToCharArray();

                Console.WriteLine("Escreva uma letra");

                string entrada = Console.ReadLine();
                entrada = entrada.ToUpper();

                int tamanho = Convert.ToChar(entrada);
                int contador = 1;
                tamanho = tamanho - 64;

                if (tamanho == 1)
                {
                    Console.WriteLine(alfabetoemchar[1]);
                }
                else
                {
                    for (int i = 0; i < tamanho ; i++)                         
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j <= tamanho - i; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(alfabetoemchar[i + 1]);
                            Console.WriteLine();
                        }
                        else if (i > 0)
                        {
                            for (int j = 0; j <= tamanho - i; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(alfabetoemchar[i + 1]);

                            for (int j = 0; j < contador; j++)
                            {
                                Console.Write(" ");
                            }
                            contador = contador + 2;
                            Console.WriteLine(alfabetoemchar[i + 1]);
                        }
                    }


                    int contador2 = tamanho;
                    
                    for (int i = tamanho - 2; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j <= tamanho - i; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(alfabetoemchar[i + 1]);
                            Console.WriteLine();
                        }
                        else if (i > 0)
                        {
                            for (int j = 0; j <= tamanho - i; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(alfabetoemchar[i + 1]);

                            contador2 = (2 * i) + 1;
                            for (int j = 0; j < contador2 - 2; j++)
                            {
                                Console.Write(" ");
                            }
                            
                            Console.WriteLine(alfabetoemchar[i + 1]);
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();                    
                }                    
            }
        }    
    }
}
