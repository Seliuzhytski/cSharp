using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HW_14
{
    internal class Shop
    {
        List<Good> shopGoods = new List<Good>();
        private string salerName;

        public string SalerName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Нет продавца!!!");
                }
                else
                    salerName = value;
            }
            get => SalerName;
        }

        public string Name { get; set; }

        public Shop(string name, string salerName)
        {
            this.Name = name;
            this.SalerName = salerName;
        }

        public void ShowGoods()
        {
            Console.WriteLine("Товары магазина:");
            foreach (Good good in shopGoods)
            {
                Console.WriteLine($"Товар: {good.Name}, цена: {good.Price} BYN");
            }
        }

        public void AddGood(Good good)
        {
            if (shopGoods.Contains(good))
            {
                throw new Exception($"Товар \"{good.Name}\" уже есть в магазине!\n");
            }
            shopGoods.Add(good);
        }

        public void SaleGood(Good good, double cash)
        {
            if (good.Price > cash)
            {
                throw new Exception($"У покупателя не хватает денег на \"{good.Name}\"\n");
            }
            shopGoods.Remove(good);
        }
        public void ClearShop()
        {
            if (shopGoods.Count == 0)
            {
                shopGoods.Clear();
            }
            else
            {
                throw new Exception("Магазин работает!\n");
            }
        }
    }
}
