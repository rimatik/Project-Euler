using System;

namespace PandigitalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var concatProd = "";
            var max = 1;
            for (var i = 199999999;i>=1; i--)
            {
                for (var j = 1;j<=10; j++)
                {
                    var prod = i*j;
                    concatProd += prod;
                    if (concatProd.Length == 9 && concatProd.Contains("1") && concatProd.Contains("2")
                        && concatProd.Contains("3") && concatProd.Contains("4") && concatProd.Contains("5")
                        && concatProd.Contains("6") && concatProd.Contains("7") && concatProd.Contains("8")
                        && concatProd.Contains("9"))
                    {
                        if (int.Parse(concatProd) > max)
                            max = int.Parse(concatProd);
                        concatProd = "";
                    }
                    else if (concatProd.Length > 9)
                    {
                        concatProd = "";
                        break;
                    }
                        
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
