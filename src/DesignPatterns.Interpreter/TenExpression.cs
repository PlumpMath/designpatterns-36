using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    public class TenExpression : Expression {
        public override string Five { get { return "L"; } }

        public override string Four { get { return "XL"; } }

        public override int Multiplier { get { return 10; } }

        public override string Nine { get { return "XC"; } }

        public override string One { get { return "X"; } }

    }
}
