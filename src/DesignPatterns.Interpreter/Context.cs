using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter {
    public class Context {

        public string Input { get; internal set; }
        public int Output { get; internal set; }

        public Context(string input) {
            this.Input = input;
        }

    }
}
