using System;
using static System.Console;

namespace PS_Assign1
{
    class Program
    {
        static void Main(string[] args)
        {   // main program starts from here:

            /* Firstly, three different objects of same class are initialised for three different 
               books in next three lines of code and initialising their unit price for each one.*/
            Book paperBagPrincess = new Book("Paper bag Princess", 9.99);
            Book diaryOfAWimpyKid = new Book("Diary of a Wimpy Kid", 14.99);
            Book dogMan = new Book("Dog man", 17.99);

            /* Now initial lines are printed to display first look of wholesale operating system
             * by using WriteLine method.*/ 
            WriteLine("Welcome to wholesale book ordering system!");
            WriteLine("You can place orders for three different book counts!");
            WriteLine("\nThe books we have in stock are...");

            /* Book title and its unit price is printed by using objects of each book
             * with the help of formatted output.*/
            WriteLine("{0} with unit price {1:C}",paperBagPrincess.BookTitle,
                                                paperBagPrincess.UnitPrice);
            WriteLine("{0} with unit price {1:C}", diaryOfAWimpyKid.BookTitle,
                                                 diaryOfAWimpyKid.UnitPrice);
            WriteLine("{0} with unit price {1:C}", dogMan.BookTitle, dogMan.UnitPrice);
            WriteLine("\n\nLet us begin by entering the counts for these books");

            /* LoadBookCount is called three times and each time passing the object of corresponsing 
             * book into that mathod.*/
            LoadBookCount(paperBagPrincess);
            LoadBookCount(diaryOfAWimpyKid);
            LoadBookCount(dogMan);

            PerformUserAction(paperBagPrincess, diaryOfAWimpyKid, dogMan);

            ReadKey();
        }// Main method ends here.


        // Method LoadBookCount starts from here.
        /* Next method is a non returning(void) and static method which takes only one parameter
         * that is object of class Book. This method asks user to enter the amount of they want to
         * purchase and loads that amount in one of property(Booktitle) of class Book. */
        static void LoadBookCount(Book anyBook)
        {
            /* Next line of code is asking user to enter the amount of books they want to buy */
            Write("Enter the book count for {0}: ", anyBook.BookTitle);

            /* Next line of code in initializing a variable called BookCount and this variable is
             used to store the valve that is entered by user*/
            int BookCount = int.Parse(ReadLine());

            /*Next instruction is used to update the value of property(BookCount) of class(Book)
             * by using its object.*/
            anyBook.BookCount = BookCount;
        }// method LoadBookCount ends here.

        // Method PerformUserAction starts from here.
        /* The method PerformUserAction is a static and void returning  method which takes three 
         Book objects as parameters. It displays three action options for user using numbered 
         input.*/
        static void PerformUserAction(Book book1,Book book2,Book book3)
        {
            /* Next two lines code is asking user what would you like to do and giving them options
             * such as press 1 for view order, press 2 for Update Order, Press 3 for qutting the
             * application with the help of WriteLine method. */
            WriteLine("\n\nWhat would you like to do?");
            Write("Press 1 for View Order, Press 2 for update Order," +
                      "Press 3 for quitting the application: ");

            /* Now an interger variable(userinput) is initialized and response given by user 
             is stored in userinput by converting inputed string into integer by using iny.Parse*/
            int userinput = int.Parse(ReadLine());

            /* Now decision statement(if) is used to distinguish the user input.
               In first if statement(if(userinput==1)), it is checking if userinput is equal to 1,
               if it is true then only program execution will enter the if statement otherwise it
               will go to next statement.*/
            if (userinput==1)
            {
                /* The following instruction is only executed if above condition is true and next 
                   instruction is calling the method ViewOrder and passing three parameters 
                   which are book1,book2,book3.*/
                Console.Clear();
                ViewOrder(book1 , book2 , book3);
            }

            /* Second if statement(if(userinput==2)) is checking if userinput is equal to 2 or not.*/
            if (userinput == 2)
            {
                /* if userinput=2 then this instruction is calling the UpdateOrder 
                 * which takes three objects of class Book as parameters(book1,book2,book3) */
                Console.Clear();
                UpdateOrder(book1, book2, book3);
            }

            /* Third if statement(if(userinput==3)) is checking if userinput is equal to 3 or not. */
            if (userinput == 3)
            {
                /* if above condition is true then next two line of code is clearing the console 
                 * window and then printing a line (Thank you for placing an order with us.
                 * Good Bye!)onto console window by using WriteLine method.*/
                Console.Clear();
                WriteLine("Thank you for placing an order with us. Good Bye!");
            }
        }// Method PerformUserAction ends here

        // Mehhod ViewOrder starts from here.
        /* Next method is a static void method which takes three objects as input parameters(book1,
         * book2,book3). This function of this method is to diaplay a output banner onto console
         * window showing details of every book and total amount, taxes discount etc.*/
        static void ViewOrder(Book book1, Book book2 ,Book book3)
        {
            /* This  is the first line shown onto console window */
            WriteLine("\n\nOkay! Lets view your order!\n\n");

            /* Below line is printing a string of 81 astricks in total onto console window 
             * which is the first line of output banner.*/
            WriteLine(new string('*' , 81));

            /* In next three lines, details of every book is printed onto console window by 
             * using object.ToString method. Details of all three books has to be printed , thus
             * toString method is called three times.*/
            WriteLine(book1.ToString());
            WriteLine(book2.ToString());
            WriteLine(book3.ToString());

            /* The below line calls the method called GetOrderTotals by passing three objects into
             its parameters and its three output parameters. As GetOrderTotals is a double 
             returning type method so the returned value is stored into a variable called 
             totalAfterTaxAndDiscount.*/
            double totalAfterTaxAndDiscount = GetOrderTotals(book1, book2, book3,
                                              out double totalBeforeTaxAndDiscount, 
                                              out double taxes, out double discountAmount);

            /* The output banner continues and below four lines of code is printing a formatted
             * output onto console window by using out parameters of GetOrderTotals.*/
            WriteLine("*{0,40}: {1,-37:C}*", "Total before tax and discount", 
                                              totalBeforeTaxAndDiscount);
            WriteLine("*{0,40}: {1,-37:C}*", "Taxes", taxes);
            WriteLine("*{0,40}: {1,-37:C}*", "Discount", discountAmount);
            WriteLine("*{0,40}: {1,-37:C}*", "Total after tax and discount", 
                                              totalAfterTaxAndDiscount);

            /* This is the last line of output banner which is printing a string of 81 astricks  */
            WriteLine(new string('*', 81));

            /* PerformUserAction(method) is called at the end of ViewOrder(method) so that user 
             can select an appropriate option after viewing its order.*/
            PerformUserAction(book1, book2, book3);

        }// Method ViewOrder ends here.


