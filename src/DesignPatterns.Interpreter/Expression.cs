using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    public abstract class Expression {

        public abstract string One { get; }
        public abstract string Four { get; }
        public abstract string Five { get; }
        public abstract string Nine { get; }
        public abstract int Multiplier { get; }

        public void Interpret(Context context) {
            // null checks
            if (context.Input.Length == 0) return;

            if (context.Input.StartsWith(Nine)) {
                context.Output += (9 * Multiplier);
                context.Input = context.Input.Substring(2);
            } else if (context.Input.StartsWith(Four)) {
                context.Output += (4 * Multiplier);
                context.Input = context.Input.Substring(2);
            } else if (context.Input.StartsWith(Five)) {
                context.Output += (5 * Multiplier);
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One)) {
                context.Output += (1 * Multiplier);
                context.Input = context.Input.Substring(1);
            }
        }

    }
}
