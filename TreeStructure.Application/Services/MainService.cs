using System.Collections.Generic;
using TreeStructure.Application.Helpers;
using TreeStructure.Application.Interfaces;
using TreeStructure.Domain.Interfaces;
using TreeStructure.Domain.Models;

namespace TreeStructure.Application.Services
{
    public class MainService : IMainService
    {
        private readonly IMainRepository _mainRepository;

        public MainService(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        public IEnumerable<NodeElement> GetAllElements()
        {
            var nodeElementsFromDatabase = _mainRepository.GetAllElements();
            var tree = nodeElementsFromDatabase.BuildTree();

            return tree;
        }

        public void AddNewElement(NodeElement element)
        {
            _mainRepository.AddNewElement(element);
        }

        public bool DeleteElement(int elementId)
        {
            var isSucceded = _mainRepository.DeleteElement(elementId);
            return isSucceded;
        }

        public bool EditElement(int elementId, string newname)
        {
            var isSucceded = _mainRepository.EditElement(elementId, newname);
            return isSucceded;
        }

        public bool ChangeNode(int nodeId, int? nodeParentId)
        {
            var isSucceded = _mainRepository.ChangeNode(nodeId, nodeParentId);
            return isSucceded;
        }
    }
}
