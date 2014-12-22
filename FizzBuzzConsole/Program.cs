using System;
using System.Collections.Generic;
using Core;

namespace DisplayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Token> tokens = new List<Token>()
            {
                new Token(){Denominator = 3, Name = "Fizz"},
                new Token(){Denominator = 4, Name = "Fazz"},
                new Token(){Denominator = 5, Name = "Buzz"}
            };

            Analyzer analyzer = new Analyzer(tokens);
            
            for (int i = 1; i <= 100; i++ )
            {
                Console.WriteLine(analyzer.Analyze(i));
            }

             Console.ReadKey();
        }
    }
}
