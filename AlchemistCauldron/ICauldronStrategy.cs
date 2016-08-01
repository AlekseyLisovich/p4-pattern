using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistCauldron
{
    public interface ICauldronStrategy
    {
        Formula Action(ElementsList elemList, List<Formula> formula);
    }
}
