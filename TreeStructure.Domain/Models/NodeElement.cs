using System.Collections.Generic;

namespace TreeStructure.Domain.Models
{
    public class NodeElement
    {
        public NodeElement()
        {
            nodeElements = new HashSet<NodeElement>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int? parentId { get; set; }
        public virtual ICollection<NodeElement> nodeElements { get; set; }
    }
}
