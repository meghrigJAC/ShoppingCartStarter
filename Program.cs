namespace ShoppingCartStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of items
           

            //Ask the user to enter the first price


            //Check for sentinel value
           

            //Process data results


        }

        /*
         * GetUserInput method gets a valid input from the user.
         */

        public static decimal GetUserInput(string message, decimal min)
        {
            Console.WriteLine(message);
            bool valid = decimal.TryParse(Console.ReadLine(), out decimal input);

            while (!valid)
            {
                Console.Write($"Please enter a valid price");
                valid = decimal.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }

        /* 
         * Printing Receipt method
         */
        static void PrintReceipt(List<decimal> list)
        {
            List<decimal> discountedList = GetDiscountedList(list);
            Console.WriteLine("Receipt");
            //Header
            Console.WriteLine($"{"Regular Price",20} {"Discounted Price",20}");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i],20:c} {discountedList[i],20:c}");
            }

            Console.WriteLine($"{"Total",20} {"Total",20}");
            Console.WriteLine($"{GetTotal(list),20:c} {GetTotal(discountedList),20:c}");

            Console.WriteLine($"The Cheapest Item before discount is {list[GetCheapest(list)]:c}");
            Console.WriteLine($"The Cheapest Item after discount is {discountedList[GetCheapest(discountedList)]:c}");
            Console.WriteLine($"The Most Expensive Item before discount is {list[GetMostExpensive(list)]:c}");
            Console.WriteLine($"The Most Expensive Item after discount is {discountedList[GetMostExpensive(discountedList)]:c}");
        }

        /*
         * GetCheapest method returns the index of the cheapest item
         */

        static int GetCheapest(List<decimal> list)
        {
           
        }

        /*
        * GetMostExpensive method returns the index of the most expensive item
        */

        static int GetMostExpensive(List<decimal> list)
        {
            
        }

        /*
        * GetTotal method returns the Total of the items in the list
        */
        static decimal GetTotal(List<decimal> list)
        {
            
        }

        /*
        * GetDiscountedList method generates and returns a new list that has the disocunted items in it
        */

        static List<decimal> GetDiscountedList(List<decimal> list)
        {
            
        }
    }
}