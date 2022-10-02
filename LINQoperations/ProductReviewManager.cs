using System;
using System.Collections.Generic;
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
            products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 18, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 17, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 9, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 11, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 15, isLike = true });
            products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 6, isLike = false });
            products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 19, isLike = true });
            products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 7, isLike = false });
            products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 20, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 15, isLike = true });
            DisplayRecords(products);
        }
        public static void DisplayRecords(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
