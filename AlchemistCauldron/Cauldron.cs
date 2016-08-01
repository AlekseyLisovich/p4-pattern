using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlchemistCauldron
{
    public class Cauldron : IEnumerable
    {
        List<Formula> formulas = new List<Formula>();

        private ICauldronStrategy _calstrategy;

        public void AddElements()
        {
            formulas.Add(new Formula(new string[] { "fire", "water" }, "firewater"));
            formulas.Add(new Formula(new string[] { "air", "earth" }, "dust"));
            formulas.Add(new Formula(new string[] { "air", "water" }, "steam"));
            formulas.Add(new Formula(new string[] { "fire", "dust" }, "ash"));
            formulas.Add(new Formula(new string[] { "swamp", "energy" }, "plasma"));
            formulas.Add(new Formula(new string[] { "fire", "earth", "water" }, "stone"));
            formulas.Add(new Formula(new string[] { "air", "energy" }, "storm"));
            formulas.Add(new Formula(new string[] { "earth", "water", "swamp", "energy" }, "bacterium"));
            formulas.Add(new Formula(new string[] { "swamp", "energy", "stone" }, "egg"));
            formulas.Add(new Formula(new string[] { "fire", "dust", "life" }, "ghost"));
            formulas.Add(new Formula(new string[] { "fire", "stone" }, "metal"));
            formulas.Add(new Formula(new string[] { "air", "stone" }, "sand"));
            formulas.Add(new Formula(new string[] { "water", "life" }, "grass"));
            formulas.Add(new Formula(new string[] { "air", "swamp", "energy", "stone" }, "bird"));
            formulas.Add(new Formula(new string[] { "sourcream", "milk", "life" }, "cat"));
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Formula formula in formulas)
                yield return formula;
        }

        public Cauldron(ICauldronStrategy strategy)
        {
            _calstrategy = strategy;
        }

        public void SetStrategy(ICauldronStrategy strategy)
        {
            _calstrategy = strategy;
        }

        public string ExecuteAlgorithm(ElementsList elemList)
        {
            var formula = _calstrategy.Action(elemList, formulas);

            if (formula != null)
                return formula.Result;
            else
                throw new Exception("Array is empty");
        }
    }
}