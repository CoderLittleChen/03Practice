using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20集合的方法使用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 查询1
            ////查询Product
            //List<Material> materials = new List<Material>()
            //{
            //    new Material
            //    {
            //        Id=1,
            //        ProductId=1,
            //        MaterialName="石头"
            //    },
            //    new Material
            //    {
            //        Id=2,
            //        ProductId=2,
            //        MaterialName="木头"
            //    },
            //    new Material
            //    {
            //        Id=3,
            //        ProductId=3,
            //        MaterialName="钢筋"
            //    },
            //    new Material
            //    {
            //        Id=4,
            //        ProductId=4,
            //        MaterialName="水泥"
            //    },
            //    new Material
            //    {
            //        Id=5,
            //        ProductId=5,
            //        MaterialName="混凝土"
            //    }
            //};

            ////这里的Find  返回的单个对象  如果查询条件 返回集合  取集合中的第一项
            //Material material = materials.Find(x => x.Id > 3);

            //where返回的是 对象的集合
            //IEnumerable<Material> list = materials.Where(x => x.Id == 4);
            //Console.WriteLine(list.Count());

            //Console.WriteLine(material.MaterialName);
            //Console.ReadKey();
            #endregion

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="牛奶",
                    Price=20,
                    Materials=new List<Material>()
                    {
                        new Material
                        {
                            Id=1,
                            ProductId=1,
                            MaterialName="糖"
                        },
                        new Material
                        {
                            Id=2,
                            ProductId=1,
                            MaterialName="水"
                        }
                    }
                },
                new Product
                {
                    Id=2,
                    Name="啤酒",
                    Price=30,
                    Materials=new List<Material>()
                    {
                        new Material
                        {
                            Id=1,
                            ProductId=2,
                            MaterialName="小麦",
                        },
                        new Material
                        {
                            Id=2,
                            ProductId=2,
                            MaterialName="纯净水"
                        }
                    }
                },
                new Product
                {
                    Id=3,
                    Name="蛋糕",
                    Price=40,
                    Materials=new List<Material>()
                    {
                        new Material
                        {
                            Id=1,
                            ProductId=3,
                            MaterialName="面粉"
                        },
                        new Material
                        {
                            Id=2,
                            ProductId=3,
                            MaterialName="奶油"
                        }
                    }
                }
            };

            //查询指定产品下的所有材料
            //List<Material> materials = products.Find(x > x.Id == 2).Materials.ToList();
            //Console.WriteLine(materials[1].MaterialName);

            //查询指定产品下  指定材料
            //Material material = products.Find(x => x.Id == 3).Materials.ToList().Find(x => x.Id == 2);
            //Console.WriteLine(material.MaterialName);
            //Console.ReadKey();


            //Select关键字的使用  作用是product对象的name属性集合
            List<string> list = products.Select(x => x.Name).ToList();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.ReadKey();
            //下面这种写法  where方法重载  按照要求 参数是name为string类型，num是int类型，返回值是bool类型 
            //如果返回值为true，则该元素会被添加到IEnumerable集合中

            //这里的num表示list集合中的元素的索引  
            //这里的参数 Func<T,bool>  类型，其中T类型取决于list1集合中的对象类型，即=>的前面为参数类型，后面为返回值

            //遍历IEnumerable类型对象不能用 索引器的方式


            //where（）方法  对应参数是Func(Product,bool)，第一个参数是返回值bool  匿名比倒是
            IEnumerable<Product> list1 = products.Where(pro => pro.Id == 1);

            //这里注意
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Console.ReadKey();
        }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Material> Materials { get; set; }
    }

    public class Material
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string MaterialName { get; set; }
    }

}
