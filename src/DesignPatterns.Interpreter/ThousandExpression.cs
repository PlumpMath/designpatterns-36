using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    /// <summary>
    /// A terminal expression class.
    /// </summary>
    public class ThousandExpression : Expression {

        public override string Five { get { return " "; } }

        public override string Four { get { return " "; } }

        public override string Nine { get { return " "; } }

        public override string One { get { return "M"; } }

        public override int Multiplier { get { return 1000; } }

    }
}
