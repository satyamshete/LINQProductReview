﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQoperations
{
    internal class ProductReviewManager
    {
        /// UC1-Adding Product Detail in a list
        public static void AddingProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 4, isLike = true });
            //DisplayRecords(products);
        }
        public static void DisplayRecords(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
        /// UC2--Retrieve Top Three Records Whose Rating is High
        public static void RetrieveTopThreeRating(List<ProductReview> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\n-------------Retrieving Top Three Records Based On Rating--------------");
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            DisplayRecords(res);
        }
        /// UC3--Retrieve  records from list based on productid and rating > 3  
        public static void RetrieveRecordsBasedOnRatingAndProductId(List<ProductReview> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\n-----------Retrieve Records Based On Rating and Product Id-----------");
            var res = (from product in products where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product).ToList();
            DisplayRecords(res);
        }
        ///  UC4--Retrived the count of productId
        public static void CountingProductId(List<ProductReview> products)
        {
            AddingProductReview(products);
            var data = products.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count() });
            Console.WriteLine(data);
            foreach (var ele in data)
            {
                Console.WriteLine("ProductId " + ele.ProductId + " " + "Count " + " " + ele.count);
            }
        }
        /// UC5---Retrieving the product id in list
        public static void RetrieveOnlyProductIdAndReviews(List<ProductReview> products)
        {
            AddingProductReview(products);
            var res = products.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var ele in res)
            {
                Console.WriteLine("ProductId " + ele.ProductId + " " + "Review " + " " + ele.Review);
            }
        }
        /// UC6--Skip Top five records
        public static void SkipTopFiveRecords(List<ProductReview> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\n----------Skip Top Five records in list");
            var res = (from product in products orderby product.rating descending select product).Skip(5).ToList();
            DisplayRecords(res);
        }
        /// UC8-->Using DataTable 
        public static void CreateDataTable(List<ProductReview> products)
        {
            AddingProductReview(products);
            DataTable dt = new DataTable();
            dt.Columns.Add("productId");
            dt.Columns.Add("userId");
            dt.Columns.Add("rating");
            dt.Columns.Add("review");
            dt.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                dt.Rows.Add(data.productId, data.userId, data.rating, data.review, data.isLike);
            }
            DisplayTable(dt);
        }
        public static void DisplayTable(DataTable table)
        {
            foreach (DataRow p in table.Rows)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }
    }
}
