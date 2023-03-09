using ConsoleApp2.DB;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        private static GoodsContext _ef;
       private static void Main(string[] args)
        {
            _ef = new GoodsContext();

            _ef.Database.Migrate();

            Console.WriteLine($"Connected to db : {_ef.Database.CanConnect()}");

            foreach (var item in _ef.Categories.ToList())
            {
                Console.WriteLine(item.Name);
            }

            var find_category = _ef.Categories.FirstOrDefault(
                x => x.Name == "Снэки");
            if (find_category == null)
                find_category = new Category() { Name = "Снэки" };
            foreach (var item in _ef.Goods.ToList())
            {
                double total_sale = item.Price - item.Sale;
                Console.WriteLine($"{item.Name}" + $"Стоимость итоговая :{total_sale}");
            }

            //Good good = new Good()
            //{
            //    Name = "Чипсы",
            //    Price = 199.0,
            //    Sale = 0.50,
            //    Category = find_category
            //};
        }
    }
}