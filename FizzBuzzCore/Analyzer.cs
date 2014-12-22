using System;
using System.Collections.Generic;

namespace Core
{
    public class Analyzer
    {
        List<Token> tokens;

        public Analyzer(List<Token> tokens)
        {
            this.tokens = tokens;
        }
        
        public string Analyze(int numerator)
        {
            string result = numerator.ToString();
            
            foreach (Token token in tokens)
            {
                if (numerator % token.Denominator == 0)
                {
                    result += token.Name;
                }
            }
            
            return result;
        }
    }
}
