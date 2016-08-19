using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    public class HundredExpression : Expression {

        public override string Five { get { return "D"; } }

        public override string Four { get { return "CD"; } }

        public override string Nine { get { return "CM"; } }

        public override string One { get { return "C"; } }

        public override int Multiplier { get { return 100; } }
    }
}
