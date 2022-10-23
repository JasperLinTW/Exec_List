using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//宣告一個 List<Product> 變數, 存放多筆購買商品
			List<Product> products = new List<Product>();
			Product product1 = new Product { Name = "Jasper", Description = "fat man"};
			Product product2 = new Product();
			Product product3 = new Product();
			Product product4 = new Product();
			products.Add(product1);
			products.Add(product2);
			products.Add(product3);
			products.Add(product4);
			products.Add(new Product {Name = "vivian" });//不一定要用變數名稱去裝，可以直接新增進List裡面
		

		}
	}
	class Product
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int productID { get; set; }
		public int price { get; set; }
	}
}
