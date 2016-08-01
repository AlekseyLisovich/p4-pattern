using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistCauldron
{
    class AdditionallyCauldronStrategy : ICauldronStrategy
    {
        public Formula Action(ElementsList elemList, List<Formula> formula)
        {
            var foundFormula = formula.FirstOrDefault(f =>
            {
                return elemList.GetCount() == f.Elements.Count() && elemList.Elements.Any(e => f.Elements.Contains(e.Value));
            });

            if (foundFormula != null)
                return foundFormula;
            else
                return null;          
        }
    }
}

