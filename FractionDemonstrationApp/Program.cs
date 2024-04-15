using FractionLibrary;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace FractionDemonstrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please select what u want to do : ");
                Console.WriteLine("Press 1 to add fractions : ");
                Console.WriteLine("Press 2 to Subtract fractions : ");
                Console.WriteLine("Press 3 to Multiply fractions : ");
                Console.WriteLine("Press 4 to Divide fractions : ");
                Console.WriteLine("Press 5 to Switch fractions : ");
                Console.WriteLine("Press 6 to Invert fractions : ");
                Console.WriteLine("Press 7 to simplefy a fraction: ");
                int choise = Convert.ToInt32(Console.ReadLine());

                if (choise > 0 && choise <=7 ) { 
                Console.Write("Numerator : ");
                int Numerator1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Denumerator : ");
                int Denumerator1 = Convert.ToInt32(Console.ReadLine());
                Fraction fraction1 = new Fraction(Numerator1, Denumerator1);
                    if (choise >= 5)
                    {
                        switch (choise)
                        {
                            case 5:
                                Console.WriteLine(fraction1.ReciProcal());
                                break;
                            case 6:
                                Console.WriteLine(fraction1.Invert());
                                break;
                            case 7:
                                Console.WriteLine(fraction1.Simplify());
                                break;
                            default:
                                break;
                        }
                    }
                    else if (choise <= 4)
                    {
                        Console.Write("Numerator2 : ");
                        int Numerator2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Denumerator2 : ");
                        int Denumerator2 = Convert.ToInt32(Console.ReadLine());
                        Fraction fraction2 = new Fraction(Numerator2, Denumerator2);
                        switch (choise)
                        {
                            case 1:
                                Console.Write(Numerator1 + "/" + Denumerator1 + " + " + Numerator2 + "/" + Denumerator2 + " = ");
                                Console.WriteLine(fraction1.Add(fraction2).Result());
                                break;
                            case 2:
                                Console.Write(Numerator1 + "/" + Denumerator1 + " - " + Numerator2 + "/" + Denumerator2 + " = ");
                                Console.WriteLine(fraction1.Subtract(fraction2));
                                break;
                            case 3:
                                Console.Write(Numerator1 + "/" + Denumerator1 + " * " + Numerator2 + "/" + Denumerator2 + " = ");
                                Console.WriteLine(fraction1.Multiply(fraction2));
                                break;
                            case 4:
                                Console.Write(Numerator1 + "/" + Denumerator1 + " / " + Numerator2 + "/" + Denumerator2 + " = ");
                                Console.WriteLine(fraction1.Divide(fraction2));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}