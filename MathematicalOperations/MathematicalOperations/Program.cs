using System;
using System.Collections.Generic;

namespace MathematicalOperations
{
    class Program
    {
        static void Main()
        {
            string shouldContinue;
            do
            {
                Console.WriteLine("Alege Operatie:");
                Console.WriteLine("1.Adunare");
                Console.WriteLine("2.Scadere");
                Console.WriteLine("3.Inmultire");
                Console.WriteLine("4.Impartire");
                Console.WriteLine("5.Ridicare la putere");
                Console.WriteLine("6.Radacina patrata");
                Console.WriteLine("7.Modul de x");
                Console.WriteLine("8.Par / Impar");
                Console.WriteLine("9.Prim");
                Console.WriteLine("10.Oglindit");
                Console.WriteLine("11.Palindrom");
                Console.WriteLine("12.SuperPalindrom");
                Console.WriteLine("13.Afiseaza numerele palindrom si superpalindrom intre 1 si 10000");


                var operatie = Console.ReadLine();
                switch (operatie)
                {
                    case "1":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ai ales operatia de Adunare.");
                            double a = ReadDouble("A");
                            double b = ReadDouble("B");

                            Console.WriteLine($"A+B={a + b}");
                            break;
                        }
                
                    case "2":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Ai ales operatia de Scadere.");
                            double a = ReadDouble("A");
                            double b = ReadDouble("B");

                            Console.WriteLine($"A-B={a - b}");
                            break;
                        }

                    case "3":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Ai ales operatia de Inmultire.");
                            double a = ReadDouble("A");
                            double b = ReadDouble("B");

                            Console.WriteLine($"A*B={a * b}");
                            break;
                        }

                    case "4":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Ai ales operatia de Impartire.");
                            double a = ReadDouble("A");
                            double b = ReadDouble("B");

                            Console.WriteLine($"A/B={a / b}");
                            break;
                        }

                    case "5":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ai ales operatia de Ridicare la putere.");
                            int a = ReadInteger("A");
                            int b = ReadInteger("B");

                            Console.WriteLine($"A^B={Math.Pow(a, b)}");
                            break;
                        }

                    case "6":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ai ales operatia de aflare a Radacinii patrate.");
                            int a = ReadInteger("A");

                            Console.WriteLine($"Radacina patrata a lui A={Math.Sqrt(a)}");
                            break;
                        }

                    case "7":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ai ales operatia de aflare a Valorii absolute (Modul de x).");
                            double a = ReadDouble("A");

                            Console.WriteLine($"Valoarea absoluta a lui A={Math.Abs(a)}");
                            break;
                        }

                    case "8":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ai ales sa afli daca numarul este par/impar.");
                            int a = ReadInteger("A");

                            if (a % 2 == 0)
                            {
                                Console.WriteLine($"A={a} este numar par.");
                            }
                            else
                            {
                                Console.WriteLine($"A={a} este numar impar.");
                            }
                            break;
                        }
                    case "9":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Ai ales sa afli daca numarul este prim.");
                            int a = ReadInteger("A");

                            if (IsPrime(a))
                            {
                                Console.WriteLine($"{a} este numar prim");
                            }
                            else
                            {
                                Console.WriteLine($"{a} nu este numar prim");

                            }
                            break;
                        }

                    case "10":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Ai ales sa afli oglinditul unui numar.");
                            int a = ReadInteger("A");

                            Console.WriteLine($"Oglinditul numarului {a} este {Oglindit(a)}");
                            break;
                        }

                    case "11":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ai ales sa afli daca un numar este palindrom.");
                            int a = ReadInteger("A");

                            if (IsPalindrom(a))
                            {
                                Console.WriteLine($"{a} este numar palindrom");
                            }
                            else
                            {
                                Console.WriteLine($"{a} nu este numar palindrom");

                            }
                            break;
                        }

                    case "12":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Ai ales sa afli daca un numar este Superpalindrom.");
                            int a = ReadInteger("A");

                            if (IsPalindrom(a))
                            {
                                Math.Pow(a, 2);
                                if (IsPalindrom(a))
                                {
                                    Console.WriteLine($"{a} este numar Superpalindrom");
                                }
                                else
                                {
                                    Console.WriteLine($"{a} nu este numar Superpalindrom");

                                }
                            }
                            else
                            {
                                Console.WriteLine($"{a} nu este nici macar numar palindrom, cu atat mai putin Superpalindrom");

                            }
                            break;
                        }

                    case "13":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Ai ales sa afisezi numerele Palindrom si Super Palindrom cuprinse intre 1 si 10000");

                            var PalindromList = new List<int>();
                            Console.WriteLine($"\nNumerele Palindrom sunt:");
                            for (int i = 1; i <= 10000; i++)
                            {

                                if (IsPalindrom(i))
                                {
                                    PalindromList.Add(i);
                                   
                                }
                            }
                            for (int i = 0; i < PalindromList.Count; i++)
                                Console.Write($"{PalindromList[i]} ");

                            var superPalindromList = new List<int>();
                            Console.WriteLine($"\n\nNumerele Superpalindrom sunt:");
                            for (int i = 1; i <= 10000; i++)
                            {

                                if (IsPalindrom(i))
                                {
                                    int j = (int)Math.Pow(i, 2);
                                    if (IsPalindrom(j))
                                    {
                                        superPalindromList.Add(j);
                                       
                                    }

                                }
                            }
                            for (int i = 0; i <superPalindromList.Count; i++)
                            Console.Write($"{superPalindromList[i]} ");
                            break;
                        }
                    default:
                        break;
                }

      
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nVrei sa continui cu alta operatie?");
                Console.WriteLine("1.Da\n2.Nu");

                shouldContinue = Console.ReadLine();
                Console.Clear();
            } while (shouldContinue == "1");
        }

        private static double ReadDouble(string variableName)
        {
            Console.WriteLine($"Alege valoarea lui {variableName}");
            Console.Write($"{variableName}=");

            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Valoarea trebuie sa fie un numar real");
                return ReadDouble(variableName);
            }
        }

        private static int ReadInteger(string variableName)
        {
            Console.WriteLine($"Alege valoarea lui {variableName}");
            Console.Write($"{variableName}=");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Valoarea trebuie sa fie un numar intreg");
                return ReadInteger(variableName);
            }
        }

        static bool IsPrime(int numar)
        {
            bool isPrime = true;
            if (numar == 1 || numar == 0)
                isPrime = false;
            for (int i = 2; i <= Math.Sqrt(numar); i++)
            {
                if (numar % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        private static bool IsPalindrom(int a)
        {
            int oglindit = Oglindit(a);

            bool isPalindrom;
            if (a == oglindit)
                isPalindrom = true;
            else
                isPalindrom = false;
            return isPalindrom;
        }

        public static int Oglindit(int a)
        {
            int oglindit = 0;
            int reminder;
            int numar = a;

            while (numar > 0)
            {
                reminder = numar % 10;
                oglindit = oglindit * 10 + reminder;
                numar /= 10;
            }

            return oglindit;
        }
    }
}