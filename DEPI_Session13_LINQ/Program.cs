using System;
using ASSLINQ;
using static ASSLINQ.ListGenerators;

namespace DEPI_Session13_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators

            #region 1. Get the first Product out of Stock 

            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine($"First product out of stock: {result?.ProductName ?? "None"}");

            #endregion

            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine($"First product with price > 1000: {result?.ProductName ?? "Not Found"}");

            #endregion

            #region Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion

            #endregion


            #region LINQ - Aggregate Operators

            #region      1. Uses Count to get the number of odd numbers in the array


            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var oddNumbersCount = Arr.Where(n => n % 2 != 0).Count();
            //Console.WriteLine($"Count of odd numbers: {oddNumbersCount}");

            #endregion

            #region Return a list of customers and how many orders each has.
            //var customerOrderCounts = CustomerList.Select(c => new
            //{
            //    CustomerID = c.CustomerID,
            //    OrderCount = c.Orders.Count()
            //});
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, OrderCount: {customer.OrderCount}");
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    });
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"Category: {category.Category}, ProductCount: {category.ProductCount}");
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine($"Total: {total}");

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into an array of String First).

            //var CharactersInFile = File.ReadAllText("dictionary_english.txt");

            //var totalNumberofCharactersInFile = CharactersInFile.Count();
            //Console.WriteLine($"Total number of characters in dictionary_english.txt: {totalNumberofCharactersInFile}");

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt

            //var CharactersInFile = File.ReadAllText("dictionary_english.txt");

            //var ShortestWordLength = CharactersInFile
            //    .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
            //    .Min(w => w.Length);

            //Console.WriteLine(
            //    $"Length of the shortest word in dictionary_english.txt: {ShortestWordLength}");

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt
            //var CharactersInFile = File.ReadAllText("dictionary_english.txt");

            //var LongestWordLength = CharactersInFile
            //    .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
            //    .Max(w => w.Length);

            //Console.WriteLine(
            //    $"Length of the longest word in dictionary_english.txt: {LongestWordLength}");

            #endregion

            #region  8.Get the average length of the words in dictionary_english.txt

            //var CharactersInFile = File.ReadAllText("dictionary_english.txt");

            //var AVGWordLength = CharactersInFile
            //    .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
            //    .Average(w => w.Length);

            //Console.WriteLine(
            //    $"Average length of words in dictionary_english.txt: {AVGWordLength}");

            #endregion

            #region  9. Get the total units in stock for each product category.
            // var categoryStockTotals = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });
            //foreach (var category in categoryStockTotals)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Total Units In Stock: {category.TotalUnitsInStock}");
            //}

            #endregion

            #region 10.Get the cheapest price among each category's products 

            // var categoryCheapestPrices = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });
            //foreach (var category in categoryCheapestPrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Cheapest Price: {category.CheapestPrice}");
            //}
            #endregion

            #region 11. Get the products with the lowest price in each category (Use LET)
            //var categoryLowestPriceProducts = from p in ProductList
            //                                  group p by p.Category into g
            //                                  let lowestPrice = g.Min(x => x.UnitPrice)
            //                                  select new
            //                                  {
            //                                      Category = g.Key,
            //                                      Products = g.Where(x => x.UnitPrice == lowestPrice)

            //                                  };
            //foreach (var category in categoryLowestPriceProducts)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 12. Get the highest price among each category's products
            //var categoryHighestPrices = ProductList
            //     .GroupBy(p => p.Category)
            //     .Select(g => new
            //     {
            //         Category = g.Key,
            //         HighestPrice = g.Max(p => p.UnitPrice)
            //     });
            // foreach (var category in categoryHighestPrices)
            // {
            //     Console.WriteLine($"Category: {category.Category}, Highest Price: {category.HighestPrice}");
            //}
            #endregion


            #region 13. Get the products with the highest price in each category

            //var categoryHighestPriceProducts = from p in ProductList
            //                                   group p by p.Category into g
            //                                   let highestPrice = g.Max(x => x.UnitPrice)
            //                                   select new
            //                                   {
            //                                       Category = g.Key,
            //                                       Products = g.Where(x => x.UnitPrice == highestPrice)
            //                                   };
            //foreach (var category in categoryHighestPriceProducts)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 14. Get the average price of each category's products
            //   var categoryAveragePrices = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });
            //foreach (var category in categoryAveragePrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Average Price: {category.AveragePrice}");
            //}
            #endregion

            #endregion


            #region LINQ - Set Operators


            #region 1. Find the unique Category names from Product List

            //var UniqueCategories = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var Category in UniqueCategories)
            //{
            //    Console.WriteLine(Category);
            //}

            #endregion


            #region 2. Produce a Sequence containing the unique first letter from both product and customer names

            //var ProductFirstLetters = ProductList
            //    .Select(p => p.ProductName[0]);

            //var CustomerFirstLetters = CustomerList
            //    .Select(c => c.CompanyName[0]);

            //var UniqueFirstLetters = ProductFirstLetters
            //    .Union(CustomerFirstLetters);

            //foreach (var Letter in UniqueFirstLetters)
            //{
            //    Console.WriteLine(Letter);
            //}

            #endregion


            #region 3. Create one sequence that contains the common first letter from both product and customer names

            //var ProductFirstLetters = ProductList
            //    .Select(p => p.ProductName[0]);

            //var CustomerFirstLetters = CustomerList
            //    .Select(c => c.CompanyName[0]);

            //var CommonFirstLetters = ProductFirstLetters
            //    .Intersect(CustomerFirstLetters);

            //foreach (var Letter in CommonFirstLetters)
            //{
            //    Console.WriteLine(Letter);
            //}

            #endregion


            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names

            //var ProductFirstLetters = ProductList
            //    .Select(p => p.ProductName[0]);

            //var CustomerFirstLetters = CustomerList
            //    .Select(c => c.CompanyName[0]);

            //var ProductOnlyFirstLetters = ProductFirstLetters
            //    .Except(CustomerFirstLetters);

            //foreach (var Letter in ProductOnlyFirstLetters)
            //{
            //    Console.WriteLine(Letter);
            //}

            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var ProductLastThreeCharacters = ProductList
            //    .Select(p => p.ProductName.Substring(p.ProductName.Length - 3));

            //var CustomerLastThreeCharacters = CustomerList
            //    .Select(c => c.CompanyName.Substring(c.CompanyName.Length - 3));

            //var LastThreeCharacters = ProductLastThreeCharacters
            //    .Concat(CustomerLastThreeCharacters);

            //foreach (var Characters in LastThreeCharacters)
            //{
            //    Console.WriteLine(Characters);
            //}

            #endregion

            #endregion



            #region LINQ - Partitioning Operators


            #region 1. Get the first 3 orders from customers in Washington

            //var FirstThreeOrdersFromWashington = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //foreach (var Order in FirstThreeOrdersFromWashington)
            //{
            //    Console.WriteLine(Order);
            //}

            #endregion


            #region 2. Get all but the first 2 orders from customers in Washington

            //var OrdersExceptFirstTwoFromWashington = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var Order in OrdersExceptFirstTwoFromWashington)
            //{
            //    Console.WriteLine(Order);
            //}

            #endregion


            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var NumbersUntilPositionCondition = numbers
            //    .TakeWhile((Number, Index) => Number >= Index);

            //foreach (var Number in NumbersUntilPositionCondition)
            //{
            //    Console.WriteLine(Number);
            //}

            #endregion


            #region 4. Get the elements of the array starting from the first element divisible by 3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var NumbersFromFirstDivisibleBy3 = numbers
            //    .SkipWhile(Number => Number % 3 != 0);

            //foreach (var Number in NumbersFromFirstDivisibleBy3)
            //{
            //    Console.WriteLine(Number);
            //}

            #endregion


            #region 5. Get the elements of the array starting from the first element less than its position

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var NumbersFromFirstLessThanPosition = numbers
            //    .SkipWhile((Number, Index) => Number >= Index);

            //foreach (var Number in NumbersFromFirstLessThanPosition)
            //{
            //    Console.WriteLine(Number);
            //}

            #endregion

            #endregion



            #region LINQ - Quantifiers


            #region 1. Determine if any of the words in dictionary_english.txt contain the substring "ei"

            //var Words = File.ReadAllLines("dictionary_english.txt");

            //bool ContainsEI = Words.Any(Word => Word.Contains("ei"));

            //Console.WriteLine($"Any word contains 'ei': {ContainsEI}");

            #endregion


            #region 2. Return a grouped list of products only for categories that have at least one product that is out of stock

            //var CategoriesWithOutOfStockProducts = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var Category in CategoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"Category: {Category.Key}");

            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"  Product: {Product.ProductName}");
            //    }
            //}

            #endregion


            #region 3. Return a grouped list of products only for categories that have all of their products in stock

            //var CategoriesWithAllProductsInStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var Category in CategoriesWithAllProductsInStock)
            //{
            //    Console.WriteLine($"Category: {Category.Key}");

            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"  Product: {Product.ProductName}");
            //    }
            //}

            #endregion

            #endregion



            #region LINQ - Grouping Operators


            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int>
            //{
            //    0, 1, 2, 3, 4,
            //    5, 6, 7, 8, 9,
            //    10, 11, 12, 13, 14,
            //    15
            //};

            //var NumberGroups = numbers
            //    .GroupBy(n => n % 5);

            //foreach (var Group in NumberGroups)
            //{
            //    Console.WriteLine($"Numbers with remainder {Group.Key}:");

            //    foreach (var Number in Group)
            //    {
            //        Console.WriteLine($"  {Number}");
            //    }
            //}

            #endregion


            #region 2. Use group by to partition a list of words by their first letter


            //var Words = File.ReadAllLines("dictionary_english.txt");

            //var WordsByFirstLetter = Words
            //    .GroupBy(w => w[0]);

            //foreach (var Group in WordsByFirstLetter)
            //{
            //    Console.WriteLine($"Words starting with '{Group.Key}':");

            //    foreach (var Word in Group)
            //    {
            //        Console.WriteLine($"  {Word}");
            //    }
            //}

            #endregion


            #region 3. Use Group By with a custom comparer that matches words
            // that consist of the same Characters Together

            string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            var GroupedWords = Arr
                .GroupBy(
                    word => word
                , new AnagramComparer());

            foreach (var Group in GroupedWords)
            {
                Console.WriteLine($"Key: {Group.Key}");

                foreach (var Word in Group)
                {
                    Console.WriteLine($"  {Word}");
                }
            }

            #endregion

            #endregion




        }
    }

}
