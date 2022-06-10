using System;
using System.Collections.Generic;
using System.Text;

namespace PS_Assign1
{
    class Book
    {
        // Backing Fields
        private string bookTitle;
        private double unitPrice;
        private int bookCount;

        // properties
        public string BookTitle
        {
            get
            {
                return bookTitle;
            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
        }
        public int BookCount
        {
            get
            {
                return bookCount;
            }
            set
            {
                bookCount = value;
            }
        }
        // This is a computed read only property
        public double BookSubTotal
        {
            get
            {
                return (BookCount * UnitPrice);
            }
        }

        //Constructor overloading is displayed below.

        public Book()
        {
            //empty constructor
        }
        public Book(string anyBookTitle, double anyUnitprice)
        {
            //Only this constructor is used in main program. 
            bookTitle = anyBookTitle;
            unitPrice = anyUnitprice;
        }
        public Book(string anyBookTitle, double anyUnitPrice, int anyBookCount, double anyBookSubTotal)
        {
            // This constructor is only for demonstration because it is not used in main program.
            bookTitle = anyBookTitle;
            unitPrice = anyUnitPrice;
            bookCount = anyBookCount;
        }

        // ToString is uesd here to display formatted output onto console window
        public override string ToString()
        {
            /* Every string is concatenated in outputStr to create the book details part of banner and at last
             * it is returned. */
            string outputStr = string.Format("*{0,40}: {1,-37}*\n","Title",BookTitle);
            outputStr += string.Format("*{0,40}: {1,-37:C}*\n", "Unit Price", UnitPrice);
            outputStr += string.Format("*{0,40}: {1,-37}*\n", "Book Count", BookCount);
            outputStr += string.Format("*{0,40}: {1,-37:C}*\n", "Book Sub Total", BookSubTotal);
            outputStr += string.Format("*{0,80}", "*");

           return outputStr;
        }
    }
}
