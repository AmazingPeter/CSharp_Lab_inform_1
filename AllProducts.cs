using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_1
{
    class AllProducts
    {
        public string name;
        public int price;
        public Group group;

        public AllProducts()
        {
            name = "";
            price = 0;
            group = new Group();
        }

        public AllProducts(string Name,int Price,Group Group)
        {
            name = Name;
            price = Price;
            group = Group;
        }
    }
}