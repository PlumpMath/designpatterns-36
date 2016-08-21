using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Codeproject
{
    public class TokenReader
    {
        public IExpression ReadToken(IList<string> tokens)
        {
            return this.ReadNextToken(tokens);
        }

        IExpression ReadNextToken(IList<string> tokens)
        {
            int number;

            if (Int32.TryParse(tokens.First(), out number))
            {
                // token is number
                tokens.RemoveAt(0);
                return new NumberExpression(number);
            }
            else
            {
                // token is nonterminal
                return this.ReadNonTerminal(tokens);
            }
        }

        IExpression ReadNonTerminal(IList<string> tokens)
        {
            // decl
            string token;
            IExpression left;
            IExpression right;

            // inits
            token = tokens.First();
            tokens.RemoveAt(0);
            left = this.ReadNextToken(tokens);
            right = this.ReadNextToken(tokens);

            // check the nonterminal type
            switch (token) {
                case "+":
                    return new AddExpression(left, right);
                case "-":
                    return new SubtractExpression(left, right);
                default:
                    throw new ArgumentOutOfRangeException("Unknown token: " + token);
            }
        }
    }
}
