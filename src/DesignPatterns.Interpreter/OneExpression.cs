using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    public class OneExpression : Expression {

        public override string Five { get { return "V"; } }

        public override string Four { get { return "IV"; } }

        public override int Multiplier { get { return 1; } }

        public override string Nine { get { return "IX"; } }

        public override string One { get { return "I"; } }

    }
}
