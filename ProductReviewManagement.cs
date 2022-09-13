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
    }
}
