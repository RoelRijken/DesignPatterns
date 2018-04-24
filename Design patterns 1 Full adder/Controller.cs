using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_1_Full_adder
{
   public class Controller
    {
        private NodeFactory _nodeFactory;
        private Parser _parser;

        public Controller()
        {

            _nodeFactory = new NodeFactory();
            _parser = new Parser(_nodeFactory);
        }
    }
}
