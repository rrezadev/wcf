using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RR_WCF_NW_11072019
{

    public class ServiceNorthwindProducts : INorthwind
    {
        public Product GetProduct(int id)
        {
            // TODO: retrieve the real product info from DB using EF
            /*
            Product product = new Product();
            product.ProductID = id;
            product.ProductName = "fake product name";
            product.UnitPrice = (decimal)10.0;
                */

            NorthwindEntities context = new NorthwindEntities();
            var productEntity = (from p
                                in context.ProductEntities
                                 where p.ProductID == id
                                 select p).FirstOrDefault();

            if (productEntity != null)
                return TranslateProductEntityToProduct(productEntity);
            else
                throw new Exception("Invalid product id");
        }

        private Product TranslateProductEntityToProduct(
            ProductEntity productEntity)
        {
            Product product = new Product();

            product.ProductID = productEntity.ProductID;
            product.ProductName = productEntity.ProductName;
            product.QuantityPerUnit = productEntity.QuantityPerUnit;
            product.UnitPrice = (decimal)productEntity.UnitPrice;
            product.Discontinued = productEntity.Discontinued;

            return product;
        }

    }

}
