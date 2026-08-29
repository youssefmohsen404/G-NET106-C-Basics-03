namespace G_NET106_C_Basics_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Given int pages = 464; and bool isAvailable = true;,
            //print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator.
            /*int pages = 464;
            bool isAviliable = true;
            if(pages == 464 && isAviliable)
            {
                Console.WriteLine("you can borrow this book");
            }
            else
            {
                Console.WriteLine("you can't borrow this book");
            }*/

            #endregion
            #region Question2
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
            //"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";
            /*  Console.WriteLine("please enter a string");
              string title = Console.ReadLine();
              switch (title)
              {
                  case "Clean Code":
                      Console.WriteLine("great choice");
                      break;
                  case "Refactoring":
                      Console.WriteLine("Nice pick");
                      break;
                  default: Console.WriteLine("Never heard of it");
                      break;
              }*/
            #endregion
            #region Question3
            //. Given int pages = 464;,
            //use the ternary operator to store "Long Book" or "Short Book"
            //into a variable sizeLabel (same rule as question 6: long if pages > 300).

         /*   int pages = 464;
            string bookSize = pages > 300 ? "long book" : "short book";
            Console.WriteLine(bookSize);*/
            #endregion
        }
    }
}
