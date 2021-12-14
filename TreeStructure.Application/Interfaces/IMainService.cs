using System.Collections.Generic;
using TreeStructure.Domain.Models;

namespace TreeStructure.Application.Interfaces
{
    public interface IMainService
    {
        IEnumerable<NodeElement> GetAllElements();
        void AddNewElement(NodeElement element);
        bool DeleteElement(int elementId);
        bool EditElement(int elementId, string newname);
        bool ChangeNode(int nodeId, int? nodeParentId);
    }
}
