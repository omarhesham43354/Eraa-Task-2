using System.Drawing;

namespace Eraa_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            int n;
            List<int> mylist = new List<int>();
            char litt;
            
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("P - Print Numbers");
                Console.WriteLine("A - Add a Number");
                Console.WriteLine("M - Display mean of The Number");
                Console.WriteLine("S - Display The Smallest Number");
                Console.WriteLine("L - Display The Largest Number");
                Console.WriteLine("F - Find a Number in The List");
                Console.WriteLine("C - Clear The List");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter your choise: ");

                

                 litt = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                switch (litt)
                {
                    case 'P':
                        if (mylist.Count == 0)
                        {
                            Console.WriteLine("My List is Emoty");
                        }
                        else
                        {
                            for (int i = 0; i < mylist.Count; i++)
                            {
                                Console.WriteLine($"{mylist[i]}");
                            }
                        }
                        break;
                    case 'A':
                        Console.WriteLine("Enter your Number integer to add");
                         n = Convert.ToInt32(Console.ReadLine());
                        mylist.Add(n);
                        break;
                    case 'M':
                        int sum = 0;
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            sum += mylist[i];
                        }
                        Console.WriteLine($"Mean: {sum/mylist.Count}");
                        break;
                    case 'S':
                        int small = mylist[0];
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            if (mylist[i] < small)
                            {
                                small = mylist[i];
                            }
                        }
                        Console.WriteLine($"Small Number is {small}");
                        break;
                    case 'L':
                        int Larg = mylist[0];
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            if (mylist[i] > Larg)
                            {
                                Larg = mylist[i];
                            }
                        }
                        Console.WriteLine($"Larg Number is {Larg}");
                        break;
                    case 'F':
                        Console.WriteLine("Enter a Number your Find: ");
                        int find = Convert.ToInt32(Console.ReadLine());
                        int index = mylist.IndexOf(find);
                        if (index != -1)
                        {
                            Console.WriteLine($"your Number in index {index}");
                        }
                        else
                        {
                            Console.WriteLine("The number does not exist");
                        }
                        break;
                    case 'C':
                        mylist.Clear();
                        Console.WriteLine("List Cleared");
                        break;
                    case 'Z':
                        int su = 0;
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            if (mylist[i] % 2 != 0)
                            {
                                su += mylist[i];
                            }
                        }
                        Console.WriteLine(su);
                        break;
                        
                    case 'Q':
                        break;

                    default:
                        Console.WriteLine("Invalid Charactar tay again");
                        break;



                }

            } while (litt != 'Q');


























        }

    }
}
