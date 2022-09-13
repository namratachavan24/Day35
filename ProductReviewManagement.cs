using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    public class ProductReviewManagement
    {
        public static void RetriveTo3ReviewBasedOnTheHighestRating(List<ProductReview> list)
        {
            Console.WriteLine("\nSorted Order");
            List<ProductReview> sortedList = (from product in list orderby product.Rating descending select product).ToList();
            Program.IterateOverProductReview(sortedList);
            Console.WriteLine("\nRetriveint To 3Review Based On The Highest Rating");
            List<ProductReview> top4res = sortedList.Take(3).ToList();
            Program.IterateOverProductReview(top4res);


        }
        //UC3
        public static void RetriveBasedOnProductIdAndRatig(List<ProductReview> list)
        {
            Console.WriteLine("\nretriving the productid and rating");
            var res1 = (from p in list where p.Rating > 3 && (p.ProductId.Equals(1) || p.ProductId.Equals(4) || p.ProductId.Equals(9)) select p).ToList();
            Program.IterateOverProductReview(res1);
        }
        public static void CountEachProductID(List<ProductReview> list)
        {//uc4
            Console.WriteLine("\nretriving the count of the product id");
            var CountOfProductId = (list.GroupBy(p => p.ProductId).Select(product => new { productId = product.Key, ncount = product.Count() })).ToList();
            foreach (var product in CountOfProductId)
            {
                Console.WriteLine("ProductId:{0} Count: {1}", product.productId, product.ncount);
            }
        }
        //uc5
        public static void RetriveProductIDAndRevies(List<ProductReview> list)
        {
            Console.WriteLine("\nRetriving the productId and review");
            var res = (list.Select(product => new { productID = product.ProductId, review = product.Review })).ToList();
            foreach (var product in res)
            {
                Console.WriteLine("ProductId:{0} Review: {1}", product.productID, product.review);
            }
        }
        //uc6
        public static void SkipTop5DataRetriveRemaining(List<ProductReview> list)
        {
            Console.WriteLine("\nSkip the Top 5 Records display remaing records");
            List<ProductReview> AfterskipRecords = list.Skip(5).ToList();
            Program.IterateOverProductReview(AfterskipRecords);
        }
    }
}
