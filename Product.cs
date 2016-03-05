using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_1
{
    class Product
    {
        public AllProducts product;//сам товар
        public int count;//Количество товара

        public Product(AllProducts Product, int Count)
        {
            product = Product;
            count = Count;
        }
    }
}