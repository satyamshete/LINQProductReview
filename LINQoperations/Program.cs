﻿using System.Collections.Generic;

namespace LINQoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management!!!!!!!!");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option" +
                              "\n1.Add Values to list"+ "\n2.Retrieve Top 3 Records By Rating" + "\n3.Retrieve Records Based On Rating and Product Id" );
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review 
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
                case 2:
                    ProductReviewManager.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                default:
                    Console.WriteLine("Enter proper selection");
                    break;
            }
        }
    }
}