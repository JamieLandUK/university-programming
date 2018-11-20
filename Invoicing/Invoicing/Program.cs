using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing
{
    class Invoice
    {
        public string Num { get; set; }
        public string Desc { get; set; }
        private int _amount;
        private double _price;

        public Invoice()
        {
            Num = "";
            Desc = "";
            _amount = 0;
            _price = 0.00;
        }

        public Invoice(string n, string d, int a, double p)
        {
            Num = n;
            Desc = d;
            _amount = a;
            _price = p;
        }

        public int Amount
        {
            get
            {
                if (_amount < 0)
                {
                    return 0;
                }
                else
                {
                    return _amount;
                }
            }
            set
            {
                if (value < 0)
                {
                    _amount = 0;
                }
                else
                {
                    _amount = value;
                }
            }
        }

        public double Price
        {
            get
            {
                if (_price < 0)
                {
                    return 0.00;
                }
                else
                {
                    return _price;
                }
            }
            set
            {
                if (value < 0)
                {
                    _price = 0.00;
                }
                else
                {
                    _price = value;
                }
            }
        }

        public double GetInvoiceAmount()
        {
            return Price * Amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice i1 = new Invoice("1234", "Hammer", 2, 14.95);
            Invoice i2 = new Invoice("5678", "Paint Brush", -7, -999.21);

            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", i1.Num);
            Console.WriteLine("Description: {0}", i1.Desc);
            Console.WriteLine("Quantity: {0}", i1.Amount);
            Console.WriteLine("Price: {0}", String.Format("{0:00.00}", i1.Price));
            Console.WriteLine("Invoice amount: {0}", String.Format("{0:00.00}", i1.GetInvoiceAmount()));
            Console.WriteLine();

            i1.Num = "001234";
            i1.Desc = "Yellow Hammer";
            i1.Amount = 3;
            i1.Price = 19.49;

            Console.WriteLine("Updated invoice information");
            Console.WriteLine("Part number: {0}", i1.Num);
            Console.WriteLine("Description: {0}", i1.Desc);
            Console.WriteLine("Quantity: {0}", i1.Amount);
            Console.WriteLine("Price: {0}", String.Format("{0:00.00}", i1.Price));
            Console.WriteLine("Invoice amount: {0}", String.Format("{0:00.00}", i1.GetInvoiceAmount()));
            Console.WriteLine();

            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", i2.Num);
            Console.WriteLine("Description: {0}", i2.Desc);
            Console.WriteLine("Quantity: {0}", i2.Amount);
            Console.WriteLine("Price: {0}", String.Format("{0:00.00}", i2.Price));
            Console.WriteLine("Invoice amount: {0}", String.Format("{0:00.00}", i2.GetInvoiceAmount()));
            Console.WriteLine();

            i2.Amount = 3;
            i2.Price = 9.49;

            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", i2.Num);
            Console.WriteLine("Description: {0}", i2.Desc);
            Console.WriteLine("Quantity: {0}", i2.Amount);
            Console.WriteLine("Price: {0}", String.Format("{0:00.00}", i2.Price));
            Console.WriteLine("Invoice amount: {0}", String.Format("{0:00.00}", i2.GetInvoiceAmount()));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
