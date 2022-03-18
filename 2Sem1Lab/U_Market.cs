using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    class U_Market
    {
        Dictionary<string, List<IThing>> Things { get; set; } = new Dictionary<string, List<IThing>>();
        public Cart<IFood> FoodCart { get; } = new Cart<IFood>();

        public void AddGoodToCart(string goodName, int count)
        {
            for (int i = 0; i < count; i++)
                FoodCart.Foodstuffs.Add((IFood)GetGoodByName(goodName));
        }

        public void AddGood(string goodName, int count)
        {
            try
            {
                for (int i = 0; i < count; i++)
                    Things[goodName].Add(GetGoodByName(goodName));
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Такого товара нет");
            }
        }

        private IThing GetGoodByName(string name)
        {
            switch (name)
            {
                case "Pen":
                    return new Pen();
                case "Notebook":
                    return new Notebook();
                case "Chicken":
                    return new Chicken();
                case "Fruit":
                    return new Fruit();
                case "OliveOil":
                    return new OliveOil();
                case "Cheburek":
                    return new Cheburek();
                case "DumplingsBerries":
                    return new DumplingsBerries();
                case "DumplingsMeat":
                    return new DumplingsMeat();
                case "BalykCheese":
                    return new BalykCheese();
                case "ChocolateBar":
                    return new ChocolateBar();
                case "Crisps":
                    return new Crisps();
                default:
                    throw new KeyNotFoundException("Такого товара нет");
            }
        }

        public U_Market()
        {
            string[] allGoods = new string[]
            {
                "Pen",
                "Notebook",
                "Chicken",
                "Fruit",
                "OliveOil",
                "Cheburek",
                "DumplingsBerries",
                "DumplingsMeat",
                "BalykCheese",
                "ChocolateBar",
                "Crisps",
            };
            foreach (var good in allGoods)
                Things.Add(good, new List<IThing>());
        }
    }
}
