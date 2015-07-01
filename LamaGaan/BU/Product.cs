﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Product
    {
        public static Product GetHoeveelheidProduct(int HuidigeVoorraad)
        {
            Product product = new Product();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Product> HoeveelheidQuery =
                    from p in //....
                    where p.Id == Id
                    select p;
                
                    foreach (product p in HoeveelheidQuery)
                    {
                        if (p != null)
                        {
                            product = p;
                        }
                    }

            }
            return product;
        }
    }
}