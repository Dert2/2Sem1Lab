using System;
using System.Collections.Generic;

namespace _2Sem1Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandMessage = "";
            U_Market market = new U_Market();

            bool correctCommand = true;
            while (correctCommand)
            {
                if (commandMessage.Length != 0)
                    Console.WriteLine(commandMessage);
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Добавить товар в корзину -- добавить");
                Console.WriteLine("2) Очистить корзину -- очистить");
                Console.WriteLine("3) Сбалансировать корзину -- сбалансировать");
                Console.WriteLine("4) Показать товары в корзине -- показать");
                Console.Write("\r\nВыберите действие: ");
                commandMessage = "";

                string input = Console.ReadLine();

                if (input == "добавить")
                {
                    Console.Write("Напишите название товара: ");
                    string goodName = Console.ReadLine();
                    Console.Write("Напишите кол-во: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        market.AddGoodToCart(goodName, count);
                    }
                    catch (KeyNotFoundException k)
                    {
                        commandMessage = k.Message;
                    }
                    correctCommand = true;
                    continue;
                }
                else if (input == "очистить")
                {
                    market.FoodCart.Foodstuffs.Clear();
                    correctCommand = true;
                    continue;
                }
                else if (input == "сбалансировать")
                {
                    market.FoodCart.CartBalansing();
                    correctCommand = true;
                    continue;
                }
                else if (input == "показать")
                {
                    commandMessage = market.FoodCart.Show();
                    correctCommand = true;
                    continue;
                }
                else
                {
                    correctCommand = false;
                    continue;
                }
            }
        }
    }
}
