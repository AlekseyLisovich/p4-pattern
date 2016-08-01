using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlchemistCauldron
{
    public class ElementsList : IEnumerable
    {
        List<Element> elements = new List<Element>();

        public List<Element> Elements
        {
            get
            {
                return elements;
            }
        }

        public void AddElement(Element elem)
        {
            elements.Add(elem);
        }

        public void AddElementTo(ElementsList elemList, int index)
        {
            elements.Add(elemList.GetElement(index));
        }

        public void DeleteElement(int index)
        {
            elements.Remove(elements[index]);
        }

        public Element GetElement(int index)
        {
            return elements[index];
        }

        public int GetCount()
        {
            return elements.Count;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Element element in elements)
                yield return element;
        }
    }
}