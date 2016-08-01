using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistCauldron
{
    class Program
    {
        static void Main(string[] args)
        {
            Cauldron cauldron = new Cauldron(new MainCauldronStrategy());
            ElementsList elements = new ElementsList();
            ElementsList formulas = new ElementsList();

            string cauldronResult = "";

            cauldron.AddElements();
            SetElements(elements);

            do
            {
                ChooseElements(elements, formulas, "Elements");

                ChooseElements(formulas, elements, "Formulas");

                Console.Clear();
                try
                {
                    cauldronResult = cauldron.ExecuteAlgorithm(formulas);
                    Console.WriteLine("After mixing => {0}", cauldronResult);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();

            } while (true);
        }

        public static void ShowElements(ElementsList elemList, string tableName)
        {
            Console.Clear();
            Console.WriteLine(" -------" + tableName + "-------");
            foreach (Element e in elemList)
            {
                Console.WriteLine("  Value: {0}, Index: {1}", e.Value, e.Index);
            }
        }

        public static void ChooseElements(ElementsList elemList, ElementsList formula, string tName)
        {
            ShowElements(elemList, tName);
            int y = 0;
            bool exit = false;
            if (elemList.GetCount() != 0)
            {
                do
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            y--;
                            break;
                        case ConsoleKey.DownArrow:
                            y++;
                            break;
                        case ConsoleKey.Enter:
                            formula.AddElementTo(elemList, y - 1);
                            elemList.DeleteElement(y - 1);
                            ShowElements(elemList, tName);
                            break;
                        case ConsoleKey.End:
                            exit = true;
                            break;
                    }

                    if (y < 1)
                        y = 1;
                    if (y >= elemList.GetCount())
                        y = elemList.GetCount();

                    Console.SetCursorPosition(0, y);
                    Console.Write((char)16);
                    if (y > 0)
                    {
                        Console.SetCursorPosition(0, y - 1);
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, y + 1);
                    Console.Write(" ");

                } while (!exit);
            }
        }

        public static void SetElements(ElementsList elements)
        {
            elements.AddElement(new Element("fire", 1));
            elements.AddElement(new Element("water", 2));
            elements.AddElement(new Element("earth", 3));
            elements.AddElement(new Element("air", 4));
            elements.AddElement(new Element("dust", 5));
            elements.AddElement(new Element("swamp", 6));
            elements.AddElement(new Element("energy", 7));
            elements.AddElement(new Element("stone", 8));
            elements.AddElement(new Element("life", 9));
            elements.AddElement(new Element("milk", 10));
            elements.AddElement(new Element("sourcream", 11));
        }
    }
}