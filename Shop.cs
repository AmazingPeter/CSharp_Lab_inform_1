using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_1
{
    //без отлавливания ошибок
    class Shop
    {
        public string address;
        public int countProducts;
        public List<Product> products;

        public void Add(List<AllProducts> AP,List<Group> groups,string name,int price,string nameGroup,int countProducts)//привести товары
        {
            bool error = true;
            Group group = new Group();

            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i].name == nameGroup)
                {
                    error = false;
                    group = groups[i];
                }
            }
            if (error)
            {
                groups.Add(new Group(nameGroup));
                group = groups[groups.Count - 1];
            }

            error = true;
            AllProducts product = new AllProducts();

            for (int i = 0; i < AP.Count; i++)
            {
                if (AP[i].name == name)
                {
                    error = false;
                    product = AP[i];
                }
            }
            if (error)
            {
                AP.Add(new AllProducts(name, price, group));
                product = AP[AP.Count - 1];
            }

            error = true;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].product == product)
                {
                    error = false;
                    products[i].count += countProducts;
                }
            }
            if (error)
            {
                products.Add(new Product(product,countProducts));
            }
            countProducts++;
        }
        public void ToSell(Product product,int count)//продать товары
        {
            countProducts-=count;
            for (int i = 0; i < products.Count;i++)
                if(products[i] == product)
                    products[i].count -= count;
        }
        public string GetListGroup(Group group)
        {
            string s = "";
            for (int i = 0; i < products.Count; i++)
                if (products[i].product.group == group)
                    s += products[i].product.name + "\n";

            return s;
        }

    }
}
