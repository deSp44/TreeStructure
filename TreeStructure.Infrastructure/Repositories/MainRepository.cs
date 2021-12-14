using System.Linq;
using TreeStructure.Domain.Interfaces;
using TreeStructure.Domain.Models;

namespace TreeStructure.Infrastructure.Repositories
{
    public class MainRepository : IMainRepository
    {
        private readonly Context _context;

        public MainRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<NodeElement> GetAllElements()
        {
            var nodesList = _context.NodeElements;
            return nodesList;
        }

        public void AddNewElement(NodeElement element)
        {
            _context.NodeElements.Add(element);
            _context.SaveChanges();
        }

        public bool DeleteElement(int elementId)
        {
            var element = _context.NodeElements.SingleOrDefault(x => x.id == elementId);
            if (element != null)
            {
                RemoveChildren(element.id);
                _context.NodeElements.Remove(element);
                _context.SaveChanges();
                return true;
            }

            return false;


            void RemoveChildren(int i)
            {
                var children = _context.NodeElements.Where(x => x.parentId == i).ToList();
                foreach (var child in children)
                {
                    RemoveChildren(child.id);
                    _context.NodeElements.Remove(child);
                }
            }
        }

        public bool EditElement(int elementId, string newname)
        {
            var elementToEdit = _context.NodeElements.SingleOrDefault(m => m.id == elementId);
            if (newname != null && elementToEdit != null)
            {
                elementToEdit.name = newname;
                _context.Attach(elementToEdit);
                _context.Update(elementToEdit);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool ChangeNode(int nodeId, int? nodeParentId)
        {
            var elementToEdit = _context.NodeElements.SingleOrDefault(x => x.id == nodeId);
            if (nodeParentId != null && elementToEdit != null)
            {
                elementToEdit.parentId = nodeParentId;
                _context.Attach(elementToEdit);
                _context.Update(elementToEdit);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
