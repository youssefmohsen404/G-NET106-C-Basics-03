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
            #region Question4
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            //use a for loop to print each book with its position number, like 1. Clean Code.

            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
             for(int i = 0; i <= 2; i++)
             {
                 Console.WriteLine(books[i]);
             }*/
            #endregion
            #region Question5
            //. Using the same books array, use a while loop to print every book title.
            /*string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int counter = 0;
            while(counter < 3)
            {
                Console.WriteLine(books[counter]);
                counter++;
            }*/

            #endregion
            #region Question6
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
            /*     int counter = 0;
                 do
                 {
                     Console.WriteLine("Checking book...");
                     counter++;
                 } while (counter < 3);*/
            #endregion
            #region Question7
            //. Using the same books array, use a foreach loop to print every book title.
            /*  string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
              foreach (string book in books)
              {
                  Console.WriteLine(book);
              }*/
            #endregion
            #region Question8
            //Using the same books array, loop through it and print each title,
            //but stop completely (break) once you reach "Refactoring".
            /*   string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
               for (int i = 0; i <= 2; i++) {
                   if (books[i]== "Refactoring")
                   {
                       break;

                   }
                   Console.WriteLine(books[i]);


               }*/
            #endregion
            #region Question9
            //. Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            /*    string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                foreach(string book in books)
                {
                    if(book == "The Pragmatic Programmer")
                    {
                        continue;
                    }
                    Console.WriteLine(book);
                }*/
            #endregion
            #region Question10
            //Write a method PrintFirstBook() that prints the first book in the books array.
            //If the array is empty, use return to exit the method early instead of printing anything.
            /*string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            void PrintFirstBook()
            {
                Console.WriteLine(books[0]);
                return;
            }
            PrintFirstBook();*/
            #endregion
        }
    }
}
