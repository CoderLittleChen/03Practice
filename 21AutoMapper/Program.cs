using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //3、关于AutoMapper
            //DTO（Data Transfer Object）	数据传输对象 是面向UI的需求而设计的，不包含任何的业务逻辑
            //属于瘦身型的对象 

            //AutoMapper可以使用静态方法和实例方法来创建映射
            Product product = new Product { Id = 1, Name = "蛋糕", Price = 20 };
            //静态方法  实现映射
            //Mapper.Initialize(x => x.CreateMap<Product, ProductDto>());
            //var productDto = Mapper.Map<ProductDto>(product);

            //实例方法
            MapperConfiguration configuration = new MapperConfiguration(x => x.CreateMap<Product, ProductDto>());
            var mapper = configuration.CreateMapper();
            var productDto = Mapper.Map<ProductDto>(product);

            Console.WriteLine(productDto.Name);
            Console.WriteLine(productDto.Price);
            Console.ReadKey();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
