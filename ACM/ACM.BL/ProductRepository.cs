﻿namespace ACM.BL {
    public class ProductRepository
    {
        public Product Retrieve(int productId) {
            Product product = new Product(productId);
            if (productId == 2) {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product) {
            // Code that saves the passed in Product
            return true;
        }
    }
}