        // Method GetOrderTotals starts from here.
        /* The following method is a static double returing type method with thress Book object 
         * (book1,book2,book3) as input parameters and also contains three out parameters named as 
         * totalBeforeTaxAndDiscount,taxes,discountAmount*/
        static double GetOrderTotals(Book book1,Book book2,Book book3,
                                     out double totalBeforeTaxAndDiscount,
                                     out double taxes,out double discountAmount)
        {
            /* Total amount before applying taxes ia calculated in below line of code which will
             * be sum of every sub total of books.This sum is stored in a variable called
             * totalBeforeTaxAndDiscount */
            totalBeforeTaxAndDiscount = book1.BookSubTotal + book2.BookSubTotal + book3.BookSubTotal;

            /* Now taxes are calulated by follwing formula which is 7% of total amount before taxes 
             * or 7% of variable totalBeforeTaxAndDiscount*/
            taxes = (totalBeforeTaxAndDiscount * 7) / 100;


            discountAmount = 0.0;

            /* Now extra discount is given depending upon the total amount of ordered books.
             * if total amount before taxes(i.e.totalBeforeTaxAndDiscount ) is greater than 300
             * then only program execution is allowed to enter the if statement. */
            if (totalBeforeTaxAndDiscount>300.00)
            {
                /* Now discounted amount is calculated in variable called discountAmount which is 
                 * 10% of variable (totalBeforeTaxAndDiscount) */
                discountAmount = totalBeforeTaxAndDiscount / 10;
            }

            /* Total amount after tax and discount is calulated in totalAfterTaxAndDiscount(variable)
             * by adding total amount before taxes(totalBeforeTaxAndDiscount) with taxes and 
             * subtracting discounted amonut(discountAmount) from them. */
            double totalAfterTaxAndDiscount = totalBeforeTaxAndDiscount + taxes - discountAmount;

            /* As above method is returning type so total amount after tax and discount which is 
             * stored in totalAfterTaxAndDiscount is returned. */
            return totalAfterTaxAndDiscount;

        }//Method GetOrderTotals ends here

        // method UpdateOrder starts from here.
        /* The below method is a static void returning type method which take three Book objects as
         * as input parameters(book1,book2,book3). Update order method is used to change the value 
         * of ordered books. */
        static void UpdateOrder(Book book1, Book book2, Book book3)
        {
            /* The next two lines of code is asking user for which book they want to update their 
             * order by printing Press 1 to update book counts for book1 , Press 2 to update book
             * counts for book2, Press 3 to update book counts for book3.*/
            WriteLine("\n\nOkay! Lets update your order!\n\n");
            Write("Press 1 to update book counts for {0}, Press 2 to update book counts for {1}," +
                      " Press 3 to update book counts for {2}: ", book1.BookTitle, book2.BookTitle, 
                        book3.BookTitle);

            /* User's response is stored in interger variable(userinput) by converting the inputed 
             * string to integer with the help of int.Parse */
            int userinput = int.Parse(ReadLine());

            /* user input is checked by if statement(if(userinput==1)). program execution will enter 
             * the IF statement if uererinput is equal to 1.*/
            if (userinput == 1)
            {
                /* Now the user wannts to change the book count for first book.Thus user is asked 
                 * to enter the new book count for first book by WriteLine method in next line 
                 * of code.*/
                Write("Enter the new counts for {0}: ", book1.BookTitle);

                /* The entered string is converted into interger by using int.parse and passed into
                 * the object of corresponding book.*/
                book1.BookCount = int.Parse(ReadLine());

                /* Next line Prints the message that book count for first book has been changed to 
                 * entered amount.*/
                WriteLine("Great! Book counts for {0} has been updated to {1}",book1.BookTitle,
                           book1.BookCount);
            }

            /* The same process which was followed in first if statement for changing the book 
             * count for first book is applied in second if statement for changing the book count
             * for second book.*/
            if (userinput == 2)
            {
                Write("Enter the new counts for {0}: ", book2.BookTitle);
                book2.BookCount = int.Parse(ReadLine());
                WriteLine("Great! Book coints for {0} has been updated to {1}", 
                           book2.BookTitle, book2.BookCount);
            }

            /* Again the same process is repeated for third if statement as first two if statements. */
            if (userinput == 3)
            {
                Write("Enter the new counts for {0}: ", book3.BookTitle);
                book3.BookCount = int.Parse(ReadLine());
                WriteLine("Great! Book coints for {0} has been updated to {1}", 
                           book3.BookTitle, book3.BookCount);
            }

            /* Now program execution is directed to PerformUserAction method for further processing. */
            PerformUserAction(book1, book2, book3);
        }// Method UpdateOrder ens here.
    }// class Program ends here
}// namespace ends here
