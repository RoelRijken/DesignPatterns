using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_1_Full_adder
{
   public class NodeFactory
    {
        private Dictionary<string, Node> _nodes;

        public Node GetNode(string name)
        {
            if (_nodes.ContainsKey(name))
            {
                return _nodes[name];
            }
            return null;
        }

        public Dictionary<string, Node> GetAll()
        {
            return _nodes;
        }

        public void AddNode(string name, Node node)
        {
            _nodes.Add(name, node);
        }




    }
}
