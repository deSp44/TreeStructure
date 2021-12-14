using System;
using System.Collections.Generic;
using System.Linq;
using TreeStructure.Domain.Models;

namespace TreeStructure.Application.Helpers
{
    public static class GroupExtensionMethod
    {
        public static IList<NodeElement> BuildTree(this IEnumerable<NodeElement> source)
        {
            var groups = source.GroupBy(i => i.parentId);
            var roots = new List<NodeElement>();
            try
            {
                roots = groups.FirstOrDefault(x => x.Key.HasValue == false).ToList();

                if (roots.Count > 0)
                {
                    var dict = groups.Where(g => g.Key.HasValue).ToDictionary(g => g.Key.Value, g => g.ToList());

                    foreach (var item in roots)
                        AddChildren(item, dict);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return roots;

        }

        private static void AddChildren(NodeElement node, IDictionary<int, List<NodeElement>> source)
        {
            if (source.ContainsKey(node.id))
            {
                node.nodeElements = source[node.id];
                for (var i = 0; i < node.nodeElements.Count; i++)
                    AddChildren(node.nodeElements.ElementAt(i), source);
            }
            else
            {
                node.nodeElements = new List<NodeElement>();
            }
        }
    }
}
