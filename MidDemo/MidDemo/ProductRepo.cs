using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidDemo.Models;

namespace MidDemo
{
    public class ProductRepo
    {
        public int AddProduct(ProductModel model)
        {
            using (var context = new ecomEntities())
            {
                product s = new product();

                s.name = model.name;
                s.expiredate = model.expiredate;
                s.price = model.price;
                s.quantity = model.quantity;
                s.descr = model.descr;
                s.employee = model.employee;

                context.product.Add(s);
                context.SaveChanges();

                return s.pid;
            }
        }
        //
        public List<ProductModel> GetAllData()
        {
            using (var context = new ecomEntities())
            {
                var result = context.product.Select(x => new ProductModel()
                {
                    pid = x.pid,
                    name = x.name,
                    expiredate = x.expiredate,
                    price = x.price,
                    quantity = x.quantity,
                    descr = x.descr
                }
                ).ToList();
                return result;

            }
        }

        public ProductModel GetDetails(int id)
        {
            using (var context = new ecomEntities())
            {
                var result = context.product.Where(x => x.pid == id).Select(x => new ProductModel()
                {
                    pid = x.pid,
                    name = x.name,
                    expiredate = x.expiredate,
                    price = x.price,
                    quantity = x.quantity,
                    descr = x.descr,
                }
                ).FirstOrDefault();

                return result;
            }
        }


        public bool UpdateData(int id, ProductModel model)
        {
            using (var context = new ecomEntities())
            {
                var product = context.product.FirstOrDefault(x => x.pid == id);
                if (product != null)
                {
                    product.name = model.name;
                    product.expiredate = model.expiredate;
                    product.price = model.price;
                    product.quantity = model.quantity;
                    product.descr = model.descr;
                }
                context.SaveChanges();

                return true;
            }
        }

        public bool DeleteData(int id)
        {
            using (var context = new ecomEntities())
            {
                var product = context.product.FirstOrDefault(x => x.pid == id);
                if (product != null)
                {
                    context.product.Remove(product);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

    }
}