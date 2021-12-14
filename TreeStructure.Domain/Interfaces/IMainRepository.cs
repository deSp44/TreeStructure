using System.Linq;
using TreeStructure.Domain.Models;

namespace TreeStructure.Domain.Interfaces
{
    public interface IMainRepository
    {
        IQueryable<NodeElement> GetAllElements();
        void AddNewElement(NodeElement element);
        bool DeleteElement(int elementId);
        bool EditElement(int elementId, string newname);
        bool ChangeNode(int nodeId, int? nodeParentId);
    }
}
