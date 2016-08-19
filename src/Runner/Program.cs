using DesignPatterns.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner {
    class Program {
        /// <summary>
        /// Just a tester app to run design patterns.
        /// </summary>
        static void Main(string[] args) {
            new Program().Interpreter();
        }

        void Interpreter() {
            // convert roman numerics to decimal
            string roman = "MCMXXVIII";

            // create the global interpreter context
            Context context = new Context(roman);

            // build the parse tree
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // interpret
            foreach (Expression e in tree) {
                e.Interpret(context);
            }

            // debug
            Console.WriteLine("{0} = {1}", roman, context.Output);
        }
    }
}
