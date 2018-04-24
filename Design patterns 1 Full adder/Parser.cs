using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_1_Full_adder
{
    public class Parser
    {
        private NodeFactory _nodeFactory;
        public Parser(NodeFactory nodeFactory)
        {
            _nodeFactory = nodeFactory;
        }
        public void ReadFile()
        {

        }
    }
}
