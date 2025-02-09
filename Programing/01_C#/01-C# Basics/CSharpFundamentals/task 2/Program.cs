namespace Task___2
{
    internal class Program
    {
        static void PrintMainMenu()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("P - Print Numbers. ");
            Console.WriteLine("A - Add A Number. ");
            Console.WriteLine("M - Display Mean Of The Numbers. ");
            Console.WriteLine("S - Display The Smallest Numbers. ");
            Console.WriteLine("L - Display The Largest Numbers. ");
            Console.WriteLine("F - Find A Number. ");
            Console.WriteLine("C - Claer The Whole List. ");
            Console.WriteLine("Q - Quit. ");
            Console.WriteLine("===============================================");
        }

        static void Main(string[] args)
        {

            List<int> ListNumber = new List<int>();
            PrintMainMenu();
            char EnterCharacter = ' ';
            int SmallerNumber = 2147483647, LargerNumber = 0;
            double Average = 0;

            while (EnterCharacter != 'Q')
            {
                Console.Write("Chosse Any Character : ");
                EnterCharacter = char.Parse(Console.ReadLine().ToUpper());

                if (EnterCharacter == 'P')
                {
                    Console.Write("Print Numbers : ");
                    if (ListNumber.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", ListNumber));
                    }
                    else
                    {
                        Console.WriteLine("The List Empty\n");
                    }
                }

                else if (EnterCharacter == 'A')
                {
                    Console.Write("Add Number : ");
                    int EnterNumber = int.Parse(Console.ReadLine());
                    ListNumber.Add(EnterNumber);
                    Console.WriteLine($"Number {EnterNumber} Is Added\n");
                }

                else if (EnterCharacter == 'C')
                {
                    Console.WriteLine("Clear The Whole List\n");
                    ListNumber.Clear();
                }

                else if (EnterCharacter == 'M')
                {
                    if (ListNumber.Count > 0)
                    {
                        int Sum = 0;
                        for (int i = 0; i < ListNumber.Count; i++)
                        {
                            Sum += ListNumber[i];
                        }
                        Average = (double)Sum / ListNumber.Count;
                        Console.WriteLine($"The Average Number Is : {Average}\n");
                    }
                    else
                    {
                        Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
                    }
                }

                else if (EnterCharacter == 'S')
                {
                    if (ListNumber.Count > 0)
                    {
                        int Sum = 0;
                        for (int i = 0; i < ListNumber.Count; i++)
                        {
                            Sum += ListNumber[i];
                            if (ListNumber[i] < SmallerNumber)
                                SmallerNumber = ListNumber[i];
                        }
                        Console.WriteLine($"The Smaller Number Is : {SmallerNumber}\n");
                    }
                    else
                    {
                        Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
                    }
                }

                else if (EnterCharacter == 'L')
                {
                    {
                        if (ListNumber.Count > 0)
                        {
                            int Sum = 0;
                            for (int i = 0; i < ListNumber.Count; i++)
                            {
                                Sum += ListNumber[i];
                                if (ListNumber[i] > LargerNumber)
                                    LargerNumber = ListNumber[i];
                            }
                            Console.WriteLine($"The Smaller Number Is : {LargerNumber}\n");
                        }
                        else
                        {
                            Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
                        }
                    }
                }

                else if (EnterCharacter == 'F')
                {
                    Console.Write("Found Number Is : ");
                    int FoundNumber = int.Parse(Console.ReadLine());
                    if (ListNumber.Count > 0)
                    {
                        bool IsFound = false;
                        for (int i = 0; i < ListNumber.Count; i++)
                        {
                            if (ListNumber[i] == FoundNumber)
                            {
                                Console.WriteLine($"The Number Is Available : {FoundNumber}\n");
                                IsFound = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("List Is Empty, Number Does Not Exist\n"); 
                    }
                }
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Happy Ending Goodbye");
            Console.WriteLine("===============================================");
        }
    }
}
